using DevExpress.Data.Browsing;
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

namespace ContractPU.FacultyForms
{
    public partial class XtraFormAddUpdateFaculcy : DevExpress.XtraEditors.XtraForm
    {
        bool isUpdate = false;
        Faculty data;

        public XtraFormAddUpdateFaculcy()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void Pass(Faculty data)
        {
            if (data != null)
            {
                isUpdate = true;
                this.data = data;
                textEditFaculty.Text = data.facultyName;
                simpleButtonAddUpdate.Text = "Запазване";
                this.Text = "Редактиране на факултет";
            }
           
        }

        private void simpleButtonAddUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new PUEntitiesOne())
            {

                if (textEditFaculty.Text == null || textEditFaculty.Text == "")
                {
                    MessageBox.Show("Полето трябва да е запълнено");
                    return;
                }

                if (isUpdate)
                {
                    var row = db.Faculties.FirstOrDefault(x => x.id == data.id);
                    row.facultyName = textEditFaculty.Text;
                    
                }
                else
                {
                    Faculty f = new Faculty();
                    f.facultyName = textEditFaculty.Text;
                    db.Faculties.Add(f);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}