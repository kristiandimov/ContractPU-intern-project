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

namespace ContractPU.AreaForms
{
    public partial class XtraFormAreaAddUpdate : XtraForm
    {
        
        bool isUpdate = false;
        Area data;
        
        public XtraFormAreaAddUpdate()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }

        public void Pass(Area data)
        {
            if (data != null)
            {
                isUpdate = true;
                this.Text = "Редактиране";
                simpleButtonAddUpdate.Text = "Запазване";
                textEditArea.Text = data.areaName;
                this.data = data;

            }          
        }
        

        private void simpleButtonAddUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new PUEntitiesOne())
            {
                if (textEditArea.Text == null || textEditArea.Text == "")
                {
                    MessageBox.Show("Полето трябва да е запълнено");
                    return;
                }

                if (isUpdate)
                {
                   
                    var row = db.Areas.FirstOrDefault(x => x.id == data.id);
                    row.areaName = textEditArea.Text;
                   
                }
                else
                {
                    Area a = new Area();
                    a.areaName = textEditArea.Text;
                    db.Areas.Add(a);
                }

                try
                {
                    db.SaveChanges();                   
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }

            }

            this.Hide();
        }

        private void XtraFormAreaAddUpdate_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}