namespace RichEditMasterDetailMailMerge {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.richEditCategoryTemplate = new DevExpress.XtraRichEdit.RichEditControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.showAllFieldCodesItem = new DevExpress.XtraBars.BarButtonItem();
            this.showAllFieldResultsItem = new DevExpress.XtraBars.BarButtonItem();
            this.performMailMergeItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.richEditResult = new DevExpress.XtraRichEdit.RichEditControl();
            this.tabControlRichEditControls = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageCategory = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageProduct = new DevExpress.XtraTab.XtraTabPage();
            this.richEditProductTemplate = new DevExpress.XtraRichEdit.RichEditControl();
            this.tabPageResult = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlRichEditControls)).BeginInit();
            this.tabControlRichEditControls.SuspendLayout();
            this.tabPageCategory.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // richEditCategoryTemplate
            // 
            this.richEditCategoryTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditCategoryTemplate.Location = new System.Drawing.Point(0, 0);
            this.richEditCategoryTemplate.MenuManager = this.barManager1;
            this.richEditCategoryTemplate.Name = "richEditCategoryTemplate";
            this.richEditCategoryTemplate.Size = new System.Drawing.Size(1136, 744);
            this.richEditCategoryTemplate.TabIndex = 0;
            this.richEditCategoryTemplate.Text = "CategoryTemplate";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.showAllFieldCodesItem,
            this.performMailMergeItem,
            this.showAllFieldResultsItem});
            this.barManager1.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.showAllFieldCodesItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.showAllFieldResultsItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.performMailMergeItem)});
            this.bar1.Text = "Tools";
            // 
            // showAllFieldCodesItem
            // 
            this.showAllFieldCodesItem.Caption = "Show All Field Codes";
            this.showAllFieldCodesItem.Glyph = global::RichEditMasterDetailMailMerge.Properties.Resources.showAllFieldCodesItem_LargeGlyph;
            this.showAllFieldCodesItem.Id = 0;
            this.showAllFieldCodesItem.Name = "showAllFieldCodesItem";
            this.showAllFieldCodesItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.showAllFieldCodesItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showAllFieldCodesItem_ItemClick);
            // 
            // showAllFieldResultsItem
            // 
            this.showAllFieldResultsItem.Caption = "Show All Field Results";
            this.showAllFieldResultsItem.Glyph = global::RichEditMasterDetailMailMerge.Properties.Resources.showAllFieldResultsItem_LargeGlyph;
            this.showAllFieldResultsItem.Id = 2;
            this.showAllFieldResultsItem.Name = "showAllFieldResultsItem";
            this.showAllFieldResultsItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.showAllFieldResultsItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showAllFieldResultsItem_ItemClick);
            // 
            // performMailMergeItem
            // 
            this.performMailMergeItem.Caption = "Create Report";
            this.performMailMergeItem.Glyph = global::RichEditMasterDetailMailMerge.Properties.Resources.performMailMergeItem_LargeGlyph;
            this.performMailMergeItem.Id = 1;
            this.performMailMergeItem.Name = "performMailMergeItem";
            this.performMailMergeItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.performMailMergeItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.performMailMergeItem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1142, 55);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 828);
            this.barDockControlBottom.Size = new System.Drawing.Size(1142, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 55);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 773);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1142, 55);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 773);
            // 
            // richEditResult
            // 
            this.richEditResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditResult.Location = new System.Drawing.Point(0, 0);
            this.richEditResult.MenuManager = this.barManager1;
            this.richEditResult.Name = "richEditResult";
            this.richEditResult.Size = new System.Drawing.Size(1136, 744);
            this.richEditResult.TabIndex = 2;
            this.richEditResult.Text = "Result";
            this.richEditResult.CalculateDocumentVariable += new DevExpress.XtraRichEdit.CalculateDocumentVariableEventHandler(this.richEditResult_CalculateDocumentVariable);
            // 
            // tabControlRichEditControls
            // 
            this.tabControlRichEditControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlRichEditControls.Location = new System.Drawing.Point(0, 55);
            this.tabControlRichEditControls.Name = "tabControlRichEditControls";
            this.tabControlRichEditControls.SelectedTabPage = this.tabPageCategory;
            this.tabControlRichEditControls.Size = new System.Drawing.Size(1142, 773);
            this.tabControlRichEditControls.TabIndex = 3;
            this.tabControlRichEditControls.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageCategory,
            this.tabPageProduct,
            this.tabPageResult});
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.richEditCategoryTemplate);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Size = new System.Drawing.Size(1136, 744);
            this.tabPageCategory.Text = "Category";
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.richEditProductTemplate);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Size = new System.Drawing.Size(1136, 744);
            this.tabPageProduct.Text = "Product";
            // 
            // richEditProductTemplate
            // 
            this.richEditProductTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditProductTemplate.Location = new System.Drawing.Point(0, 0);
            this.richEditProductTemplate.MenuManager = this.barManager1;
            this.richEditProductTemplate.Name = "richEditProductTemplate";
            this.richEditProductTemplate.Size = new System.Drawing.Size(1136, 744);
            this.richEditProductTemplate.TabIndex = 1;
            this.richEditProductTemplate.Text = "ProductTemplate";
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.richEditResult);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Size = new System.Drawing.Size(1136, 744);
            this.tabPageResult.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 828);
            this.Controls.Add(this.tabControlRichEditControls);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabControlRichEditControls)).EndInit();
            this.tabControlRichEditControls.ResumeLayout(false);
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageResult.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditCategoryTemplate;
        private DevExpress.XtraRichEdit.RichEditControl richEditResult;
        private DevExpress.XtraTab.XtraTabControl tabControlRichEditControls;
        private DevExpress.XtraTab.XtraTabPage tabPageCategory;
        private DevExpress.XtraTab.XtraTabPage tabPageProduct;
        private DevExpress.XtraRichEdit.RichEditControl richEditProductTemplate;
        private DevExpress.XtraTab.XtraTabPage tabPageResult;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem showAllFieldCodesItem;
        private DevExpress.XtraBars.BarButtonItem performMailMergeItem;
        private DevExpress.XtraBars.BarButtonItem showAllFieldResultsItem;
    }
}

