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

namespace ContractPU.Reference.SumOfContracts
{
    public partial class XtraUserControlSumOfContracts : DevExpress.XtraEditors.XtraUserControl
    {
               
        public XtraUserControlSumOfContracts()
        {
            InitializeComponent();
            LoadData();

            using (var db = new PUEntitiesOne())
            {
                var data = db.Contracts
                    .Include(x => x.Cours)
                    .Include(x => x.Contraget)
                    .Include(x => x.Educator)
                    .ToList();

                Sum(data);
            }
          
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraReportSumOfContracts();
            ReportPrintTool reportPrintTool = new ReportPrintTool(uc);
            reportPrintTool.ShowPreview();
        }
        
        public void LoadData()
        {
            using (var db = new PUEntitiesOne())
            {
                var data = db.Contracts
                    .Include(x=> x.Cours)
                    .Include(x => x.Contraget)
                    .Include(x=>x.Educator)
                    .ToList();

                repositoryItemTreeListLookUpEdit1.DataSource = data;

                gridControl.DataSource = data;

                bsiRecordsCount.Caption = "RECORDS : " + data.Count;

            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barEditItemFrom_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEditDKPRPS_EditValueChanged(object sender, EventArgs e)
        {

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
                    
                    var get = barEditItemTreeList.EditValue as Contract;                            
                    data = data
                        .Where(x => x.id == get.id).ToList();
                    gridControl.DataSource = data;

                }

                Sum(data);

                gridControl.DataSource = data;
                
            }
        }

        private void Sum(List<Contract> data)
        {
            decimal sumContracts = 0;
            decimal sumDDS = 0;
            decimal sumPU = 0;
            decimal sumDKPRPS = 0;
            decimal sumHonorars = 0;
            decimal sumExpenses = 0;

            foreach (var item in data)
            {
                sumContracts += item.sumOfContract;
                sumDDS += item.DDS;
                sumDKPRPS += item.deductionsForDKPRPS;
                sumPU += item.deductionsForPU;
                sumHonorars += item.remunerationFee;
                sumExpenses += item.materialCost;
            }

            textEditContract.Text = sumContracts.ToString();
            textEditDDS.Text = sumDDS.ToString();
            textEditDKPRPS.Text = sumDKPRPS.ToString();
            textEditPU.Text = sumPU.ToString();
            textEditHonorar.Text = sumHonorars.ToString();
            textEditExpenses.Text = sumExpenses.ToString();

            
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
            barEditItemFrom.EditValue = null;
            barEditItemTo.EditValue = null;
            barEditItemTreeList.EditValue = null;
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }

        private void barEditItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
