using System;
using System.Windows.Forms;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit.API.Native;

namespace RichEditMasterDetailMailMerge {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            richEditCategoryTemplate.LoadDocument("MasterTemplate.rtf");
            richEditProductTemplate.LoadDocument("DetailTemplate.rtf");
            ShowAllFieldCodes(richEditCategoryTemplate);
            ShowAllFieldCodes(richEditProductTemplate);
        }

        private void performMailMergeItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            richEditCategoryTemplate.Options.MailMerge.DataSource = NorthwindDataProvider.Categories;

            MailMergeOptions mailMergeOptions = richEditCategoryTemplate.CreateMailMergeOptions();
            mailMergeOptions.MergeMode = MergeMode.NewParagraph;

            richEditCategoryTemplate.MailMerge(mailMergeOptions, richEditResult);

            tabControlRichEditControls.SelectedTabPage = tabPageResult;
        }

        void richEditResult_CalculateDocumentVariable(object sender, CalculateDocumentVariableEventArgs e) {
            int categoryId = -1;

            if (Int32.TryParse(e.Arguments[0].Value, out categoryId)) {
                richEditProductTemplate.Options.MailMerge.DataSource = NorthwindDataProvider.GetProductsByCategoryId(categoryId);

                RichEditDocumentServer documentServerProducts = new RichEditDocumentServer();
                MailMergeOptions mailMergeOptions = richEditProductTemplate.CreateMailMergeOptions();
                mailMergeOptions.MergeMode = MergeMode.JoinTables;

                richEditProductTemplate.MailMerge(mailMergeOptions, documentServerProducts);

                e.Value = documentServerProducts;
                e.Handled = true;
            }
        }

        #region Helper Methods
        private void showAllFieldCodesItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ShowAllFieldCodes((RichEditControl)tabControlRichEditControls.SelectedTabPage.Controls[0]);
        }

        private void showAllFieldResultsItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ShowAllFieldResults((RichEditControl)tabControlRichEditControls.SelectedTabPage.Controls[0]);
        }

        private void ShowAllFieldCodes(RichEditControl richEditControl) {
            ShowAllFieldCodesCommand showAllFieldCodesCommand = new ShowAllFieldCodesCommand(richEditControl);
            showAllFieldCodesCommand.Execute();
        }

        private void ShowAllFieldResults(RichEditControl richEditControl) {
            ShowAllFieldResultsCommand showAllFieldResultsCommand = new ShowAllFieldResultsCommand(richEditControl);
            showAllFieldResultsCommand.Execute();
        }
        #endregion Helper Methods
    }
}