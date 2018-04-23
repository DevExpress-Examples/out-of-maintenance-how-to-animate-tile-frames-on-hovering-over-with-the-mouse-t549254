Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Linq
Imports System.Windows.Forms

Namespace dxExample
	Partial Public Class WindowsUIForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Shown
			Dim TempFrameHoverHelper As FrameHoverHelper = New FrameHoverHelper(TryCast(tileContainer1.Info, ITileControl))
		End Sub
		Private Sub WindowsUIView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs)
			e.Control = New Control()
		End Sub
		Private Sub tileContainer1_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.ButtonEventArgs) Handles tileContainer1.ButtonClick
			Dim tcForm As New TileControlForm()
			tcForm.Show()
		End Sub
	End Class
End Namespace
