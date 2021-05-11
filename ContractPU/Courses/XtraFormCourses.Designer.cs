
namespace ContractPU.Courses
{
    partial class XtraFormCourses
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormCourses));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEditProtocol = new DevExpress.XtraEditors.TextEdit();
            this.textEditTheme = new DevExpress.XtraEditors.TextEdit();
            this.textEditTotalHour = new DevExpress.XtraEditors.TextEdit();
            this.textEditTotalCredit = new DevExpress.XtraEditors.TextEdit();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.treeListLookUpEdit1 = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colareaName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListLookUpEdit2 = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.educatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.coleducatorName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textEditAnotation = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditProtocol.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTheme.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotalHour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotalCredit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAnotation.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(45, 397);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 30);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Добавяне";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEditProtocol
            // 
            this.textEditProtocol.Location = new System.Drawing.Point(45, 38);
            this.textEditProtocol.Name = "textEditProtocol";
            this.textEditProtocol.Properties.AutoHeight = false;
            this.textEditProtocol.Properties.NullValuePrompt = "Протокол";
            this.textEditProtocol.Size = new System.Drawing.Size(255, 26);
            this.textEditProtocol.TabIndex = 1;
            // 
            // textEditTheme
            // 
            this.textEditTheme.Location = new System.Drawing.Point(45, 100);
            this.textEditTheme.Name = "textEditTheme";
            this.textEditTheme.Properties.AutoHeight = false;
            this.textEditTheme.Properties.NullValuePrompt = "Тема";
            this.textEditTheme.Size = new System.Drawing.Size(255, 26);
            this.textEditTheme.TabIndex = 3;
            // 
            // textEditTotalHour
            // 
            this.textEditTotalHour.EditValue = ((long)(0));
            this.textEditTotalHour.Location = new System.Drawing.Point(45, 252);
            this.textEditTotalHour.Name = "textEditTotalHour";
            this.textEditTotalHour.Properties.AutoHeight = false;
            this.textEditTotalHour.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEditTotalHour.Properties.Mask.EditMask = "f0";
            this.textEditTotalHour.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditTotalHour.Properties.NullValuePrompt = "Брой часове";
            this.textEditTotalHour.Size = new System.Drawing.Size(255, 26);
            this.textEditTotalHour.TabIndex = 5;
            this.textEditTotalHour.EditValueChanged += new System.EventHandler(this.textEditTotalHour_EditValueChanged);
            // 
            // textEditTotalCredit
            // 
            this.textEditTotalCredit.EditValue = ((long)(0));
            this.textEditTotalCredit.Location = new System.Drawing.Point(45, 285);
            this.textEditTotalCredit.Name = "textEditTotalCredit";
            this.textEditTotalCredit.Properties.AutoHeight = false;
            this.textEditTotalCredit.Properties.Mask.EditMask = "d";
            this.textEditTotalCredit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEditTotalCredit.Properties.NullValuePrompt = "Брой кредити";
            this.textEditTotalCredit.Size = new System.Drawing.Size(255, 26);
            this.textEditTotalCredit.TabIndex = 6;
            // 
            // treeListLookUpEdit1
            // 
            this.treeListLookUpEdit1.Location = new System.Drawing.Point(45, 318);
            this.treeListLookUpEdit1.Name = "treeListLookUpEdit1";
            this.treeListLookUpEdit1.Properties.AutoHeight = false;
            this.treeListLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.treeListLookUpEdit1.Properties.DataSource = this.areaBindingSource;
            this.treeListLookUpEdit1.Properties.DisplayMember = "areaName";
            this.treeListLookUpEdit1.Properties.NullText = "Научна област";
            this.treeListLookUpEdit1.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.treeListLookUpEdit1.Properties.ValueMember = "id";
            this.treeListLookUpEdit1.Size = new System.Drawing.Size(255, 26);
            this.treeListLookUpEdit1.TabIndex = 11;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataSource = typeof(ContractPU.Area);
            // 
            // treeListLookUpEdit1TreeList
            // 
            this.treeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colareaName});
            this.treeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.treeListLookUpEdit1TreeList.Name = "treeListLookUpEdit1TreeList";
            this.treeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.treeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.treeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colareaName
            // 
            this.colareaName.FieldName = "areaName";
            this.colareaName.Name = "colareaName";
            this.colareaName.Visible = true;
            this.colareaName.VisibleIndex = 0;
            // 
            // treeListLookUpEdit2
            // 
            this.treeListLookUpEdit2.Location = new System.Drawing.Point(45, 351);
            this.treeListLookUpEdit2.Name = "treeListLookUpEdit2";
            this.treeListLookUpEdit2.Properties.AutoHeight = false;
            this.treeListLookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.treeListLookUpEdit2.Properties.DataSource = this.educatorBindingSource;
            this.treeListLookUpEdit2.Properties.DisplayMember = "educatorName";
            this.treeListLookUpEdit2.Properties.NullText = "Обучител";
            this.treeListLookUpEdit2.Properties.TreeList = this.treeList1;
            this.treeListLookUpEdit2.Properties.ValueMember = "id";
            this.treeListLookUpEdit2.Size = new System.Drawing.Size(255, 26);
            this.treeListLookUpEdit2.TabIndex = 12;
            // 
            // educatorBindingSource
            // 
            this.educatorBindingSource.DataSource = typeof(ContractPU.Educator);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.coleducatorName});
            this.treeList1.Location = new System.Drawing.Point(-25, 60);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 0;
            // 
            // coleducatorName
            // 
            this.coleducatorName.FieldName = "educatorName";
            this.coleducatorName.Name = "coleducatorName";
            this.coleducatorName.Visible = true;
            this.coleducatorName.VisibleIndex = 0;
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(45, 71);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit1.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit1.Properties.NullText = "Дата";
            this.dateEdit1.Size = new System.Drawing.Size(255, 22);
            this.dateEdit1.TabIndex = 13;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(206, 397);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 29);
            this.simpleButton2.TabIndex = 14;
            this.simpleButton2.Text = "Отказване";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textEditAnotation
            // 
            this.textEditAnotation.Location = new System.Drawing.Point(45, 133);
            this.textEditAnotation.Name = "textEditAnotation";
            this.textEditAnotation.Properties.NullValuePrompt = "Анотация и преподавателски екип";
            this.textEditAnotation.Size = new System.Drawing.Size(255, 113);
            this.textEditAnotation.TabIndex = 4;
            // 
            // XtraFormCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 449);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.treeListLookUpEdit2);
            this.Controls.Add(this.treeListLookUpEdit1);
            this.Controls.Add(this.textEditTotalCredit);
            this.Controls.Add(this.textEditTotalHour);
            this.Controls.Add(this.textEditTheme);
            this.Controls.Add(this.textEditProtocol);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEditAnotation);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraFormCourses.IconOptions.SvgImage")));
            this.Name = "XtraFormCourses";
            this.Text = "Добавяне на курс";
            ((System.ComponentModel.ISupportInitialize)(this.textEditProtocol.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTheme.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotalHour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTotalCredit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditAnotation.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEditProtocol;
        private DevExpress.XtraEditors.TextEdit textEditTheme;
        private DevExpress.XtraEditors.TextEdit textEditTotalHour;
        private DevExpress.XtraEditors.TextEdit textEditTotalCredit;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEdit1;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEdit2;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colareaName;
        private System.Windows.Forms.BindingSource educatorBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coleducatorName;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.MemoEdit textEditAnotation;
    }
}