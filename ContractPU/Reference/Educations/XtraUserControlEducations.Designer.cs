
namespace ContractPU.Reference.Educations
{
    partial class XtraUserControlEducations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraUserControlEducations));
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.contractBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colcontractDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcourseId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpriceWithCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalWithCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltotalWithoutCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpriceWithoutCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiPrintPreview = new DevExpress.XtraBars.BarButtonItem();
            this.bsiRecordsCount = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barEditItemFrom = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItemTo = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItemTreeList = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemTreeListLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit();
            this.coursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemTreeListLookUpEdit1TreeList = new DevExpress.XtraTreeList.TreeList();
            this.coltheme1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTrackBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemTrackBar();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.coltheme = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.DataSource = this.contractBindingSource;
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
            // 
            // contractBindingSource
            // 
            this.contractBindingSource.DataSource = typeof(ContractPU.Contract);
            // 
            // gridView
            // 
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colcontractDate,
            this.colcourseId,
            this.colpriceWithCredit,
            this.coltotalWithCredit,
            this.coltotalWithoutCredit,
            this.colpriceWithoutCredit});
            this.gridView.DetailHeight = 431;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            // 
            // colcontractDate
            // 
            this.colcontractDate.Caption = "Дата на договор";
            this.colcontractDate.DisplayFormat.FormatString = "dd/MM/yy";
            this.colcontractDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colcontractDate.FieldName = "contractDate";
            this.colcontractDate.MinWidth = 25;
            this.colcontractDate.Name = "colcontractDate";
            this.colcontractDate.Visible = true;
            this.colcontractDate.VisibleIndex = 1;
            this.colcontractDate.Width = 118;
            // 
            // colcourseId
            // 
            this.colcourseId.Caption = "Тема";
            this.colcourseId.FieldName = "Cours.theme";
            this.colcourseId.MinWidth = 25;
            this.colcourseId.Name = "colcourseId";
            this.colcourseId.Visible = true;
            this.colcourseId.VisibleIndex = 0;
            this.colcourseId.Width = 340;
            // 
            // colpriceWithCredit
            // 
            this.colpriceWithCredit.Caption = "Цена с кредит";
            this.colpriceWithCredit.DisplayFormat.FormatString = "{0:f2} лв";
            this.colpriceWithCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colpriceWithCredit.FieldName = "priceWithCredit";
            this.colpriceWithCredit.MinWidth = 25;
            this.colpriceWithCredit.Name = "colpriceWithCredit";
            this.colpriceWithCredit.Visible = true;
            this.colpriceWithCredit.VisibleIndex = 2;
            this.colpriceWithCredit.Width = 117;
            // 
            // coltotalWithCredit
            // 
            this.coltotalWithCredit.Caption = "Брой с кредит";
            this.coltotalWithCredit.FieldName = "totalWithCredit";
            this.coltotalWithCredit.MinWidth = 25;
            this.coltotalWithCredit.Name = "coltotalWithCredit";
            this.coltotalWithCredit.Visible = true;
            this.coltotalWithCredit.VisibleIndex = 3;
            this.coltotalWithCredit.Width = 96;
            // 
            // coltotalWithoutCredit
            // 
            this.coltotalWithoutCredit.Caption = "Брой без кредит";
            this.coltotalWithoutCredit.FieldName = "totalWithoutCredit";
            this.coltotalWithoutCredit.MinWidth = 25;
            this.coltotalWithoutCredit.Name = "coltotalWithoutCredit";
            this.coltotalWithoutCredit.Visible = true;
            this.coltotalWithoutCredit.VisibleIndex = 5;
            this.coltotalWithoutCredit.Width = 120;
            // 
            // colpriceWithoutCredit
            // 
            this.colpriceWithoutCredit.Caption = "Цена без кредит";
            this.colpriceWithoutCredit.DisplayFormat.FormatString = "{0:f2} лв";
            this.colpriceWithoutCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colpriceWithoutCredit.FieldName = "priceWithoutCredit";
            this.colpriceWithoutCredit.MinWidth = 25;
            this.colpriceWithoutCredit.Name = "colpriceWithoutCredit";
            this.colpriceWithoutCredit.Visible = true;
            this.colpriceWithoutCredit.VisibleIndex = 4;
            this.colpriceWithoutCredit.Width = 114;
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
            this.barButtonItem1,
            this.barEditItemFrom,
            this.barEditItemTo,
            this.barEditItemTreeList});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl.MaxItemId = 25;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemTrackBar1,
            this.repositoryItemTreeListLookUpEdit1});
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
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 17;
            this.bbiEdit.ImageOptions.ImageUri.Uri = "Edit";
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 18;
            this.bbiDelete.ImageOptions.ImageUri.Uri = "Delete";
            this.bbiDelete.Name = "bbiDelete";
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 19;
            this.bbiRefresh.ImageOptions.ImageUri.Uri = "Refresh";
            this.bbiRefresh.Name = "bbiRefresh";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Обновяване/Изчистване";
            this.barButtonItem1.Id = 20;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barEditItemFrom
            // 
            this.barEditItemFrom.Caption = "От";
            this.barEditItemFrom.Edit = this.repositoryItemDateEdit1;
            this.barEditItemFrom.EditWidth = 100;
            this.barEditItemFrom.Id = 21;
            this.barEditItemFrom.Name = "barEditItemFrom";
            this.barEditItemFrom.EditValueChanged += new System.EventHandler(this.barEditItemFrom_EditValueChanged);
            // 
            // repositoryItemDateEdit1
            // 
            this.repositoryItemDateEdit1.AutoHeight = false;
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit1.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit1.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            // 
            // barEditItemTo
            // 
            this.barEditItemTo.Caption = "До";
            this.barEditItemTo.Edit = this.repositoryItemDateEdit2;
            this.barEditItemTo.EditWidth = 100;
            this.barEditItemTo.Id = 22;
            this.barEditItemTo.Name = "barEditItemTo";
            this.barEditItemTo.EditValueChanged += new System.EventHandler(this.barEditItemFrom_EditValueChanged);
            // 
            // repositoryItemDateEdit2
            // 
            this.repositoryItemDateEdit2.AutoHeight = false;
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit2.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.EditFormat.FormatString = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit2.Mask.EditMask = "dd/MM/yyyy";
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // barEditItemTreeList
            // 
            this.barEditItemTreeList.Edit = this.repositoryItemTreeListLookUpEdit1;
            this.barEditItemTreeList.EditWidth = 180;
            this.barEditItemTreeList.Id = 24;
            this.barEditItemTreeList.Name = "barEditItemTreeList";
            this.barEditItemTreeList.EditValueChanged += new System.EventHandler(this.barEditItemFrom_EditValueChanged);
            this.barEditItemTreeList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEditItem1_ItemClick);
            // 
            // repositoryItemTreeListLookUpEdit1
            // 
            this.repositoryItemTreeListLookUpEdit1.AutoHeight = false;
            this.repositoryItemTreeListLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemTreeListLookUpEdit1.DataSource = this.coursBindingSource;
            this.repositoryItemTreeListLookUpEdit1.DisplayMember = "theme";
            this.repositoryItemTreeListLookUpEdit1.Name = "repositoryItemTreeListLookUpEdit1";
            this.repositoryItemTreeListLookUpEdit1.NullText = "";
            this.repositoryItemTreeListLookUpEdit1.NullValuePrompt = "Тема";
            this.repositoryItemTreeListLookUpEdit1.TreeList = this.repositoryItemTreeListLookUpEdit1TreeList;
            // 
            // coursBindingSource
            // 
            this.coursBindingSource.DataSource = typeof(ContractPU.Cours);
            // 
            // repositoryItemTreeListLookUpEdit1TreeList
            // 
            this.repositoryItemTreeListLookUpEdit1TreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.coltheme1});
            this.repositoryItemTreeListLookUpEdit1TreeList.Location = new System.Drawing.Point(0, 0);
            this.repositoryItemTreeListLookUpEdit1TreeList.Name = "repositoryItemTreeListLookUpEdit1TreeList";
            this.repositoryItemTreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = true;
            this.repositoryItemTreeListLookUpEdit1TreeList.Size = new System.Drawing.Size(400, 200);
            this.repositoryItemTreeListLookUpEdit1TreeList.TabIndex = 0;
            // 
            // coltheme1
            // 
            this.coltheme1.Caption = "Тема";
            this.coltheme1.FieldName = "theme";
            this.coltheme1.Name = "coltheme1";
            this.coltheme1.Visible = true;
            this.coltheme1.VisibleIndex = 0;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.MergeOrder = 0;
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Home";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup2.ItemLinks.Add(this.bbiPrintPreview);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Print and Export";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemFrom);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemTo);
            this.ribbonPageGroup1.ItemLinks.Add(this.barEditItemTreeList);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // repositoryItemTrackBar1
            // 
            this.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = true;
            this.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1";
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
            // coltheme
            // 
            this.coltheme.Caption = "Теми";
            this.coltheme.FieldName = "theme";
            this.coltheme.Name = "coltheme";
            this.coltheme.Visible = true;
            this.coltheme.VisibleIndex = 0;
            // 
            // XtraUserControlEducations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "XtraUserControlEducations";
            this.Size = new System.Drawing.Size(933, 738);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTreeListLookUpEdit1TreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTrackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem bbiPrintPreview;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarStaticItem bsiRecordsCount;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarEditItem barEditItemFrom;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItemTo;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private System.Windows.Forms.BindingSource contractBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colcontractDate;
        private DevExpress.XtraGrid.Columns.GridColumn colcourseId;
        private DevExpress.XtraGrid.Columns.GridColumn colpriceWithCredit;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalWithCredit;
        private DevExpress.XtraGrid.Columns.GridColumn coltotalWithoutCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colpriceWithoutCredit;
        private System.Windows.Forms.BindingSource coursBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coltheme;
        private DevExpress.XtraBars.BarEditItem barEditItemTreeList;
        private DevExpress.XtraEditors.Repository.RepositoryItemTreeListLookUpEdit repositoryItemTreeListLookUpEdit1;
        private DevExpress.XtraTreeList.TreeList repositoryItemTreeListLookUpEdit1TreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn coltheme1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTrackBar repositoryItemTrackBar1;
    }
}
