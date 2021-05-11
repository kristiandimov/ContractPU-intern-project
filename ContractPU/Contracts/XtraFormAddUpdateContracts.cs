using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractPU.Contracts
{
    public partial class XtraFormAddUpdateContracts : DevExpress.XtraEditors.XtraForm
    {
        bool isUpdate = false;
        Contract contract;

        public XtraFormAddUpdateContracts()
        {
            InitializeComponent();
            this.CenterToScreen();

            using (var db = new PUEntitiesOne())
            {
                treeListLookUpEditContragent.Properties.DataSource = db.Contragets.ToList();
                treeListLookUpEditEducator.Properties.DataSource = db.Educators.ToList();
                treeListLookUpEditCourse.Properties.DataSource = db.Courses.ToList();
            }
        }

        public void Pass(Contract con, bool isView)
        {
            if (con != null && isView == false)
            {
                isUpdate = true;
                this.contract = con;
                simpleButtonAddUpdate.Text = "Запазване";
                this.Text = "Редактиране";
                FormDataFill(con);
            }
            else if (isView)
            {
                FormDataFill(con);
                simpleButtonAddUpdate.Enabled = false;
                simpleButtonAddUpdate.Hide();
                this.Text = "Инспектиране";
                textEditContractNum.ReadOnly = true;
                textEditContractDate.ReadOnly = true;
                treeListLookUpEditContragent.ReadOnly = true;
                treeListLookUpEditCourse.ReadOnly = true;
                treeListLookUpEditEducator.ReadOnly = true;
                dateEditStart.ReadOnly = true;
                dateEditEnd.ReadOnly = true;
                textEditWithCredit.ReadOnly = true;
                textEditTotalCredit.ReadOnly = true;
                textEditWithoutCredit.ReadOnly = true;
                textEditTotalWithoutCredit.ReadOnly = true;
                textEditTotalOfContracts.ReadOnly = true;
                textEditDDS.ReadOnly = true;
                textEditPU.ReadOnly = true;
                textEditDKPRPS.ReadOnly = true;
                textEditHonorar.ReadOnly = true;
                textEditMaterialExpense.ReadOnly = true;
            }
        }

        private void FormDataFill(Contract con)
        {
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

        //public bool IsNumber(object value)
        //{
        //    return value is double
        //            || value is decimal;
        //}

        //public List<Data> Fill()
        //{
        //    //db.SaveChanges е закоментирано !!!!!!!!
        //    var listData = new List<Data>();

            

        //    foreach (var item in )
        //    {

        //        if (IsNumber(item))
        //        {
        //            //listData.Add(int.Parse(item.ToString()));
        //        }

        //    }

        //    return listData;
        //}

        private void simpleButtonAddUpdate_Click(object sender, EventArgs e)
        {
            //Трябва да се разкоментира и да се направи условие

            int contractNum = int.Parse(textEditContractNum.Text);
            DateTime contractDate = textEditContractDate.DateTime;            
            DateTime startDate = dateEditStart.DateTime;
            DateTime endDate = dateEditEnd.DateTime;
            decimal priceWithCredit = decimal.Parse(textEditWithCredit.EditValue.ToString());
            double totalWihtCredit = double.Parse(textEditTotalCredit.Text);
            double priceWithoutCredit = double.Parse(textEditWithCredit.EditValue.ToString());
            double totalWihtoutCredit = double.Parse(textEditTotalWithoutCredit.EditValue.ToString());
            double totalSum = double.Parse(textEditTotalOfContracts.EditValue.ToString());
            double DDS = double.Parse(textEditDDS.EditValue.ToString());
            double DKPRPS = double.Parse(textEditDKPRPS.EditValue.ToString());
            double honorar = double.Parse(textEditHonorar.EditValue.ToString());
            double materialExprenses = double.Parse(textEditMaterialExpense.EditValue.ToString());



            if (contractNum == 0 || contractDate == DateTime.MinValue || treeListLookUpEditContragent.EditValue != ""
                || treeListLookUpEditCourse.EditValue != "" || treeListLookUpEditEducator.EditValue != "" || startDate == DateTime.MinValue
                || endDate == DateTime.MinValue)
            {
                MessageBox.Show("Трябва да въведете валидни данни");

                return;
            }
            using (var db = new PUEntitiesOne())
            {
                if (isUpdate)
                {
                    var row = db.Contracts.FirstOrDefault(x => x.id == contract.id);

                    row.contractNumber = int.Parse(textEditContractNum.EditValue.ToString());
                    row.contractDate = textEditContractDate.DateTime;
                    row.contragentId = int.Parse(treeListLookUpEditContragent.EditValue.ToString());
                    row.courseId = int.Parse(treeListLookUpEditCourse.EditValue.ToString());
                    row.educatorId = int.Parse(treeListLookUpEditEducator.EditValue.ToString());
                    row.startDate = dateEditStart.DateTime;
                    row.endDate = dateEditEnd.DateTime;
                    row.priceWithCredit = decimal.Parse(textEditWithCredit.EditValue.ToString());
                    row.totalWithCredit = int.Parse(textEditTotalCredit.EditValue.ToString());
                    row.priceWithoutCredit = decimal.Parse(textEditWithoutCredit.EditValue.ToString());
                    row.totalWithoutCredit = int.Parse(textEditTotalWithoutCredit.EditValue.ToString());
                    row.sumOfContract = int.Parse(textEditTotalOfContracts.EditValue.ToString());
                    row.DDS = int.Parse(textEditDDS.EditValue.ToString());
                    row.deductionsForPU = int.Parse(textEditPU.EditValue.ToString());
                    row.deductionsForDKPRPS = int.Parse(textEditDKPRPS.EditValue.ToString());
                    row.remunerationFee = int.Parse(textEditHonorar.EditValue.ToString());
                    row.materialCost = int.Parse(textEditMaterialExpense.EditValue.ToString());


                }
                else
                {
                    Contract con = new Contract();

                    con.contractNumber = int.Parse(textEditContractNum.EditValue.ToString());
                    con.contractDate = textEditContractDate.DateTime;
                    con.contragentId = int.Parse(treeListLookUpEditContragent.EditValue.ToString());
                    con.courseId = int.Parse(treeListLookUpEditCourse.EditValue.ToString());
                    con.educatorId = int.Parse(treeListLookUpEditEducator.EditValue.ToString());
                    con.startDate = dateEditStart.DateTime;
                    con.endDate = dateEditEnd.DateTime;
                    con.priceWithCredit = decimal.Parse(textEditWithCredit.EditValue.ToString());
                    con.totalWithCredit = int.Parse(textEditTotalCredit.EditValue.ToString());
                    con.priceWithoutCredit = decimal.Parse(textEditWithoutCredit.EditValue.ToString());
                    con.totalWithoutCredit = int.Parse(textEditTotalWithoutCredit.EditValue.ToString());
                    con.sumOfContract = int.Parse(textEditTotalOfContracts.EditValue.ToString());
                    con.DDS = int.Parse(textEditDDS.EditValue.ToString());
                    con.deductionsForPU = int.Parse(textEditPU.EditValue.ToString());
                    con.deductionsForDKPRPS = int.Parse(textEditDKPRPS.EditValue.ToString());
                    con.remunerationFee = int.Parse(textEditHonorar.EditValue.ToString());
                    con.materialCost = int.Parse(textEditMaterialExpense.EditValue.ToString());

                    db.Contracts.Add(con);

                }

                try
                {
                    db.SaveChanges();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

                this.Hide();

            }

        }

        private void XtraFormAddUpdateContracts_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}