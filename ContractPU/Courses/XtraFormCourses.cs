using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractPU.Courses
{
    public partial class XtraFormCourses : DevExpress.XtraEditors.XtraForm
    {
        bool isUpdate = false;
        Cours cours;

        public XtraFormCourses()
        {
            InitializeComponent();
            this.CenterToScreen();
            using (var db = new PUEntitiesOne())
            {

                treeListLookUpEdit1.Properties.DataSource = db.Areas.ToList();
                treeListLookUpEdit2.Properties.DataSource = db.Educators.ToList();

            }
        }

        public void Pass(Cours cours)
        {
            if (cours != null)
            {
                this.cours = cours;
                isUpdate = true;
                simpleButton1.Text = "Запазване";
                this.Text = "Редактиране на запис";
                textEditProtocol.Text = cours.protocol;
                dateEdit1.EditValue = cours.courseDate;
                textEditTheme.Text = cours.theme;
                textEditAnotation.Text = cours.anotation;
                textEditTotalHour.Text = cours.totalHour.ToString();
                textEditTotalCredit.Text = cours.totalCredit.ToString();
                treeListLookUpEdit1.EditValue = cours.areaId;
                treeListLookUpEdit2.EditValue = cours.educatorId;

            }
            
        }

        public bool DataCheck()
        {

            if (dateEdit1.DateTime == DateTime.MinValue || textEditProtocol.Text == "" 
                || textEditTheme.Text == "" || textEditAnotation.Text == "" 
                || treeListLookUpEdit1.EditValue != null || treeListLookUpEdit2.EditValue != null)
            {
                MessageBox.Show("Тряба да въведете данни");
                return true;
            }

            return false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            
            if (DataCheck())
            {
                return;
            }
            using (var db = new PUEntitiesOne())
            {
                
                if (isUpdate)
                {
                    var course = db.Courses.FirstOrDefault(x => x.id == cours.id);
                    course.protocol = textEditProtocol.Text;
                    course.courseDate = dateEdit1.DateTime;
                    course.theme = textEditTheme.Text;
                    course.anotation = textEditAnotation.Text;
                    course.totalHour = int.Parse(textEditTotalHour.Text);
                    course.totalCredit = int.Parse(textEditTotalCredit.Text);
                    course.areaId = int.Parse(treeListLookUpEdit1.EditValue.ToString());
                    course.educatorId = int.Parse(treeListLookUpEdit2.EditValue.ToString());

                }
                else
                {
                    Cours course = new Cours();

                    course.protocol = textEditProtocol.Text;
                    course.courseDate = dateEdit1.DateTime;
                    course.theme = textEditTheme.Text;
                    course.anotation = textEditAnotation.Text;
                    course.totalHour = int.Parse(textEditTotalHour.Text);
                    course.totalCredit = int.Parse(textEditTotalCredit.Text);
                    course.areaId = int.Parse(treeListLookUpEdit1.EditValue.ToString());
                    course.educatorId = int.Parse(treeListLookUpEdit2.EditValue.ToString());

                    db.Courses.Add(course);
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

        private void textEditTotalHour_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}