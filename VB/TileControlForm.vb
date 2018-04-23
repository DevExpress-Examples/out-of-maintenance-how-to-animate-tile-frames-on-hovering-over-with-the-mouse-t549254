Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Linq

Namespace dxExample
	Partial Public Class TileControlForm
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			Dim TempFrameHoverHelper As FrameHoverHelper = New FrameHoverHelper(tileControl1)
		End Sub
	End Class
End Namespace
