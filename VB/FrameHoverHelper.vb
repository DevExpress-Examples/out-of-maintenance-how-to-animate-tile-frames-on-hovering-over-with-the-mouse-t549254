Imports Microsoft.VisualBasic
Imports DevExpress.XtraEditors
Imports System
Imports System.Linq
Imports System.Windows.Forms

Namespace dxExample
	Public Class FrameHoverHelper
		Private tileControl As ITileControl
		Public Sub New(ByVal tileHolder As ITileControl)
			tileControl = tileHolder
			For Each group As TileGroup In tileControl.Groups
				For Each item As TileItem In group.Items
					item.AllowAnimation = False
				Next item
			Next group
			AddHandler tileControl.Control.MouseMove, AddressOf control_MouseMove
		End Sub

		Private Sub control_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
			Dim tileHi As TileControlHitInfo = tileControl.CalcHitInfo(e.Location)
			If tileHi.InItem Then
				HoveredItem = tileHi.ItemInfo.Item
			Else
				HoveredItem = Nothing
			End If
		End Sub

		Private _HoveredItem As TileItem
		Private Property HoveredItem() As TileItem
			Get
				Return _HoveredItem
			End Get
			Set(ByVal value As TileItem)
				If _HoveredItem IsNot value Then
					If value IsNot Nothing AndAlso IsTileValidForAnimation(value) Then
						value.SetContent(value.Frames(1), True)
					End If
					If _HoveredItem IsNot Nothing AndAlso IsTileValidForAnimation(_HoveredItem) Then
						_HoveredItem.SetContent(_HoveredItem.Frames(0), True)
					End If
					_HoveredItem = value
				End If
			End Set
		End Property
		Private Function IsTileValidForAnimation(ByVal tile As TileItem) As Boolean
			Return tile.Frames.Count >= 2
		End Function
	End Class
End Namespace
