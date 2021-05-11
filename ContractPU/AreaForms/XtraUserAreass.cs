using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractPU.AreaForms
{
    public partial class XtraUserAreass : DevExpress.XtraEditors.XtraUserControl
    {
        
        public XtraUserAreass()
        {
            InitializeComponent();
            LoadData();
                                
        }

        public void LoadData()
        {
            using (var db = new PUEntitiesOne())
            {
                var data = db.Areas.ToList();
                gridControlArea.DataSource = data;
                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
        }

        public void DataCheck(Area area)
        {
            if (area == null)
            {
                MessageBox.Show("Първо трябва да селектирате запис от таблицата");
                return;
            }
        }

        private void DeleteOperation()
        {
            var area = gridView1.GetFocusedRow() as Area;
            //id = int.Parse(gridView1.GetFocusedRowCellValue("id").ToString());
            //int idArea = int.Parse(area.id.ToString());

            DataCheck(area);

            DialogResult dialogresult = MessageBox.Show("Желаете ли да изтриете този запис", "Подтвърдете", MessageBoxButtons.YesNo);

            if (dialogresult == DialogResult.Yes)
            {
                using (var db = new PUEntitiesOne())
                {
                    //bool educator = db.Educators.Any(x => x.areaId == area.id);
                    //bool courses = db.Courses.Any(x => x.areaId == area.id);

                    //if (educator || courses)
                    //{
                    //    MessageBox.Show("Имате съществуващ запис в друга таблица с тези данни");
                    //    return;
                    //}

                    //db.DeleteArea(id);          
                    db.Entry(area).State = System.Data.Entity.EntityState.Deleted;
                    db.Areas.Remove(area);

                    try
                    {
                        db.SaveChanges();  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Имате съществуващ запис в друга таблица с тези данни");
                        return;
                        //MessageBox.Show(ex.ToString());
                    }                    
                    LoadData();
                }
            }
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControlArea.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addUpdate = new XtraFormAreaAddUpdate();
            
            if (addUpdate.ShowDialog() == DialogResult.OK)
            {

            }
            LoadData();

        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteOperation();
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                OnKeyPress(new KeyPressEventArgs((char)Keys.Delete));
                DeleteOperation();
            }
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Edit();
            LoadData();
        }

        private void Edit()
        {
            var addUpdate = new XtraFormAreaAddUpdate();


            using (var db = new PUEntitiesOne())
            {

                var area = gridView1.GetFocusedRow() as Area;
                DataCheck(area);

                addUpdate.Pass(area);

                if (addUpdate.ShowDialog() == DialogResult.OK)
                {

                }

            }
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void gridControl_Load(object sender, EventArgs e)
        {
            //LoadData();

        }

        private void XtraUserAreass_Resize(object sender, EventArgs e)
        {

        }

        private void XtraUserAreass_SizeChanged(object sender, EventArgs e)
        {

        }

        private void XtraUserAreass_Load(object sender, EventArgs e)
        {

        }

        private void gridControl_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void gridControlArea_DoubleClick(object sender, EventArgs e)
        {
            Edit();
            LoadData();
        }
    }
}
