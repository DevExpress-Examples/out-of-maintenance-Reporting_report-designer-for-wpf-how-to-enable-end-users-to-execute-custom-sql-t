using DevExpress.DataAccess.Wizard;
using DevExpress.DataAccess.Wizard.Model;
using DevExpress.Xpf.DataAccess.DataSourceWizard;
using DevExpress.Xpf.Reports.UserDesigner.ReportWizard;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Wizards;
using System.Windows.Controls;

namespace EnableCustomSql {
    /// <summary>
    /// Interaction logic for UseCustomization.xaml
    /// </summary>
    public partial class UseCustomization : UserControl {
        public UseCustomization() {
            InitializeComponent();
        }
    }

    public class WizardCustomizationService : IWizardCustomizationService {
        void IDataSourceWizardCustomizationService.CustomizeDataSourceWizard(DataSourceWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
            var sqlOptions = container.Resolve<SqlWizardOptions>() | SqlWizardOptions.EnableCustomSql;
            container.RegisterInstance(sqlOptions);
        }

        void IWizardCustomizationService.CustomizeReportWizard(ReportWizardCustomizationModel customization, ViewModelSourceIntegrityContainer container) {
            var sqlOptions = container.Resolve<SqlWizardOptions>() | SqlWizardOptions.EnableCustomSql;
            container.RegisterInstance(sqlOptions);
        }

        bool IDataSourceWizardCustomizationService.TryCreateDataSource(IDataSourceModel model, out object dataSource, out string dataMember) {
            dataSource = null;
            dataMember = null;
            return false;
        }

        bool IWizardCustomizationService.TryCreateReport(XtraReportModel model, out XtraReport report) {
            report = null;
            return false;
        }
    }
}
