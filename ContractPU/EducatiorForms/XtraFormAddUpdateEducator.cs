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

namespace ContractPU.EducatiorForms
{
    public partial class XtraFormAddUpdateEducator : DevExpress.XtraEditors.XtraForm
    {

        bool isUpdate = false;
        Educator data;

        public XtraFormAddUpdateEducator()
        {
            InitializeComponent();
            this.CenterToScreen();
            using (var db = new PUEntitiesOne())
            {
                treeListLookUpEditArea.Properties.DataSource = db.Areas.ToList();
                treeListLookUpEdit1.Properties.DataSource = db.Faculties.ToList();
                
            }
            
        }

        public void Pass(Educator edu)
        {
            if (edu != null)
            {
                isUpdate = true;
                this.data = edu;
                this.Text = "Редактиране на обучител";
                simpleButtonAddUpdate.Text = "Запазване";
                textEditEducatorName.Text = edu.educatorName;
                treeListLookUpEdit1.EditValue = edu.faculcyId;
                treeListLookUpEditArea.EditValue = edu.areaId;
                   
                //2 more to add
            }

        }

        private void simpleButtonAddUpdate_Click(object sender, EventArgs e)
        {
            if (textEditEducatorName.Text == null || textEditEducatorName.Text == "" 
                || treeListLookUpEdit1.EditValue == null || treeListLookUpEditArea.EditValue == null)
            {
                MessageBox.Show("Въведете валидни данни");
                return;
            }


            using (var db = new PUEntitiesOne())
            {
                

                if (isUpdate)
                {
                    var edu = db.Educators.FirstOrDefault(x => x.id == data.id);
                    edu.educatorName = textEditEducatorName.Text;
                    edu.areaId = int.Parse(treeListLookUpEditArea.EditValue.ToString());
                    edu.faculcyId = int.Parse(treeListLookUpEdit1.EditValue.ToString());

                }
                else
                {
                    
                    Educator edu = new Educator();

                    edu.educatorName = textEditEducatorName.Text;
                    edu.areaId = int.Parse(treeListLookUpEditArea.EditValue.ToString());
                    edu.faculcyId = int.Parse(treeListLookUpEdit1.EditValue.ToString());
                    db.Educators.Add(edu);


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

        private void XtraFormAddUpdateEducator_Load(object sender, EventArgs e)
        {

        }

        private void treeListLookUpEditArea_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}