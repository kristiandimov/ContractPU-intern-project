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

namespace ContractPU.Reference.ClalificationCourses
{
    public partial class XtraUserControlClalificationCourses : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControlClalificationCourses()
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
                var data = db.Courses.Include(x => x.Area).Include(x => x.Educator).ToList();
                gridControl.DataSource = data;

                repositoryItemTreeListLookUpEdit1.DataSource = db.Educators.ToList();

                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
        }

        private void gridControl_Click(object sender, EventArgs e)
        {
            var selected = gridView.GetFocusedRow() as Cours;

            textBoxProtocol.Text = selected.protocol;
            dateEditDate.EditValue = selected.courseDate;
            textEditTheme.Text = selected.theme;
            textEditEducator.Text = selected.Educator.educatorName;
            textEditAnotation.Text = selected.anotation;

        }

        private void barEditItemFrom_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            barEditItemFrom.EditValue = null;
            barEditItemTo.EditValue = null;
            barEditItemTreeList.EditValue = null;
        }

        private void barEditItemFrom_EditValueChanged(object sender, EventArgs e)
        {
            using (var db = new PUEntitiesOne())
            {
                var data = db.Courses.ToList();

                DateTime dt = Convert.ToDateTime(barEditItemFrom.EditValue);
                DateTime dt2 = Convert.ToDateTime(barEditItemTo.EditValue);

                data = data.Where(x => x.courseDate >= dt).ToList();

                if (dt > dt2 && dt2 != DateTime.MinValue)
                {
                    MessageBox.Show("Моля въведете валиден период");
                    barEditItemTo.EditValue = null;
                    return;
                }

                if (dt2 >= dt && dt2 != DateTime.MinValue)
                {
                    data = data.Where(x => x.courseDate <= dt2).ToList();
                }

                if (barEditItemTreeList.EditValue != null)
                {
                    var educator = barEditItemTreeList.EditValue as Educator;
                    data = data
                        .Where(x => x.educatorId == educator.id).ToList();

                    gridControl.DataSource = data;

                }

                gridControl.DataSource = data;

            }
        }

        private void XtraUserControlClalificationCourses_Load(object sender, EventArgs e)
        {

        }
    }
}
