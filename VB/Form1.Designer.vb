Imports Microsoft.VisualBasic
Imports System
Namespace RichEditMasterDetailMailMerge
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.richEditCategoryTemplate = New DevExpress.XtraRichEdit.RichEditControl()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.bar1 = New DevExpress.XtraBars.Bar()
			Me.showAllFieldCodesItem = New DevExpress.XtraBars.BarButtonItem()
			Me.showAllFieldResultsItem = New DevExpress.XtraBars.BarButtonItem()
			Me.performMailMergeItem = New DevExpress.XtraBars.BarButtonItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.richEditResult = New DevExpress.XtraRichEdit.RichEditControl()
			Me.tabControlRichEditControls = New DevExpress.XtraTab.XtraTabControl()
			Me.tabPageCategory = New DevExpress.XtraTab.XtraTabPage()
			Me.tabPageProduct = New DevExpress.XtraTab.XtraTabPage()
			Me.richEditProductTemplate = New DevExpress.XtraRichEdit.RichEditControl()
			Me.tabPageResult = New DevExpress.XtraTab.XtraTabPage()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tabControlRichEditControls, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.tabControlRichEditControls.SuspendLayout()
			Me.tabPageCategory.SuspendLayout()
			Me.tabPageProduct.SuspendLayout()
			Me.tabPageResult.SuspendLayout()
			Me.SuspendLayout()
			' 
			' richEditCategoryTemplate
			' 
			Me.richEditCategoryTemplate.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditCategoryTemplate.Location = New System.Drawing.Point(0, 0)
			Me.richEditCategoryTemplate.MenuManager = Me.barManager1
			Me.richEditCategoryTemplate.Name = "richEditCategoryTemplate"
			Me.richEditCategoryTemplate.Size = New System.Drawing.Size(1136, 744)
			Me.richEditCategoryTemplate.TabIndex = 0
			Me.richEditCategoryTemplate.Text = "CategoryTemplate"
			' 
			' barManager1
			' 
			Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1})
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.showAllFieldCodesItem, Me.performMailMergeItem, Me.showAllFieldResultsItem})
			Me.barManager1.MaxItemId = 3
			' 
			' bar1
			' 
			Me.bar1.BarName = "Tools"
			Me.bar1.DockCol = 0
			Me.bar1.DockRow = 0
			Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.showAllFieldCodesItem), New DevExpress.XtraBars.LinkPersistInfo(Me.showAllFieldResultsItem), New DevExpress.XtraBars.LinkPersistInfo(Me.performMailMergeItem)})
			Me.bar1.Text = "Tools"
			' 
			' showAllFieldCodesItem
			' 
			Me.showAllFieldCodesItem.Caption = "Show All Field Codes"
			Me.showAllFieldCodesItem.Glyph = My.Resources.showAllFieldCodesItem_LargeGlyph
			Me.showAllFieldCodesItem.Id = 0
			Me.showAllFieldCodesItem.Name = "showAllFieldCodesItem"
			Me.showAllFieldCodesItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.showAllFieldCodesItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.showAllFieldCodesItem_ItemClick);
			' 
			' showAllFieldResultsItem
			' 
			Me.showAllFieldResultsItem.Caption = "Show All Field Results"
			Me.showAllFieldResultsItem.Glyph = My.Resources.showAllFieldResultsItem_LargeGlyph
			Me.showAllFieldResultsItem.Id = 2
			Me.showAllFieldResultsItem.Name = "showAllFieldResultsItem"
			Me.showAllFieldResultsItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.showAllFieldResultsItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.showAllFieldResultsItem_ItemClick);
			' 
			' performMailMergeItem
			' 
			Me.performMailMergeItem.Caption = "Create Report"
			Me.performMailMergeItem.Glyph = My.Resources.performMailMergeItem_LargeGlyph
			Me.performMailMergeItem.Id = 1
			Me.performMailMergeItem.Name = "performMailMergeItem"
			Me.performMailMergeItem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
