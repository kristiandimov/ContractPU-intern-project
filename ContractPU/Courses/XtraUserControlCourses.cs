using ContractPU.AreaForms;
using ContractPU.EducatiorForms;
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

namespace ContractPU.Courses
{
    public partial class XtraUserControlCourses : XtraUserControl
    {
        public XtraUserControlCourses()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            using (var db = new PUEntitiesOne())
            {
                var data = db.Courses
                    .Include(x => x.Area)
                    .Include(x => x.Educator)
                    .ToList();

                var area = db.Areas.ToList();

                var educator = db.Educators
                    .Include(x => x.Area)
                    .Include(x => x.Faculty)
                    .ToList();

                treeListLookUpEditArea.Properties.DataSource = area;
                treeListLookUpEditEducator.Properties.DataSource = educator;

                repositoryItemTreeListLookUpEdit1.DataSource = area;
                repositoryItemTreeListLookUpEdit2.DataSource = educator;


                gridControl.DataSource = data;
              
                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormCourses();

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
            var uc = new XtraFormCourses();
            var course = gridView.GetFocusedRow() as Cours;

            uc.Pass(course);

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteOperation();

            LoadData();
        }

        private void DeleteOperation()
        {
            var cour = gridView.GetFocusedRow() as Cours;

            DialogResult dialogResult = MessageBox.Show("Желаете ли да изтриете този запис", "Подтвърдете", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                using (var db = new PUEntitiesOne())
                {
                    db.Courses.Attach(cour);
                    db.Courses.Remove(cour);

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

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            barEditItemFrom.EditValue = null;
            barEditItemTo.EditValue = null;
            barEditItemTreeListArea.EditValue = null;
            barEditItemTreeListEducator.EditValue = null;

        }

        private void gridControl_KeyDown(object sender, KeyEventArgs e)
        {
            DeleteOperation();
            LoadData();
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            Edit();
            LoadData();
        }

        private void barButtonItemArea_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAreaAddUpdate();

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void barButtonItemEducator_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAddUpdateEducator();

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void gridControl_Click(object sender, EventArgs e)
        {
            var data = gridView.GetFocusedRow() as Cours;

            textEditProtocol.Text = data.protocol;
            dateEditDate.DateTime = data.courseDate;
            textEditThema.Text = data.theme;
            treeListLookUpEditArea.EditValue = data.areaId;
            treeListLookUpEditEducator.EditValue = data.educatorId;
            textEditCount.Text = data.totalHour.ToString();
            textEditCountKV.Text = data.totalCredit.ToString();
            memoEditAnotation.Text = data.anotation;

        }

        private void barEditItemFrom_EditValueChanged(object sender, EventArgs e)
        {
            using (var db = new PUEntitiesOne())
            {

                var data = db.Courses
                    .Include(x => x.Area)
                    .Include(x => x.Educator)
                    .ToList();

                DateTime dt = Convert.ToDateTime(barEditItemFrom.EditValue);
                DateTime dt2 = Convert.ToDateTime(barEditItemTo.EditValue);

                data = data.Where(a => a.courseDate >= dt).ToList();

                if (dt2 < dt && dt2 != DateTime.MinValue)
                {
                    MessageBox.Show("Моля въведете валиден период");
                    barEditItemTo.EditValue = null;
                    return;
                }

                if (dt2 >= dt && dt2 != DateTime.MinValue)
                {
                    data = data.Where(a => a.courseDate <= dt2).ToList();
                }

                if (barEditItemTreeListArea.EditValue != null)
                {
                    var contragent = barEditItemTreeListArea.EditValue as Area;

                    data = data.Where(x => x.areaId == contragent.id).ToList();

                }

                if (barEditItemTreeListEducator.EditValue != null)
                {
                    var educator = barEditItemTreeListEducator.EditValue as Educator;

                    data = data.Where(x => x.educatorId == educator.id).ToList();

                }
                
                gridControl.DataSource = data;
            }
        }

        private void barEditItemFrom_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItemClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            barEditItemFrom.EditValue = null;
            barEditItemTo.EditValue = null;
            barEditItemTreeListArea.EditValue = null;
            barEditItemTreeListEducator.EditValue = null;
        }
    }
}
