using ContractPU.AreaForms;
using ContractPU.Contracts;
using ContractPU.ContragentForms;
using ContractPU.Courses;
using ContractPU.EducatiorForms;
using ContractPU.FacultyForms;
using ContractPU.Properties;
using ContractPU.Reference.ClalificationCourses;
using ContractPU.Reference.CoursesByArea;
using ContractPU.Reference.Educations;
using ContractPU.Reference.ListOfEducators;
using ContractPU.Reference.SumOfContracts;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers;
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

namespace ContractPU
{
    public partial class Home : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        

        public Home()
        {
            InitializeComponent();
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.WindowState = FormWindowState.Maximized;
            UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
        }

        public void FormCleaner(XtraUserControl uc)
        {
            panelControl1.Controls.Clear();
            uc.Dock = DockStyle.Fill;            
            panelControl1.Controls.Add(uc);
            
        }

        private void barButtonArea_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            var uc = new XtraUserAreass();           
            FormCleaner(uc);
            this.Text = "Научни дейности";
            
            
        }

        private void barButtonFaculty_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraUserControlFaculcy();
            FormCleaner(uc);
            this.Text = "Факултети/Звено";
            ribbonPageAdd.Visible = true;
        }

        private void barButtonCourses_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraUserControlCourses();
            FormCleaner(uc);
            this.Text = "Курсове";
            ribbonPageAdd.Visible = true;
        }

        private void panelControl1_Resize(object sender, EventArgs e)
        {
          

           
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonContragents_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraUserControlContragent();
            FormCleaner(uc);
            this.Text = "Контрагенти";
            ribbonPageAdd.Visible = true;
        }

        private void barButtonEducators_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraUserControlEducators();
            FormCleaner(uc);
            this.Text = "Обучители";
            ribbonPageAdd.Visible = true;
        }

        private void barButtonContracts_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraUserControlContracts();
            FormCleaner(uc);
            this.Text = "Учители";
            ribbonPageAdd.Visible = true;
        }

        private void barButtonTheme_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void skinDropDownButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
            Settings.Default.Save();
        }

        private void barButtonItemDoneCourses_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraUserControlEducations();
            FormCleaner(uc);
            this.Text = "Проведени обучения";
            
        }

        private void barButtonItemSumOfContracts_ItemClick(object sender, ItemClickEventArgs e)
        {

            var uc = new XtraUserControlSumOfContracts();
            FormCleaner(uc);
            this.Text = "Обща сума по договори";           
        }

        private void barButtonItemKlalification_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraUserControlClalificationCourses();
            FormCleaner(uc);
            this.Text = "Списък на клалификационните курсове";
        }

        private void barButtonItemCoursesByArea_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraUserControlCoursesByArea();
            FormCleaner(uc);
            this.Text = "Курсове по области";
        }

        private void barButtonItemListEducators_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraUserControlListOfEducators();
            FormCleaner(uc);
            this.Text = "Списък на обучителите";
        }

        private void barButtonAddContragent_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAddUpdates();

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void barButtonAddCourse_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormCourses();

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void barButtonAddEducator_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAddUpdateEducator();

            if (uc.ShowDialog() == DialogResult.OK)
            {
                
            }

        }

        private void barButtonAddArea_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAreaAddUpdate();

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void barButtonItemFaculty_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAddUpdateFaculcy();

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }

        }

        private void barButtonItemFont_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }
    }

}