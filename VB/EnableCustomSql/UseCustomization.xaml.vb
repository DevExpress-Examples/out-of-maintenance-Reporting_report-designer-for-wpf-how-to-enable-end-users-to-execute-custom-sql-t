Imports DevExpress.DataAccess.Wizard
Imports DevExpress.DataAccess.Wizard.Model
Imports DevExpress.Xpf.DataAccess.DataSourceWizard
Imports DevExpress.Xpf.Reports.UserDesigner.ReportWizard
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Wizards
Imports System.Windows.Controls

Namespace EnableCustomSql
	''' <summary>
	''' Interaction logic for UseCustomization.xaml
	''' </summary>
	Partial Public Class UseCustomization
		Inherits UserControl

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class

	Public Class WizardCustomizationService
		Implements IWizardCustomizationService

		Private Sub IDataSourceWizardCustomizationService_CustomizeDataSourceWizard(ByVal customization As DataSourceWizardCustomizationModel, ByVal container As ViewModelSourceIntegrityContainer) Implements IDataSourceWizardCustomizationService.CustomizeDataSourceWizard
			Dim sqlOptions = container.Resolve(Of SqlWizardOptions)() Or SqlWizardOptions.EnableCustomSql
			container.RegisterInstance(sqlOptions)
		End Sub

		Private Sub IWizardCustomizationService_CustomizeReportWizard(ByVal customization As ReportWizardCustomizationModel, ByVal container As ViewModelSourceIntegrityContainer) Implements IWizardCustomizationService.CustomizeReportWizard
			Dim sqlOptions = container.Resolve(Of SqlWizardOptions)() Or SqlWizardOptions.EnableCustomSql
			container.RegisterInstance(sqlOptions)
		End Sub

		Private Function IDataSourceWizardCustomizationService_TryCreateDataSource(ByVal model As IDataSourceModel, ByRef dataSource As Object, ByRef dataMember As String) As Boolean Implements IDataSourceWizardCustomizationService.TryCreateDataSource
			dataSource = Nothing
			dataMember = Nothing
			Return False
		End Function

		Private Function IWizardCustomizationService_TryCreateReport(ByVal model As XtraReportModel, ByRef report As XtraReport) As Boolean Implements IWizardCustomizationService.TryCreateReport
			report = Nothing
			Return False
		End Function
	End Class
End Namespace
