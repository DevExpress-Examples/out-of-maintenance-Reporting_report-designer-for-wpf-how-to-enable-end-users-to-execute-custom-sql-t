Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace EnableCustomSql
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub UseDataSourceWizardSettings(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CType(New DXTabbedWindow() With {.Content = New UseDataSourceWizardSettings()}, DXTabbedWindow).ShowDialog()
        End Sub

        Private Sub UseCustomization(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CType(New DXTabbedWindow() With {.Content = New UseCustomization()}, DXTabbedWindow).ShowDialog()
        End Sub
    End Class
End Namespace
