Imports Microsoft.VisualBasic
Imports System
Namespace dxExample
	Partial Public Class TileControlForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim tileItemFrame1 As New DevExpress.XtraEditors.TileItemFrame()
			Dim tileItemFrame2 As New DevExpress.XtraEditors.TileItemFrame()
			Dim tileItemElement1 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemFrame3 As New DevExpress.XtraEditors.TileItemFrame()
			Dim tileItemElement2 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemFrame4 As New DevExpress.XtraEditors.TileItemFrame()
			Dim tileItemElement3 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement4 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement5 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement6 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement7 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement8 As New DevExpress.XtraEditors.TileItemElement()
			Me.tileControl1 = New DevExpress.XtraEditors.TileControl()
			Me.tileGroup2 = New DevExpress.XtraEditors.TileGroup()
			Me.tileItem1 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem2 = New DevExpress.XtraEditors.TileItem()
			Me.tileItem3 = New DevExpress.XtraEditors.TileItem()
			Me.SuspendLayout()
			' 
			' tileControl1
			' 
			Me.tileControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.tileControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.tileControl1.Groups.Add(Me.tileGroup2)
			Me.tileControl1.Location = New System.Drawing.Point(0, 0)
			Me.tileControl1.MaxId = 3
			Me.tileControl1.Name = "tileControl1"
			Me.tileControl1.Size = New System.Drawing.Size(847, 551)
			Me.tileControl1.TabIndex = 0
			Me.tileControl1.Text = "tileControl1"
			' 
			' tileGroup2
			' 
			Me.tileGroup2.Items.Add(Me.tileItem1)
			Me.tileGroup2.Items.Add(Me.tileItem2)
			Me.tileGroup2.Items.Add(Me.tileItem3)
			Me.tileGroup2.Name = "tileGroup2"
			' 
			' tileItem1
			' 
			tileItemFrame1.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown
			tileItemFrame1.Appearance.BackColor = System.Drawing.Color.Maroon
			tileItemFrame1.Appearance.BackColor2 = System.Drawing.Color.Red
			tileItemFrame1.Appearance.BorderColor = System.Drawing.Color.Red
			tileItemFrame1.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			tileItemFrame1.Appearance.Options.UseBackColor = True
			tileItemFrame1.Appearance.Options.UseBorderColor = True
			tileItemFrame2.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop
			tileItemFrame2.Appearance.BackColor = System.Drawing.Color.Red
			tileItemFrame2.Appearance.BackColor2 = System.Drawing.Color.FromArgb((CInt(Fix((CByte(255))))), (CInt(Fix((CByte(192))))), (CInt(Fix((CByte(192))))))
			tileItemFrame2.Appearance.BorderColor = System.Drawing.Color.Red
			tileItemFrame2.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
			tileItemFrame2.Appearance.Options.UseBackColor = True
			tileItemFrame2.Appearance.Options.UseBorderColor = True
			Me.tileItem1.Frames.Add(tileItemFrame1)
			Me.tileItem1.Frames.Add(tileItemFrame2)
			Me.tileItem1.Id = 0
			Me.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
			Me.tileItem1.Name = "tileItem1"
			' 
			' tileItem2
			' 
			tileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			tileItemElement1.Appearance.Normal.Options.UseFont = True
			tileItemElement1.Text = "Customers"
			Me.tileItem2.Elements.Add(tileItemElement1)
			tileItemFrame3.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown
			tileItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			tileItemElement2.Appearance.Normal.Options.UseFont = True
			tileItemElement2.Text = "Customers"
			tileItemFrame3.Elements.Add(tileItemElement2)
			tileItemFrame4.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop
			tileItemElement3.Text = "Bart Anraz"
			tileItemElement4.Text = "Billy Zimmer"
			tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
			tileItemElement4.TextLocation = New System.Drawing.Point(0, 20)
			tileItemElement5.Text = "Terry Bradley"
			tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
			tileItemElement5.TextLocation = New System.Drawing.Point(0, 40)
			tileItemElement6.Text = "Greta Sims"
			tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
			tileItemElement6.TextLocation = New System.Drawing.Point(0, 60)
			tileItemElement7.Text = "Brett Wade"
			tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
			tileItemElement7.TextLocation = New System.Drawing.Point(0, 80)
			tileItemFrame4.Elements.Add(tileItemElement3)
			tileItemFrame4.Elements.Add(tileItemElement4)
			tileItemFrame4.Elements.Add(tileItemElement5)
			tileItemFrame4.Elements.Add(tileItemElement6)
			tileItemFrame4.Elements.Add(tileItemElement7)
			Me.tileItem2.Frames.Add(tileItemFrame3)
			Me.tileItem2.Frames.Add(tileItemFrame4)
			Me.tileItem2.Id = 1
			Me.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem2.Name = "tileItem2"
			' 
			' tileItem3
			' 
			tileItemElement8.Text = "Tile without frames"
			Me.tileItem3.Elements.Add(tileItemElement8)
			Me.tileItem3.Id = 2
			Me.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
			Me.tileItem3.Name = "tileItem3"
			' 
			' TileControlForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(847, 551)
			Me.Controls.Add(Me.tileControl1)
			Me.Name = "TileControlForm"
			Me.Text = "TileControlForm"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private tileControl1 As DevExpress.XtraEditors.TileControl
		Private tileGroup2 As DevExpress.XtraEditors.TileGroup
		Private tileItem1 As DevExpress.XtraEditors.TileItem
		Private tileItem2 As DevExpress.XtraEditors.TileItem
		Private tileItem3 As DevExpress.XtraEditors.TileItem
	End Class
End Namespace