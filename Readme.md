<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128604486/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T504221)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/EnableCustomSql/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/EnableCustomSql/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/EnableCustomSql/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/EnableCustomSql/MainWindow.xaml.vb))
* [UseCustomization.xaml](./CS/EnableCustomSql/UseCustomization.xaml) (VB: [UseCustomization.xaml](./VB/EnableCustomSql/UseCustomization.xaml))
* [UseCustomization.xaml.cs](./CS/EnableCustomSql/UseCustomization.xaml.cs) (VB: [UseCustomization.xaml.vb](./VB/EnableCustomSql/UseCustomization.xaml.vb))
* [UseDataSourceWizardSettings.xaml](./CS/EnableCustomSql/UseDataSourceWizardSettings.xaml) (VB: [UseDataSourceWizardSettings.xaml](./VB/EnableCustomSql/UseDataSourceWizardSettings.xaml))
* [UseDataSourceWizardSettings.xaml.cs](./CS/EnableCustomSql/UseDataSourceWizardSettings.xaml.cs) (VB: [UseDataSourceWizardSettings.xaml.vb](./VB/EnableCustomSql/UseDataSourceWizardSettings.xaml.vb))
<!-- default file list end -->
# Report Designer for WPF - How to enable end-users to execute custom SQL


By default, the <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument114850">SQL Data Source wizard</a> only allows the visual construction of SQL queries using the built-in <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument117846">Query Builder</a>. Queries constructed using the Query Builder can only contain a SELECT statement and are guaranteed to be safe.<br><br>Manual editing of SQL queries is considered unsafe and is disabled by default. You can enable SQL editing at your own risk using the approach described in this example.<br><br>If custom SQL editing is enabled, the Query Builder contains the <strong>Allow Edit SQL</strong> check box, which also enables the capability to specify the custom SQL query manually.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/report-designer-for-wpf-how-to-enable-end-users-to-execute-custom-sql-t504221/17.1.3+/media/d6b6a99f-2108-11e7-80bf-00155d62480c.png"><br><br><strong>IMPORTANT NOTE</strong>:<br>Custom SQL queries are not validated before their execution and may contain potentially harmful instructions. For this reason, we strongly recommend that you implement your own validation logic that permits only execution of specific query kinds. See <a href="https://www.devexpress.com/example=T564363">Report Designer for WPF - How to provide custom SQL validation</a> for a code sample.

<br/>


