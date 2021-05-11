
namespace ContractPU.AreaForms
{
    partial class XtraFormAreaAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormAreaAddUpdate));
            this.simpleButtonAddUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.textEditArea = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditArea.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonAddUpdate
            // 
            this.simpleButtonAddUpdate.Location = new System.Drawing.Point(42, 80);
            this.simpleButtonAddUpdate.Name = "simpleButtonAddUpdate";
            this.simpleButtonAddUpdate.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonAddUpdate.TabIndex = 5;
            this.simpleButtonAddUpdate.Text = "Добавяне";
            this.simpleButtonAddUpdate.Click += new System.EventHandler(this.simpleButtonAddUpdate_Click);
            // 
            // textEditArea
            // 
            this.textEditArea.Location = new System.Drawing.Point(42, 33);
            this.textEditArea.Name = "textEditArea";
            this.textEditArea.Properties.NullValuePrompt = "Научна област";
            this.textEditArea.Size = new System.Drawing.Size(204, 22);
            this.textEditArea.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(152, 80);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Отказване";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XtraFormAreaAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 144);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButtonAddUpdate);
            this.Controls.Add(this.textEditArea);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraFormAreaAddUpdate.IconOptions.SvgImage")));
            this.Name = "XtraFormAreaAddUpdate";
            this.Text = "Добавяне";
            this.Load += new System.EventHandler(this.XtraFormAreaAddUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditArea.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonAddUpdate;
        private DevExpress.XtraEditors.TextEdit textEditArea;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}