using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
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

namespace ContractPU.Reference.Educations
{
    public partial class XtraUserControlEducations : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControlEducations()
        {
            InitializeComponent();
            LoadData();
            
           
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraReportEducationnnss();
            ReportPrintTool reportPrintTool = new ReportPrintTool(uc);
            reportPrintTool.ShowPreview();
            //gridControl.ShowRibbonPrintPreview();
        }
        public void LoadData()
        {
            using (var db = new PUEntitiesOne())
            {
                repositoryItemTreeListLookUpEdit1.DataSource = db.Courses.ToList();

                var data = db.Contracts
                    .Include(x => x.Cours)
                    .Include(x => x.Educator)
                    .Include(x => x.Contraget)
                    .ToList();
                gridControl.DataSource = data;

                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            barEditItemFrom.EditValue = null;
            barEditItemTo.EditValue = null;
            barEditItemTreeList.EditValue = null;
            LoadData();

        }

        private void barEditItemFrom_EditValueChanged(object sender, EventArgs e)
        {
            using (var db = new PUEntitiesOne())
            {

                var data = db.Contracts
                    .Include(x => x.Cours)
                    .Include(x => x.Educator)
                    .Include(x => x.Contraget)
                    .ToList();

                DateTime dt = Convert.ToDateTime(barEditItemFrom.EditValue);
                DateTime dt2 = Convert.ToDateTime(barEditItemTo.EditValue);

                data = data.Where(a => a.contractDate >= dt).ToList();

                if (dt2 < dt && dt2 != DateTime.MinValue)
                {
                    MessageBox.Show("Моля въведете валиден период");
                    barEditItemTo.EditValue = null;
                    return;
                }

                if (dt2 >= dt && dt2 != DateTime.MinValue)
                {
                    data = data.Where(a => a.contractDate <= dt2).ToList();
                }

                if (barEditItemTreeList.EditValue != null)
                {
                    var cour = barEditItemTreeList.EditValue as Cours;
                    data = data
                        .Where(x => x.courseId == cour.id).ToList();
                    gridControl.DataSource = data;
                }

                gridControl.DataSource = data;

            }
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
