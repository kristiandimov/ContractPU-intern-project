using ContractPU.ContragentForms;
using ContractPU.Courses;
using ContractPU.EducatiorForms;
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

namespace ContractPU.Contracts
{
    public partial class XtraUserControlContracts : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControlContracts()
        {
            InitializeComponent();
            LoadData();
          
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraReportInvoice();
            ReportPrintTool reportPrintTool = new ReportPrintTool(uc);
            reportPrintTool.ShowPreview();
            //gridControl.ShowRibbonPrintPreview();
        }

        private static void DataCheck(Contract con)
        {
            if (con == null)
            {
                MessageBox.Show("Първо трябва да селектирате запис от таблицата");
                return;
            }
        }

        public void LoadData()
        {
            using (var db = new PUEntitiesOne())
            {
                var data = db.Contracts.Include(e => e.Educator).Include(x => x.Cours).Include(x => x.Contraget).ToList();
                gridControl.DataSource = data;

                var contragents = db.Contragets.ToList();
                var educators = db.Educators.Include(e => e.Area).Include(e => e.Faculty).ToList();
                var courses = db.Courses.Include(e => e.Educator).Include(x => x.Area).ToList();

                treeListLookUpEditContragent.Properties.DataSource = contragents;
                treeListLookUpEditEducator.Properties.DataSource = educators;
                treeListLookUpEditCourse.Properties.DataSource = courses;

                repositoryItemTreeListLookUpEdit1.DataSource = contragents;
                repositoryItemTreeListLookUpEdit2.DataSource = educators;
                repositoryItemTreeListLookUpEdit3.DataSource = courses;

                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {

            var uc = new XtraFormAddUpdateContracts();

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
            var con = gridView.GetFocusedRow() as Contract;

            var uc = new XtraFormAddUpdateContracts();

            uc.Pass(con, false);

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
            var contracts = gridView.GetFocusedRow() as Contract;

            DataCheck(contracts);

            DialogResult dialogResult = MessageBox.Show("Желаете ли да изтриете този запис", "Подтвърдете", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                using (var db = new PUEntitiesOne())
                {

                    db.Contracts.Attach(contracts);
                    db.Contracts.Remove(contracts);

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
            barEditItemTreeListEducator.EditValue = null;
            barEditItemTreeListCourse.EditValue = null;
            barEditItemTreeListContragent.EditValue = null;
        }

        private void gridControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteOperation();
            }

            LoadData();
        }

        private void XtraUserControlContracts_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var con = gridView.GetFocusedRow() as Contract;

            var uc = new XtraFormAddUpdateContracts();

            uc.Pass(con,true);

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void barButtonItemContragent_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemEducator_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAddUpdateEducator();

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void barButtonItemCourse_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormCourses();

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            Edit();
            LoadData();
        }

        private void gridControl_Click(object sender, EventArgs e)
        {
            var con = gridView.GetFocusedRow() as Contract;

            textEditContractNum.EditValue = con.contractNumber;
            textEditContractDate.DateTime = con.contractDate;
            treeListLookUpEditContragent.EditValue = con.contragentId;
            treeListLookUpEditCourse.EditValue = con.courseId;
            treeListLookUpEditEducator.EditValue = con.educatorId;
            dateEditStart.DateTime = con.startDate;
            dateEditEnd.DateTime = con.endDate;
            textEditWithCredit.EditValue = con.priceWithCredit;
            textEditTotalCredit.EditValue = con.totalWithCredit;
            textEditWithoutCredit.EditValue = con.priceWithoutCredit;
            textEditTotalWithoutCredit.EditValue = con.totalWithoutCredit;
            textEditTotalOfContracts.EditValue = con.sumOfContract;
            textEditDDS.EditValue = con.DDS;
            textEditPU.EditValue = con.deductionsForPU;
            textEditDKPRPS.EditValue = con.deductionsForDKPRPS;
            textEditHonorar.EditValue = con.remunerationFee;
            textEditMaterialExpense.EditValue = con.materialCost;
        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItemContragent_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAddUpdates();

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
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

                if (barEditItemTreeListContragent.EditValue != null)
                {
                    var contragent = barEditItemTreeListContragent.EditValue as Contraget;

                    data = data.Where(x=> x.contragentId == contragent.id).ToList();

                }

                if (barEditItemTreeListEducator.EditValue != null)
                {
                    var educator = barEditItemTreeListEducator.EditValue as Educator;

                    data = data.Where(x=>x.educatorId == educator.id).ToList();

                }

                if (barEditItemTreeListCourse.EditValue != null)
                {
                    var course = barEditItemTreeListCourse.EditValue as Cours;

                    data = data.Where(x => x.courseId == course.id).ToList();
                }

                gridControl.DataSource = data;
            }

        }

        private void barButtonItemClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            barEditItemFrom.EditValue = null;
            barEditItemTo.EditValue = null;
            barEditItemTreeListEducator.EditValue = null;
            barEditItemTreeListCourse.EditValue = null;
            barEditItemTreeListContragent.EditValue = null;
        }
    }
}
