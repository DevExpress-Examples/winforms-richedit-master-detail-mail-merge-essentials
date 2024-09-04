<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128611720/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3662)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [NorthwindDataProvider.cs](./CS/NorthwindDataProvider.cs) (VB: [NorthwindDataProvider.vb](./VB/NorthwindDataProvider.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# Master-Detail Mail Merge essential - The simplest implementation


<p>This example illustrates how to create the simplest Master-Detail report by combining the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9330"><u>Mail Merge</u></a> feature with the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument9721"><u>DOCVARIABLE</u></a>, <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_CalculateDocumentVariabletopic"><u>RichEditControl.CalculateDocumentVariable</u></a> and <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressXtraRichEditRichEditDocumentServertopic"><u>RichEditDocumentServer Class</u></a> functionality. Three <strong>RichEditControl</strong> instances are used in this example. The first and the second controls contain master (Category) and detail (Product) templates correspondingly. The third control is used to display the resultant report.</p><p>The actual report generation implementation is pretty simple. When you press the "Create Report" button, master data rows from the first control are merged into the third control via the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraRichEditRichEditControl_MailMergetopic1468"><u>RichEditControl.MailMerge Method</u></a> call. During this process, the <strong>CalculateDocumentVariable</strong> event is raised for the third control, because the master template (in the first control) contains a <strong>DOCVARIABLE</strong> field. Detail data rows from the second control are merged into a <strong>RichEditDocumentServer</strong> instance in this event handler. Finally, this instance is assigned to the <strong>e.Value</strong> parameter.</p><p>Both master and detail templates for this example are created by using <a href="https://www.devexpress.com/Support/Center/p/E3661">Utility for creating a Mail Merge template</a>.</p><p>To test this example locally, setup the sample "Northwind" database in your SQL Server instance by using the instnwind.sql file, attached with this example.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/master-detail-mail-merge-essential-the-simplest-implementation-e3662/13.1.6+/media/324c3a59-f99c-417d-8f46-f8090f827db6.png"></p><p><strong>See Also:<br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E3280">How to use the Document.CalculateDocumentVariable event to insert a formatted content via the DOCVARIABLE field with a parameter</a><strong><br />
</strong><a href="https://www.devexpress.com/Support/Center/p/E3331">How to create a master-detail report in a RichEditControl</a></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-master-detail-mail-merge-essentials&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-richedit-master-detail-mail-merge-essentials&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
