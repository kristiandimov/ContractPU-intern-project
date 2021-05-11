
namespace ContractPU.Reference.CoursesByArea
{
    partial class XtraFormCourseInspect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormCourseInspect));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.button1 = new System.Windows.Forms.Button();
            this.textEditTheme = new DevExpress.XtraEditors.TextEdit();
            this.textEditArea = new DevExpress.XtraEditors.TextEdit();
            this.textEditAnotation = new DevExpress.XtraEditors.MemoEdit();
            this.textEditDate = new DevExpress.XtraEditors.DateEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Тема = new DevExpress.XtraLayout.LayoutControlItem();
            this.Анотация = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTheme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAnotation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Тема)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Анотация)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.button1);
            this.layoutControl1.Controls.Add(this.textEditTheme);
            this.layoutControl1.Controls.Add(this.textEditArea);
            this.layoutControl1.Controls.Add(this.textEditAnotation);
            this.layoutControl1.Controls.Add(this.textEditDate);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(844, 181, 812, 500);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(481, 475);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(457, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textEditTheme
            // 
            this.textEditTheme.Location = new System.Drawing.Point(101, 68);
            this.textEditTheme.Name = "textEditTheme";
            this.textEditTheme.Properties.AutoHeight = false;
            this.textEditTheme.Properties.ReadOnly = true;
            this.textEditTheme.Size = new System.Drawing.Size(368, 36);
            this.textEditTheme.StyleController = this.layoutControl1;
            this.textEditTheme.TabIndex = 6;
            // 
            // textEditArea
            // 
            this.textEditArea.Location = new System.Drawing.Point(101, 38);
            this.textEditArea.Name = "textEditArea";
            this.textEditArea.Properties.AutoHeight = false;
            this.textEditArea.Properties.ReadOnly = true;
            this.textEditArea.Size = new System.Drawing.Size(368, 26);
            this.textEditArea.StyleController = this.layoutControl1;
            this.textEditArea.TabIndex = 5;
            // 
            // textEditAnotation
            // 
            this.textEditAnotation.Location = new System.Drawing.Point(101, 108);
            this.textEditAnotation.Name = "textEditAnotation";
            this.textEditAnotation.Properties.ReadOnly = true;
            this.textEditAnotation.Size = new System.Drawing.Size(368, 324);
            this.textEditAnotation.StyleController = this.layoutControl1;
            this.textEditAnotation.TabIndex = 7;
            this.textEditAnotation.EditValueChanged += new System.EventHandler(this.textEdit4_EditValueChanged);
            // 
            // textEditDate
            // 
            this.textEditDate.EditValue = null;
            this.textEditDate.Location = new System.Drawing.Point(101, 12);
            this.textEditDate.Name = "textEditDate";
            this.textEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEditDate.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.textEditDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.textEditDate.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.textEditDate.Properties.MaxValue = new System.DateTime(9999, 12, 31, 0, 0, 0, 0);
            this.textEditDate.Properties.ReadOnly = true;
            this.textEditDate.Size = new System.Drawing.Size(368, 22);
            this.textEditDate.StyleController = this.layoutControl1;
            this.textEditDate.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.Тема,
            this.Анотация,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(481, 475);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.textEditDate;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(461, 26);
            this.layoutControlItem1.Text = "Дата";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(86, 16);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.textEditArea;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(164, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(461, 30);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Научна област";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(86, 16);
            // 
            // Тема
            // 
            this.Тема.Control = this.textEditTheme;
            this.Тема.Location = new System.Drawing.Point(0, 56);
            this.Тема.MinSize = new System.Drawing.Size(164, 26);
            this.Тема.Name = "Тема";
            this.Тема.Size = new System.Drawing.Size(461, 40);
            this.Тема.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Тема.TextSize = new System.Drawing.Size(86, 16);
            // 
            // Анотация
            // 
            this.Анотация.Control = this.textEditAnotation;
            this.Анотация.Location = new System.Drawing.Point(0, 96);
            this.Анотация.MinSize = new System.Drawing.Size(50, 25);
            this.Анотация.Name = "Анотация";
            this.Анотация.Size = new System.Drawing.Size(461, 328);
            this.Анотация.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Анотация.TextSize = new System.Drawing.Size(86, 16);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.button1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 424);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(29, 29);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(461, 31);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // XtraFormCourseInspect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 475);
            this.Controls.Add(this.layoutControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraFormCourseInspect.IconOptions.SvgImage")));
            this.Name = "XtraFormCourseInspect";
            this.Text = "Инспектиране";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditTheme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAnotation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Тема)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Анотация)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit textEditTheme;
        private DevExpress.XtraEditors.TextEdit textEditArea;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem Тема;
        private DevExpress.XtraLayout.LayoutControlItem Анотация;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.MemoEdit textEditAnotation;
        private DevExpress.XtraEditors.DateEdit textEditDate;
    }
}