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

namespace ContractPU.Reference.CoursesByArea
{
    public partial class XtraUserControlCoursesByArea : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControlCoursesByArea()
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
                var data = db.Courses.Include(e => e.Area).Include(e => e.Educator).ToList();
                gridControl.DataSource = data;

                var area = db.Areas.ToList();

                repositoryItemTreeListLookUpEdit3.DataSource = area;

                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
        }
        

        private void gridControl_Click(object sender, EventArgs e)
        {
            var selected = gridView.GetFocusedRow() as Cours;

            textBoxProtocol.Text = selected.protocol;
            textEditEducator.Text = selected.Area.areaName;
            dateEditDate.DateTime = selected.courseDate;
            textEditTheme.Text = selected.theme;
            textEditAnotation.Text = selected.anotation;
        }

        private void barButtonItemView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormCourseInspect();
            var data = gridView.GetFocusedRow() as Cours;

            uc.Pass(data);

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
            LoadData();
        }

        private void barEditItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {           
            barEditDateFrom.EditValue = null;
            barEditDateTo.EditValue = null;
            barEditItemTreeList.EditValue = null;
            LoadData();

        }

        private void treeListLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void treeListLookUpEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void barEditDateFrom_EditValueChanged(object sender, EventArgs e)
        {
            using (var db = new PUEntitiesOne())
            {
                var data = db.Courses.ToList();

                DateTime dt = Convert.ToDateTime(barEditDateFrom.EditValue);
                DateTime dt2 = Convert.ToDateTime(barEditDateTo.EditValue);


                //if (barEditItemTreeList.EditValue != null && dt2 != DateTime.MinValue && dt != DateTime.MinValue)
                //{
                //    var get = barEditItemTreeList.EditValue as Area;

                //    data = data
                //        .Where(x => x.areaId == get.id).ToList();
                //    gridControl.DataSource = data;
                //}

                data = data.Where(a => a.courseDate >= dt).ToList();

                if (dt2 < dt && dt2 != DateTime.MinValue)
                {
                    MessageBox.Show("Моля въведете валиден период");
                    barEditDateTo.EditValue = null;
                    return;
                }

                if (dt2 >= dt && dt2 != DateTime.MinValue)
                {
                    data = data.Where(a => a.courseDate <= dt2).ToList();
                }

                if (barEditItemTreeList.EditValue != null)
                {
                    var get = barEditItemTreeList.EditValue as Area;

                    data = data
                        .Where(x => x.areaId == get.id).ToList();

                }

                gridControl.DataSource = data;

            }
        }
    }
}
