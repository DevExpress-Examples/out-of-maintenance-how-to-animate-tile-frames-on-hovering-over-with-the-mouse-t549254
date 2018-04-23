Imports Microsoft.VisualBasic
Imports System
Namespace dxExample
	Partial Public Class WindowsUIForm
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
			Me.components = New System.ComponentModel.Container()
			Dim tileItemFrame5 As New DevExpress.XtraEditors.TileItemFrame()
			Dim tileItemElement8 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement9 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemFrame6 As New DevExpress.XtraEditors.TileItemFrame()
			Dim tileItemElement10 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement11 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemFrame1 As New DevExpress.XtraEditors.TileItemFrame()
			Dim tileItemElement1 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemFrame2 As New DevExpress.XtraEditors.TileItemFrame()
			Dim tileItemElement2 As New DevExpress.XtraEditors.TileItemElement()
			Dim tileItemElement3 As New DevExpress.XtraEditors.TileItemElement()
			Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
			Me.windowsUIView1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView(Me.components)
			Me.tileContainer1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer(Me.components)
			Me.document2Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.document2 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			Me.document1Tile = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile(Me.components)
			Me.document1 = New DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document(Me.components)
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.tileContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2Tile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1Tile, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' documentManager1
			' 
			Me.documentManager1.ContainerControl = Me
			Me.documentManager1.View = Me.windowsUIView1
			Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.windowsUIView1})
			' 
			' windowsUIView1
			' 
			Me.windowsUIView1.ContentContainers.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.IContentContainer() { Me.tileContainer1})
			Me.windowsUIView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2})
			Me.windowsUIView1.Tiles.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() { Me.document1Tile, Me.document2Tile})
			' 
			' tileContainer1
			' 
			Me.tileContainer1.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() { New DevExpress.XtraBars.Docking2010.WindowsUIButton("Show TileControl Form", DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton)})
			Me.tileContainer1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.WindowsUI.BaseTile() { Me.document2Tile, Me.document1Tile})
			Me.tileContainer1.Name = "tileContainer1"
'			Me.tileContainer1.ButtonClick += New DevExpress.XtraBars.Docking2010.ButtonEventHandler(Me.tileContainer1_ButtonClick);
			' 
			' document2Tile
			' 
			Me.document2Tile.Document = Me.document2
			tileItemFrame5.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown
			tileItemFrame5.BackgroundImage = My.Resources.top
			tileItemElement8.AnimateTransition = DevExpress.Utils.DefaultBoolean.False
			tileItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			tileItemElement8.Appearance.Normal.Options.UseFont = True
			tileItemElement8.Text = "This is like icebergs..."
			tileItemElement9.Appearance.Normal.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			tileItemElement9.Appearance.Normal.Options.UseFont = True
			tileItemElement9.Text = "Outcome"
			tileItemFrame5.Elements.Add(tileItemElement8)
			tileItemFrame5.Elements.Add(tileItemElement9)
			tileItemFrame6.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop
			tileItemFrame6.BackgroundImage = My.Resources.bottom
			tileItemElement10.AnimateTransition = DevExpress.Utils.DefaultBoolean.False
			tileItemElement10.Appearance.Normal.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			tileItemElement10.Appearance.Normal.Options.UseFont = True
			tileItemElement10.Text = "This is like icebergs..."
			tileItemElement11.Appearance.Normal.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			tileItemElement11.Appearance.Normal.Options.UseFont = True
			tileItemElement11.Text = "Effort"
			tileItemFrame6.Elements.Add(tileItemElement10)
			tileItemFrame6.Elements.Add(tileItemElement11)
			Me.document2Tile.Frames.Add(tileItemFrame5)
			Me.document2Tile.Frames.Add(tileItemFrame6)
			Me.tileContainer1.SetID(Me.document2Tile, 1)
			Me.document2Tile.Name = "document2Tile"
			' 
			' document2
			' 
			Me.document2.Caption = "document2"
			Me.document2.ControlName = "document2"
			' 
			' document1Tile
			' 
			Me.document1Tile.Document = Me.document1
			tileItemFrame1.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollDown
			tileItemElement1.Text = "Short Description"
			tileItemFrame1.Elements.Add(tileItemElement1)
			tileItemFrame2.Animation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop
			tileItemElement2.Text = "Long description"
			tileItemElement3.Text = "This is a long description to better understand what it is."
			tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
			tileItemFrame2.Elements.Add(tileItemElement2)
			tileItemFrame2.Elements.Add(tileItemElement3)
			Me.document1Tile.Frames.Add(tileItemFrame1)
			Me.document1Tile.Frames.Add(tileItemFrame2)
			Me.tileContainer1.SetID(Me.document1Tile, 1)
			Me.document1Tile.Name = "document1Tile"
			' 
			' document1
			' 
			Me.document1.Caption = "document1"
			Me.document1.ControlName = "document1"
			' 
			' WindowsUIForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(847, 551)
			Me.Name = "WindowsUIForm"
			Me.Text = "Form1"
'			Me.Shown += New System.EventHandler(Me.Form1_Shown);
			CType(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.windowsUIView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.tileContainer1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2Tile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1Tile, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
		Private windowsUIView1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.WindowsUIView
		Private WithEvents tileContainer1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.TileContainer
		Private document1Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
		Private document1 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private document2 As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Document
		Private document2Tile As DevExpress.XtraBars.Docking2010.Views.WindowsUI.Tile
	End Class
End Namespace

