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

namespace ContractPU.FacultyForms
{
    public partial class XtraUserControlFaculcy : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControlFaculcy()
        {
            InitializeComponent();
            LoadData();
            
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        public void LoadData()
        {

            using (var db = new PUEntitiesOne())
            {
                var data = db.Faculties.ToList();
                gridControl.DataSource = data;
                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
            
        }

        public void DataCheck(Faculty faculty)
        {
            if (faculty == null)
            {
                MessageBox.Show("Първо трябва да селектирате запис от таблицата");
                return;
            }
            
        }

        private void DeleteOperation()
        {
            var faculty = gridView.GetFocusedRow() as Faculty;

            DataCheck(faculty);

             

            DialogResult dialogResult = MessageBox.Show("Желаете ли да изтриете този запис", "Подтвърдете", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                using (var db = new PUEntitiesOne())
                {                    

                    db.Entry(faculty).State = System.Data.Entity.EntityState.Deleted;
                    db.Faculties.Remove(faculty);

                    try
                    {

                        db.SaveChanges();
                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Имате съществуващ запис в друга таблица с тези данни");
                        return;
                    }



                    LoadData();
                }
            }
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var addUpdate = new XtraFormAddUpdateFaculcy();

            if (addUpdate.ShowDialog() == DialogResult.OK)
            {

            }

            LoadData();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Edit();
            LoadData();
        }

        private void Edit()
        {
            var addUpdate = new XtraFormAddUpdateFaculcy();

            using (var db = new PUEntitiesOne())
            {
                var faculty = gridView.GetFocusedRow() as Faculty;
                DataCheck(faculty);
                addUpdate.Pass(faculty);
            }

            if (addUpdate.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {

            DeleteOperation();

        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteOperation();
            }
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            Edit();
            LoadData();
        }
    }
}
