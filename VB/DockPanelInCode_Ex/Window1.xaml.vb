Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Wpf.Layout.Core

Namespace DockPanelInCode_Ex
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Public Sub New()
			InitializeComponent()
		End Sub

		#Region "#1"
		Private Sub Button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			' Dock the Properties panel at the bottom of the Output panel.
			dockManager1.DockController.Dock(paneProperties, paneOutput, DockType.Bottom)
		End Sub

		Private Sub Button2_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			' Dock the Properties panel to the Output panel, creating a tab container.
			dockManager1.DockController.Dock(paneProperties, paneOutput, DockType.Fill)
		End Sub
		#End Region ' #1
	End Class
End Namespace
