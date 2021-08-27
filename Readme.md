<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616113/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T549254)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[FrameHoverHelper.cs](./CS/FrameHoverHelper.cs) (VB: [FrameHoverHelper.vb](./VB/FrameHoverHelper.vb))**
* [TileControlForm.cs](./CS/TileControlForm.cs) (VB: [TileControlForm.vb](./VB/TileControlForm.vb))
* [WindowsUIForm.cs](./CS/WindowsUIForm.cs) (VB: [WindowsUIForm.vb](./VB/WindowsUIForm.vb))
<!-- default file list end -->
# How to animate tile frames on hovering over with the mouse


<p><strong>Applies to</strong> <a href="https://documentation.devexpress.com/WindowsForms/10998/Controls-and-Libraries/Navigation-Controls/Tile-Control">TileControl</a> and <a href="https://documentation.devexpress.com/WindowsForms/11771/Controls-and-Libraries/Application-UI-Manager/Views/WindowsUI-View/Content-Containers">TileContainer</a> (<a href="https://documentation.devexpress.com/WindowsForms/11854/Controls-and-Libraries/Application-UI-Manager/Views/WindowsUI-View">WindowsUIView</a>) since only these containers support tile frame animations.<br><br><br>Sometimes it is useful to show only brief data on a tile and show detailed information there on hovering over this tile with the mouse. Tooltips implement a similar idea.<br><br>The first thing you may think of is to create two <a href="https://documentation.devexpress.com/WindowsForms/DevExpress.XtraEditors.TileItemFrame.class">TileItemFrame</a><u>s</u> for the tile:<br><strong>1st frame:</strong> show brief data<br><strong>2nd frame:</strong> show detailed data<br>Now, you need to switch between frames when the mouse is over the tile and not.<br><br>This example demonstrates how to animate tile frames in this way. The <strong>FrameHoverHelper</strong> class encapsulates all the required functionality. Pass your tile container to <strong>FrameHoverHelper</strong>'s constructor to apply this custom animation.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-animate-tile-frames-on-hovering-over-with-the-mouse-t549254/14.1.3+/media/f6625d22-0e89-40f5-b4c0-33aa5158a141.png"></p>


<h3>Description</h3>

The&nbsp;<strong>FrameHoverHelper</strong>&nbsp;class requires an <strong>ITileControl</strong> instance. <a href="https://documentation.devexpress.com/WindowsForms/10998/Controls-and-Libraries/Navigation-Controls/Tile-Control">TileControl</a>&nbsp;implements this interface and you can pass it as is. <a href="https://documentation.devexpress.com/WindowsForms/11771/Controls-and-Libraries/Application-UI-Manager/Views/WindowsUI-View/Content-Containers">TileContainer</a> doesn't implement&nbsp;ITileControl and you need to pass the <strong>TileContainer.Info</strong> object to <strong>FrameHoverHelper</strong>'s&nbsp;constructor:<br>
<code lang="cs">new FrameHoverHelper(tileContainer1.Info as ITileControl)</code>
<code lang="vb">Dim helper As FrameHoverHelper = New FrameHoverHelper(TryCast(tileContainer1.Info, ITileControl))</code>
<br>Also, <strong>TileContainer</strong> requires some inner information to be initialized before we can work with it in the helper class. Thus, it is necessary to create the&nbsp;<strong>FrameHoverHelper</strong>&nbsp;instance when the form is shown or later. <strong>TileControl</strong> doesn't require it and you can&nbsp;create&nbsp;the&nbsp;<strong>FrameHoverHelper</strong>&nbsp;instance anywhere in your code.

<br/>


