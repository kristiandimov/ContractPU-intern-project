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

namespace ContractPU.ContragentForms
{
    public partial class XtraFormAddUpdates : DevExpress.XtraEditors.XtraForm
    {
        bool isUpdate = false;
        Contraget data;

        public XtraFormAddUpdates()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void Pass(Contraget data)
        {
            if (data != null)
            {
                isUpdate = true;
                this.data = data;
                this.Text = "Редактиране на контрагент";
                simpleButtonContragent.Text = "Запазване";

                textEditName.Text = data.name;
                textEditAddress.Text = data.address;
                textEditEIK.Text = data.EIK;
                textEditMOL.Text = data.MOL;
            }
        }

        private void simpleButtonContragent_Click(object sender, EventArgs e)
        {

            using (var db = new PUEntitiesOne())
            {

                if (textEditName.Text == null || textEditName.Text == "" || textEditEIK.Text == "" || textEditMOL.Text == "")
                {
                    MessageBox.Show("Полето трябва да е запълнено");
                    return;
                }

                if (isUpdate)
                {
                    var con = db.Contragets.FirstOrDefault(x => x.id == data.id);
                    con.name = textEditName.Text;
                    con.address = textEditAddress.Text;
                    con.EIK = textEditEIK.Text;
                    con.MOL = textEditMOL.Text;

                }
                else
                {
                    Contraget con = new Contraget();
                    con.name = textEditName.Text;
                    con.address = textEditAddress.Text;
                    con.EIK = textEditEIK.Text;
                    con.MOL = textEditMOL.Text;

                    db.Contragets.Add(con);

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

        private void textEditName_EditValueChanged(object sender, EventArgs e)
        {


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}