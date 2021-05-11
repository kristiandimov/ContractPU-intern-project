using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContractPU.ContragentForms
{
    public partial class XtraUserControlContragent : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControlContragent()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            using (var db = new PUEntitiesOne())
            {
                var data = db.Contragets.ToList();
                gridControl.DataSource = data;
                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
        }

        private static void DataCheck(Contraget con)
        {
            if (con == null)
            {
                MessageBox.Show("Първо трябва да селектирате запис от таблицата");
                return;
            }
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadData();
        }

        private void DeleteOperation()
        {
            var con = gridView.GetFocusedRow() as Contraget;

            DataCheck(con);

            DialogResult dialogResult = MessageBox.Show("Желаете ли да изтриете този запис", "Подтвърдете", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                using (var db = new PUEntitiesOne())
                {
                    db.Entry(con).State = System.Data.Entity.EntityState.Deleted;
                    db.Contragets.Remove(con);


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

            LoadData();
        }

        
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            var uc = new XtraFormAddUpdates();

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
            var uc = new XtraFormAddUpdates();

            var con = gridView.GetFocusedRow() as Contraget;

            DataCheck(con);

            uc.Pass(con);

            if (uc.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DeleteOperation();
        }

        private void gridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteOperation();
            }
        }

        private void XtraUserControlContragent_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            Edit();

            LoadData();
        }
    }
}
