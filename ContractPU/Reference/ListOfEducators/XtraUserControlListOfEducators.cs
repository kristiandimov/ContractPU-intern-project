using DevExpress.XtraBars;
using DevExpress.XtraEditors;
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

namespace ContractPU.Reference.ListOfEducators
{
    public partial class XtraUserControlListOfEducators : DevExpress.XtraEditors.XtraUserControl
    {
        public XtraUserControlListOfEducators()
        {
            InitializeComponent();
            LoadData();
                       
            
        }

        public void LoadData()
        {
            using (var db = new PUEntitiesOne())
            {
                var data = db.Educators.Include(e => e.Area).Include(e => e.Faculty).ToList();
                gridControl.DataSource = data;
                bsiRecordsCount.Caption = "RECORDS : " + data.Count;
            }
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }

        private void gridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
