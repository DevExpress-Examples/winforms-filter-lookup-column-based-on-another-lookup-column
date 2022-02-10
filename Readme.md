<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628737/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E898)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Lookup Editors for Windows Forms - How to filter a second Lookup column based on a first LookUp column's value within a Grid Control

In v16.1 and higher, a standalone Lookup editor allows you to automatically filter its popup data source based on the value of another standalone Lookup editor. See the following topic for more information: [Cascading Lookups](https://documentation.devexpress.com/WindowsForms/116018/Controls-and-Libraries/Editors-and-Simple-Controls/Lookup-Editors/Cascading-Lookups).

This example demonstrates how to filter a Lookup editor's data source based on another Lookup editor's value when the editors are embedded in cells of a container control (for instance, a [Grid Control](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl)). The code handles the [ShownEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.ShownEditor) event to accomplish this task.

<!-- default file list -->
## Files to Look At
* [MainForm.cs](./CS/DxSample/MainForm.cs) (VB: [MainForm.vb](./VB/DxSample/MainForm.vb))
<!-- default file list end -->

## Documentation 
- [Lookup Editors](https://docs.devexpress.com/WindowsForms/116008/controls-and-libraries/editors-and-simple-controls/lookup-editors)
- [Cascading Lookups](https://documentation.devexpress.com/WindowsForms/116018/Controls-and-Libraries/Editors-and-Simple-Controls/Lookup-Editors/Cascading-Lookups)
- [ColumnView.ShownEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.ShownEditor)

## See Also
- [DevExpress WinForms Troubleshooting - LookUp Editors](https://go.devexpress.com/CheatSheets_WinForms_Examples_T929986.aspx)
