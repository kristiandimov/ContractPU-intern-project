using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractPU.EducatiorForms
{
    public partial class XtraUserControlEducators : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControlEducators()
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
                //Include го използваме да заредим връзките (lazy loading check!!!)
                var data = db.Educators
                    .Include(e => e.Area)
                    .Include(e => e.Faculty)
                    .ToList();

                repositoryItemTreeListLookUpEdit1.DataSource = db.Areas.ToList();
                repositoryItemTreeListLookUpEdit2.DataSource = db.Faculties.ToList();

                gridControl.DataSource = data;
                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
        }

        public void DataCheck(Educator data)
        {
            if (data == null)
            {
                MessageBox.Show("Трябва да селектирате запис от таблицата");
                return;
            }
        }

        private void DeleteOperation()
        {
            var edu = gridView.GetFocusedRow() as Educator;
            DataCheck(edu);

            DialogResult dialogResult = MessageBox.Show("Желаете ли да изтриете този запис", "Подтвърдете", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                using (var db = new PUEntitiesOne())
                {
                    //db.Entry(edu).State = EntityState.Deleted;
                    db.Educators.Attach(edu);
                    db.Educators.Remove(edu);

                    try
                    {
                        db.SaveChanges();
                       
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Имате съществуващ запис в друга таблица с тези данни");
                       
                        return;
                    }

                }
            }            
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAddUpdateEducator();

            if (uc.ShowDialog() == DialogResult.OK)
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
            var uc = new XtraFormAddUpdateEducator();
            var edu = gridView.GetFocusedRow() as Educator;

            DataCheck(edu);
            uc.Pass(edu);

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteOperation();
            LoadData();

        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void gridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteOperation();
            }

            LoadData();
            
        }

        private void XtraUserControlEducators_Load(object sender, EventArgs e)
        {
           
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            Edit();

            LoadData();
        }

        private void barEditItemTreeArea_EditValueChanged(object sender, EventArgs e)
        {
            using (var db = new PUEntitiesOne())
            {
                var data = db.Educators
                    .Include(x => x.Area)
                    .Include(x => x.Faculty)
                    .ToList();

                if (barEditItemTreeArea.EditValue != null)
                {
                    var area = barEditItemTreeArea.EditValue as Area;
                    data = data
                        .Where(x => x.areaId == area.id)
                        .ToList();

                }

                if (barEditItemTreeListFaculty.EditValue != null)
                {
                    var faculty = barEditItemTreeListFaculty.EditValue as Faculty;

                    data = data
                        .Where(x => x.faculcyId == faculty.id)
                        .ToList();

                }

                gridControl.DataSource = data;

            }
            
        }

        private void barEditItemTreeArea_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItemClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            barEditItemTreeArea.EditValue = null;
            barEditItemTreeListFaculty.EditValue = null;
        }
    }
}
