Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.Commands
Imports DevExpress.XtraRichEdit.Services
Imports DevExpress.XtraRichEdit.API.Native

Namespace RichEditMasterDetailMailMerge
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			richEditCategoryTemplate.LoadDocument("MasterTemplate.rtf")
			richEditProductTemplate.LoadDocument("DetailTemplate.rtf")
			ShowAllFieldCodes(richEditCategoryTemplate)
			ShowAllFieldCodes(richEditProductTemplate)
		End Sub

		Private Sub performMailMergeItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles performMailMergeItem.ItemClick
			richEditCategoryTemplate.Options.MailMerge.DataSource = NorthwindDataProvider.Categories

			Dim mailMergeOptions As MailMergeOptions = richEditCategoryTemplate.CreateMailMergeOptions()
			mailMergeOptions.MergeMode = MergeMode.NewParagraph

			richEditCategoryTemplate.MailMerge(mailMergeOptions, richEditResult)

			tabControlRichEditControls.SelectedTabPage = tabPageResult
		End Sub

		Private Sub richEditResult_CalculateDocumentVariable(ByVal sender As Object, ByVal e As CalculateDocumentVariableEventArgs) Handles richEditResult.CalculateDocumentVariable
			Dim categoryId As Integer = -1

			If Int32.TryParse(e.Arguments(0).Value, categoryId) Then
				richEditProductTemplate.Options.MailMerge.DataSource = NorthwindDataProvider.GetProductsByCategoryId(categoryId)

				Dim documentServerProducts As New RichEditDocumentServer()
				Dim mailMergeOptions As MailMergeOptions = richEditProductTemplate.CreateMailMergeOptions()
				mailMergeOptions.MergeMode = MergeMode.JoinTables

				richEditProductTemplate.MailMerge(mailMergeOptions, documentServerProducts)

				e.Value = documentServerProducts
				e.Handled = True
			End If
		End Sub

		#Region "Helper Methods"
		Private Sub showAllFieldCodesItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles showAllFieldCodesItem.ItemClick
			ShowAllFieldCodes(CType(tabControlRichEditControls.SelectedTabPage.Controls(0), RichEditControl))
		End Sub

		Private Sub showAllFieldResultsItem_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles showAllFieldResultsItem.ItemClick
			ShowAllFieldResults(CType(tabControlRichEditControls.SelectedTabPage.Controls(0), RichEditControl))
		End Sub

		Private Sub ShowAllFieldCodes(ByVal richEditControl As RichEditControl)
			Dim showAllFieldCodesCommand As New ShowAllFieldCodesCommand(richEditControl)
			showAllFieldCodesCommand.Execute()
		End Sub

		Private Sub ShowAllFieldResults(ByVal richEditControl As RichEditControl)
			Dim showAllFieldResultsCommand As New ShowAllFieldResultsCommand(richEditControl)
			showAllFieldResultsCommand.Execute()
		End Sub
		#End Region ' Helper Methods
	End Class
End Namespace