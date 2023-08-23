<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128628737/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E898)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Lookup Editor - How to filter a Lookup column based on the value of another Lookup column in a Grid Control

In v16.1+, a standalone WinForms Lookup editor allows you to automatically filter its popup data source based on the value of another standalone Lookup editor. Read the following help topic for more information and examples: [Cascading Lookups](https://documentation.devexpress.com/WindowsForms/116018/Controls-and-Libraries/Editors-and-Simple-Controls/Lookup-Editors/Cascading-Lookups).

This example demonstrates how to filter a Lookup editor's data source based on the value of another Lookup editor when both editors are used as cell editors in the [Grid Control](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.GridControl). The example handles the [ShownEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.ShownEditor) event to implement the required behavior.

```cs
private void GridView_ShownEditor(object sender, EventArgs e) {
    ColumnView view = (ColumnView)sender;
    if (view.FocusedColumn.FieldName == "CityCode") {
        LookUpEdit editor = (LookUpEdit)view.ActiveEditor;
        string countryCode = Convert.ToString(view.GetFocusedRowCellValue("CountryCode"));
        editor.Properties.DataSource = DataContext.GetCitiesByCountryCode(countryCode);
    }
}
```

<!-- default file list -->
## Files to Review
* [MainForm.cs](./CS/DxSample/MainForm.cs) (VB: [MainForm.vb](./VB/DxSample/MainForm.vb))
<!-- default file list end -->

## Documentation 
- [Lookup Editors](https://docs.devexpress.com/WindowsForms/116008/controls-and-libraries/editors-and-simple-controls/lookup-editors)
- [Cascading Lookups](https://documentation.devexpress.com/WindowsForms/116018/Controls-and-Libraries/Editors-and-Simple-Controls/Lookup-Editors/Cascading-Lookups)
- [ColumnView.ShownEditor](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.ShownEditor)

## See Also
- [DevExpress WinForms Troubleshooting - LookUp Editors](https://go.devexpress.com/CheatSheets_WinForms_Examples_T929986.aspx)