'			Me.performMailMergeItem.ItemClick += New DevExpress.XtraBars.ItemClickEventHandler(Me.performMailMergeItem_ItemClick);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(1142, 55)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 828)
			Me.barDockControlBottom.Size = New System.Drawing.Size(1142, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 55)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 773)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(1142, 55)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 773)
			' 
			' richEditResult
			' 
			Me.richEditResult.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditResult.Location = New System.Drawing.Point(0, 0)
			Me.richEditResult.MenuManager = Me.barManager1
			Me.richEditResult.Name = "richEditResult"
			Me.richEditResult.Size = New System.Drawing.Size(1136, 744)
			Me.richEditResult.TabIndex = 2
			Me.richEditResult.Text = "Result"
'			Me.richEditResult.CalculateDocumentVariable += New DevExpress.XtraRichEdit.CalculateDocumentVariableEventHandler(Me.richEditResult_CalculateDocumentVariable);
			' 
			' tabControlRichEditControls
			' 
			Me.tabControlRichEditControls.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tabControlRichEditControls.Location = New System.Drawing.Point(0, 55)
			Me.tabControlRichEditControls.Name = "tabControlRichEditControls"
			Me.tabControlRichEditControls.SelectedTabPage = Me.tabPageCategory
			Me.tabControlRichEditControls.Size = New System.Drawing.Size(1142, 773)
			Me.tabControlRichEditControls.TabIndex = 3
			Me.tabControlRichEditControls.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.tabPageCategory, Me.tabPageProduct, Me.tabPageResult})
			' 
			' tabPageCategory
			' 
			Me.tabPageCategory.Controls.Add(Me.richEditCategoryTemplate)
			Me.tabPageCategory.Name = "tabPageCategory"
			Me.tabPageCategory.Size = New System.Drawing.Size(1136, 744)
			Me.tabPageCategory.Text = "Category"
			' 
			' tabPageProduct
			' 
			Me.tabPageProduct.Controls.Add(Me.richEditProductTemplate)
			Me.tabPageProduct.Name = "tabPageProduct"
			Me.tabPageProduct.Size = New System.Drawing.Size(1136, 744)
			Me.tabPageProduct.Text = "Product"
			' 
			' richEditProductTemplate
			' 
			Me.richEditProductTemplate.Dock = System.Windows.Forms.DockStyle.Fill
			Me.richEditProductTemplate.Location = New System.Drawing.Point(0, 0)
			Me.richEditProductTemplate.MenuManager = Me.barManager1
			Me.richEditProductTemplate.Name = "richEditProductTemplate"
			Me.richEditProductTemplate.Size = New System.Drawing.Size(1136, 744)
			Me.richEditProductTemplate.TabIndex = 1
			Me.richEditProductTemplate.Text = "ProductTemplate"
			' 
			' tabPageResult
			' 
			Me.tabPageResult.Controls.Add(Me.richEditResult)
			Me.tabPageResult.Name = "tabPageResult"
			Me.tabPageResult.Size = New System.Drawing.Size(1136, 744)
			Me.tabPageResult.Text = "Result"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1142, 828)
			Me.Controls.Add(Me.tabControlRichEditControls)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tabControlRichEditControls, System.ComponentModel.ISupportInitialize).EndInit()
			Me.tabControlRichEditControls.ResumeLayout(False)
			Me.tabPageCategory.ResumeLayout(False)
			Me.tabPageProduct.ResumeLayout(False)
			Me.tabPageResult.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditCategoryTemplate As DevExpress.XtraRichEdit.RichEditControl
		Private WithEvents richEditResult As DevExpress.XtraRichEdit.RichEditControl
		Private tabControlRichEditControls As DevExpress.XtraTab.XtraTabControl
		Private tabPageCategory As DevExpress.XtraTab.XtraTabPage
		Private tabPageProduct As DevExpress.XtraTab.XtraTabPage
		Private richEditProductTemplate As DevExpress.XtraRichEdit.RichEditControl
		Private tabPageResult As DevExpress.XtraTab.XtraTabPage
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private bar1 As DevExpress.XtraBars.Bar
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private WithEvents showAllFieldCodesItem As DevExpress.XtraBars.BarButtonItem
		Private WithEvents performMailMergeItem As DevExpress.XtraBars.BarButtonItem
		Private WithEvents showAllFieldResultsItem As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

