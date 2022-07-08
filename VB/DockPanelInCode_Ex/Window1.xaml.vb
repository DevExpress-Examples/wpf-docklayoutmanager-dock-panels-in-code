Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Layout.Core

Namespace DockPanelInCode_Ex

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

'#Region "#1"
        Private Sub Button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ' Dock the Properties panel at the bottom of the Output panel.
            Me.dockManager1.DockController.Dock(Me.paneProperties, Me.paneOutput, DockType.Bottom)
        End Sub

        Private Sub Button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            ' Dock the Properties panel to the Output panel, creating a tab container.
            Me.dockManager1.DockController.Dock(Me.paneProperties, Me.paneOutput, DockType.Fill)
        End Sub
'#End Region  ' #1
    End Class
End Namespace
