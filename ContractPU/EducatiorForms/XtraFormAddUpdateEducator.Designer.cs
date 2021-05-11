
namespace ContractPU.EducatiorForms
{
    partial class XtraFormAddUpdateEducator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormAddUpdateEducator));
            this.simpleButtonAddUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.textEditEducatorName = new DevExpress.XtraEditors.TextEdit();
            this.treeListLookUpEditArea = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colareaName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListLookUpEdit1 = new DevExpress.XtraEditors.TreeListLookUpEdit();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.Факултет = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEducatorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditArea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonAddUpdate
            // 
            this.simpleButtonAddUpdate.Location = new System.Drawing.Point(79, 166);
            this.simpleButtonAddUpdate.Name = "simpleButtonAddUpdate";
            this.simpleButtonAddUpdate.Size = new System.Drawing.Size(94, 29);
            this.simpleButtonAddUpdate.TabIndex = 1;
            this.simpleButtonAddUpdate.Text = "Добавяне";
            this.simpleButtonAddUpdate.Click += new System.EventHandler(this.simpleButtonAddUpdate_Click);
            // 
            // textEditEducatorName
            // 
            this.textEditEducatorName.Location = new System.Drawing.Point(32, 26);
            this.textEditEducatorName.Name = "textEditEducatorName";
            this.textEditEducatorName.Properties.AutoHeight = false;
            this.textEditEducatorName.Properties.NullValuePrompt = "Име на обучител";
            this.textEditEducatorName.Size = new System.Drawing.Size(287, 26);
            this.textEditEducatorName.TabIndex = 2;
            // 
            // treeListLookUpEditArea
            // 
            this.treeListLookUpEditArea.Location = new System.Drawing.Point(32, 70);
            this.treeListLookUpEditArea.Name = "treeListLookUpEditArea";
            this.treeListLookUpEditArea.Properties.AutoHeight = false;
            this.treeListLookUpEditArea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.treeListLookUpEditArea.Properties.DataSource = this.areaBindingSource;
            this.treeListLookUpEditArea.Properties.DisplayMember = "areaName";
            this.treeListLookUpEditArea.Properties.NullText = "";
            this.treeListLookUpEditArea.Properties.NullValuePrompt = "Научна област";
            this.treeListLookUpEditArea.Properties.TreeList = this.treeListLookUpEdit1TreeList;
            this.treeListLookUpEditArea.Properties.ValueMember = "id";
            this.treeListLookUpEditArea.Size = new System.Drawing.Size(287, 26);
            this.treeListLookUpEditArea.TabIndex = 5;
            this.treeListLookUpEditArea.EditValueChanged += new System.EventHandler(this.treeListLookUpEditArea_EditValueChanged);
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
            this.colareaName.Caption = "Научна област";
            this.colareaName.FieldName = "areaName";
            this.colareaName.Name = "colareaName";
            this.colareaName.Visible = true;
            this.colareaName.VisibleIndex = 0;
            // 
            // treeListLookUpEdit1
            // 
            this.treeListLookUpEdit1.EditValue = "das";
            this.treeListLookUpEdit1.Location = new System.Drawing.Point(32, 114);
            this.treeListLookUpEdit1.Name = "treeListLookUpEdit1";
            this.treeListLookUpEdit1.Properties.AutoHeight = false;
            this.treeListLookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.treeListLookUpEdit1.Properties.DataSource = this.facultyBindingSource;
            this.treeListLookUpEdit1.Properties.DisplayMember = "facultyName";
            this.treeListLookUpEdit1.Properties.NullText = "";
            this.treeListLookUpEdit1.Properties.NullValuePrompt = "Факултет";
            this.treeListLookUpEdit1.Properties.TreeList = this.treeList1;
            this.treeListLookUpEdit1.Properties.ValueMember = "id";
            this.treeListLookUpEdit1.Size = new System.Drawing.Size(287, 26);
            this.treeListLookUpEdit1.TabIndex = 6;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataSource = typeof(ContractPU.Faculty);
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.Факултет});
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsView.ShowIndentAsRowStyle = true;
            this.treeList1.Size = new System.Drawing.Size(400, 200);
            this.treeList1.TabIndex = 0;
            // 
            // Факултет
            // 
            this.Факултет.Caption = "Факултет";
            this.Факултет.FieldName = "facultyName";
            this.Факултет.Name = global::ContractPU.Properties.Settings.Default.Факултет;
            this.Факултет.Visible = true;
            this.Факултет.VisibleIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(179, 166);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Отказване";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // XtraFormAddUpdateEducator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 228);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.treeListLookUpEdit1);
            this.Controls.Add(this.treeListLookUpEditArea);
            this.Controls.Add(this.textEditEducatorName);
            this.Controls.Add(this.simpleButtonAddUpdate);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("XtraFormAddUpdateEducator.IconOptions.SvgImage")));
            this.Name = "XtraFormAddUpdateEducator";
            this.Text = "Добавяне на обучител";
            this.Load += new System.EventHandler(this.XtraFormAddUpdateEducator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditEducatorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEditArea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeListLookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddUpdate;
        private DevExpress.XtraEditors.TextEdit textEditEducatorName;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEditArea;
        private DevExpress.XtraTreeList.TreeList treeListLookUpEdit1TreeList;
        private DevExpress.XtraEditors.TreeListLookUpEdit treeListLookUpEdit1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colareaName;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn Факултет;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}