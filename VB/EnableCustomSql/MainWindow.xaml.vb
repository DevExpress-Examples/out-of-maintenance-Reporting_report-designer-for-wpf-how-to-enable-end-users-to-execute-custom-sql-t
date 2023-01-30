Imports DevExpress.Xpf.Core
Imports System.Windows

Namespace EnableCustomSql

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub UseDataSourceWizardSettings(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call New DXTabbedWindow() With {.Content = New UseDataSourceWizardSettings()}.ShowDialog()
        End Sub

        Private Sub UseCustomization(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Call New DXTabbedWindow() With {.Content = New UseCustomization()}.ShowDialog()
        End Sub
    End Class
End Namespace
