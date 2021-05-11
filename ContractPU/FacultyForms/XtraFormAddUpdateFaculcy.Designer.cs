
namespace ContractPU.FacultyForms
{
    partial class XtraFormAddUpdateFaculcy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormAddUpdateFaculcy));
            this.textEditFaculty = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonAddUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFaculty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditFaculty
            // 
            this.textEditFaculty.Location = new System.Drawing.Point(49, 46);
            this.textEditFaculty.Name = "textEditFaculty";
            this.textEditFaculty.Properties.AutoHeight = false;
            this.textEditFaculty.Properties.NullValuePrompt = "Факултет";
            this.textEditFaculty.Size = new System.Drawing.Size(250, 26);
            this.textEditFaculty.TabIndex = 1;
            // 
            // simpleButtonAddUpdate
            // 
            this.simpleButtonAddUpdate.Location = new System.Drawing.Point(76, 96);
            this.simpleButtonAddUpdate.Name = "simpleButtonAddUpdate";
            this.simpleButtonAddUpdate.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonAddUpdate.TabIndex = 2;
            this.simpleButtonAddUpdate.Text = "Добавяне";
            this.simpleButtonAddUpdate.Click += new System.EventHandler(this.simpleButtonAddUpdate_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(176, 96);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Отказване";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XtraFormAddUpdateFaculcy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 172);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.simpleButtonAddUpdate);
            this.Controls.Add(this.textEditFaculty);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraFormAddUpdateFaculcy.IconOptions.SvgImage")));
            this.Name = "XtraFormAddUpdateFaculcy";
            this.Text = "Добавяне на факултет";
            ((System.ComponentModel.ISupportInitialize)(this.textEditFaculty.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit textEditFaculty;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddUpdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}