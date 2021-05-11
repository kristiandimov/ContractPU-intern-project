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

namespace ContractPU.Reference.CoursesByArea
{
    public partial class XtraFormCourseInspect : DevExpress.XtraEditors.XtraForm
    {
        
        public XtraFormCourseInspect()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void Pass(Cours data)
        {
            textEditDate.DateTime = data.courseDate;
            textEditTheme.Text = data.theme;
            textEditArea.Text = data.Area.areaName;
            textEditAnotation.Text = data.anotation;

        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}