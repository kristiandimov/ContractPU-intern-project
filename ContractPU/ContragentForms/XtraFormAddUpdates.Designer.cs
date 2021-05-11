
namespace ContractPU.ContragentForms
{
    partial class XtraFormAddUpdates
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormAddUpdates));
            this.simpleButtonContragent = new DevExpress.XtraEditors.SimpleButton();
            this.textEditAddress = new DevExpress.XtraEditors.TextEdit();
            this.textEditEIK = new DevExpress.XtraEditors.TextEdit();
            this.textEditMOL = new DevExpress.XtraEditors.TextEdit();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEIK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMOL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonContragent
            // 
            this.simpleButtonContragent.Location = new System.Drawing.Point(70, 206);
            this.simpleButtonContragent.Name = "simpleButtonContragent";
            this.simpleButtonContragent.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonContragent.TabIndex = 0;
            this.simpleButtonContragent.Text = "Добавяне";
            this.simpleButtonContragent.Click += new System.EventHandler(this.simpleButtonContragent_Click);
            // 
            // textEditAddress
            // 
            this.textEditAddress.Location = new System.Drawing.Point(70, 74);
            this.textEditAddress.Name = "textEditAddress";
            this.textEditAddress.Properties.AutoHeight = false;
            this.textEditAddress.Properties.NullValuePrompt = "Адрес";
            this.textEditAddress.Size = new System.Drawing.Size(216, 26);
            this.textEditAddress.TabIndex = 3;
            // 
            // textEditEIK
            // 
            this.textEditEIK.Location = new System.Drawing.Point(70, 116);
            this.textEditEIK.Name = "textEditEIK";
            this.textEditEIK.Properties.AutoHeight = false;
            this.textEditEIK.Properties.NullValuePrompt = "EIK";
            this.textEditEIK.Size = new System.Drawing.Size(216, 26);
            this.textEditEIK.TabIndex = 4;
            // 
            // textEditMOL
            // 
            this.textEditMOL.Location = new System.Drawing.Point(70, 158);
            this.textEditMOL.Name = "textEditMOL";
            this.textEditMOL.Properties.AutoHeight = false;
            this.textEditMOL.Properties.NullValuePrompt = "MOL";
            this.textEditMOL.Size = new System.Drawing.Size(216, 26);
            this.textEditMOL.TabIndex = 5;
            // 
            // textEditName
            // 
            this.textEditName.EditValue = "";
            this.textEditName.Location = new System.Drawing.Point(70, 32);
            this.textEditName.Name = "textEditName";
            this.textEditName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.textEditName.Properties.AutoHeight = false;
            this.textEditName.Properties.NullText = "Име на контрагент";
            this.textEditName.Properties.NullValuePrompt = "Име на контрагент";
            this.textEditName.Size = new System.Drawing.Size(216, 26);
            this.textEditName.TabIndex = 2;
            this.textEditName.EditValueChanged += new System.EventHandler(this.textEditName_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(192, 206);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Отказване";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XtraFormAddUpdates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 266);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEditMOL);
            this.Controls.Add(this.textEditEIK);
            this.Controls.Add(this.textEditAddress);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.simpleButtonContragent);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraFormAddUpdates.IconOptions.SvgImage")));
            this.Name = "XtraFormAddUpdates";
            this.Text = "Добавяне на контрагент";
            ((System.ComponentModel.ISupportInitialize)(this.textEditAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEIK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMOL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonContragent;
        private DevExpress.XtraEditors.TextEdit textEditAddress;
        private DevExpress.XtraEditors.TextEdit textEditEIK;
        private DevExpress.XtraEditors.TextEdit textEditMOL;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}