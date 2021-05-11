
namespace ContractPU.EducatiorForms
{
    partial class XtraUserControlEducators
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.educatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemTreeArea = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTreeListLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colareaName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.barEditItemTreeListFaculty = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTreeListLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemTreeListLookUpEdit2TreeList = new DevExpress.XtraTreeList.TreeList();
            this.colfacultyName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coleducatorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colArea = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFaculty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.barButtonItemClear = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.educatorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit2TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // educatorBindingSource
            // 
            this.educatorBindingSource.DataSource = typeof(ContractPU.Cours);
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.bbiPrintPreview,
            this.bsiRecordsCount,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.barEditItemTreeArea,
            this.barEditItemTreeListFaculty,
            this.barButtonItemClear});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 23;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTreeListLookUpEdit1,
            this.repositoryItemTreeListLookUpEdit2});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.Size = new System.Drawing.Size(933, 37);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bbiPrintPreview
            // 
            this.bbiPrintPreview.Caption = "Print Preview";
            this.bbiPrintPreview.Id = 14;
            this.bbiPrintPreview.ImageOptions.ImageUri.Uri = "Preview";
            this.bbiPrintPreview.Name = "bbiPrintPreview";
            this.bbiPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiPrintPreview_ItemClick);
            // 
            // bsiRecordsCount
            // 
            this.bsiRecordsCount.Caption = "RECORDS : 0";
            this.bsiRecordsCount.Id = 15;
            this.bsiRecordsCount.Name = "bsiRecordsCount";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 16;
            this.bbiNew.ImageOptions.ImageUri.Uri = "New";
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // barEditItemTreeArea
            // 
            this.barEditItemTreeArea.Caption = "Научна област";
            this.barEditItemTreeArea.Edit = this.repositoryItemTreeListLookUpEdit1;
            this.barEditItemTreeArea.EditWidth = 150;
            this.barEditItemTreeArea.Id = 20;
            this.barEditItemTreeArea.Name = "barEditItemTreeArea";
            this.barEditItemTreeArea.EditValueChanged += new System.EventHandler(this.barEditItemTreeArea_EditValueChanged);
            this.barEditItemTreeArea.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItemTreeArea_ItemClick);
            // 
            // repositoryItemTreeListLookUpEdit1
            // 
            this.repositoryItemTreeListLookUpEdit1.AutoHeight = false;
            this.repositoryItemTreeListLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTreeListLookUpEdit1.DataSource = this.areaBindingSource;
            this.repositoryItemTreeListLookUpEdit1.DisplayMember = "areaName";
            this.repositoryItemTreeListLookUpEdit1.Name = "repositoryItemTreeListLookUpEdit1";
            this.repositoryItemTreeListLookUpEdit1.NullText = "";
            this.repositoryItemTreeListLookUpEdit1.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataSource = typeof(ContractPU.Area);
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colareaName});
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // colareaName
            // 
            this.colareaName.Caption = "Област";
            this.colareaName.FieldName = "areaName";
            this.colareaName.Name = "colareaName";
            this.colareaName.Visible = true;
            this.colareaName.VisibleIndex = 0;
            // 
            // barEditItemTreeListFaculty
            // 
            this.barEditItemTreeListFaculty.Caption = " Факултет";
            this.barEditItemTreeListFaculty.Edit = this.repositoryItemTreeListLookUpEdit2;
            this.barEditItemTreeListFaculty.EditWidth = 150;
            this.barEditItemTreeListFaculty.Id = 21;
            this.barEditItemTreeListFaculty.Name = "barEditItemTreeListFaculty";
            this.barEditItemTreeListFaculty.EditValueChanged += new System.EventHandler(this.barEditItemTreeArea_EditValueChanged);
            // 
            // repositoryItemTreeListLookUpEdit2
            // 
            this.repositoryItemTreeListLookUpEdit2.AutoHeight = false;
            this.repositoryItemTreeListLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTreeListLookUpEdit2.DataSource = this.facultyBindingSource;
            this.repositoryItemTreeListLookUpEdit2.DisplayMember = "facultyName";
            this.repositoryItemTreeListLookUpEdit2.Name = "repositoryItemTreeListLookUpEdit2";
            this.repositoryItemTreeListLookUpEdit2.NullText = "";
            this.repositoryItemTreeListLookUpEdit2.TreeList = this.repositoryItemTreeListLookUpEdit2TreeList;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataSource = typeof(ContractPU.Faculty);
            // 
            // repositoryItemTreeListLookUpEdit2TreeList
            // 
            this.repositoryItemTreeListLookUpEdit2TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colfacultyName});
            this.repositoryItemTreeListLookUpEdit2TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit2TreeList.Name = "repositoryItemTreeListLookUpEdit2TreeList";
            this.repositoryItemTreeListLookUpEdit2TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit2TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit2TreeList.TabIndex = 0;
            // 
            // colfacultyName
            // 
            this.colfacultyName.Caption = "Факултет";
            this.colfacultyName.FieldName = "facultyName";
            this.colfacultyName.Name = "colfacultyName";
            this.colfacultyName.Visible = true;
            this.colfacultyName.VisibleIndex = 0;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNew);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefresh);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItemTreeArea);
            this.ribbonPageGroup3.ItemLinks.Add(this.barEditItemTreeListFaculty);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItemClear);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.bsiRecordsCount);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 705);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(933, 33);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coleducatorName,
            this.colArea,
            this.colFaculty});
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // coleducatorName
            // 
            this.coleducatorName.Caption = "Обучител";
            this.coleducatorName.FieldName = "educatorName";
            this.coleducatorName.MinWidth = 25;
            this.coleducatorName.Name = "coleducatorName";
            this.coleducatorName.Visible = true;
            this.coleducatorName.VisibleIndex = 0;
            this.coleducatorName.Width = 94;
            // 
            // colArea
            // 
            this.colArea.Caption = "Научна област";
            this.colArea.FieldName = "Area.areaName";
            this.colArea.MinWidth = 25;
            this.colArea.Name = "colArea";
            this.colArea.Visible = true;
            this.colArea.VisibleIndex = 1;
            this.colArea.Width = 94;
            // 
            // colFaculty
            // 
            this.colFaculty.Caption = "Факултет";
            this.colFaculty.FieldName = "Faculty.facultyName";
            this.colFaculty.MinWidth = 25;
            this.colFaculty.Name = "colFaculty";
            this.colFaculty.Visible = true;
            this.colFaculty.VisibleIndex = 2;
            this.colFaculty.Width = 94;
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.educatorBindingSource;
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.Location = new System.Drawing.Point(0, 37);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(933, 701);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            this.gridControl.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            this.gridControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl_KeyDown);
            // 
            // barButtonItemClear
            // 
            this.barButtonItemClear.Caption = "Изчистване";
            this.barButtonItemClear.Id = 22;
            this.barButtonItemClear.Name = "barButtonItemClear";
            this.barButtonItemClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemClear_ItemClick);
            // 
            // XtraUserControlEducators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraUserControlEducators";
            this.Size = new System.Drawing.Size(933, 738);
            this.Load += new System.EventHandler(this.XtraUserControlEducators_Load);
            this.DoubleClick += new System.EventHandler(this.gridControl_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.educatorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit2TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private System.Windows.Forms.BindingSource educatorBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Columns.GridColumn coleducatorName;
        private DevExpress.XtraGrid.Columns.GridColumn colArea;
        private DevExpress.XtraGrid.Columns.GridColumn colFaculty;
        private DevExpress.XtraBars.BarEditItem barEditItemTreeArea;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEdit1;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colareaName;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarEditItem barEditItemTreeListFaculty;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEdit2;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit2TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colfacultyName;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClear;
    }
}
