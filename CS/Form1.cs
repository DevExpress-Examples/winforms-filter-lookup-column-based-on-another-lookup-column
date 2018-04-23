using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        void FillDataSet() {
            dataSet11.Countries.AddCountriesRow("USA", "1", 1);
            dataSet11.Countries.AddCountriesRow("Germany", "49", 2);
            dataSet11.Countries.AddCountriesRow("France", "33", 3);
            dataSet11.Countries.AddCountriesRow("Great Britain", "44", 4);
            dataSet11.Countries.AddCountriesRow("Italy", "39", 5);
            dataSet11.Countries.AddCountriesRow("Russia", "7", 6);

            dataSet11.Cities.AddCitiesRow("Washington", "202", "1", 1);
            dataSet11.Cities.AddCitiesRow("Los Angeles", "213", "1", 2);
            dataSet11.Cities.AddCitiesRow("San Francisco", "415", "1", 3);
            dataSet11.Cities.AddCitiesRow("New-York", "718", "1", 4);
            dataSet11.Cities.AddCitiesRow("Berlin", "30", "49", 5);
            dataSet11.Cities.AddCitiesRow("Bonn", "228", "49", 6);
            dataSet11.Cities.AddCitiesRow("Munhen", "89", "49", 7);
            dataSet11.Cities.AddCitiesRow("Paris", "1", "33", 8);
            dataSet11.Cities.AddCitiesRow("Lion", "19", "33", 9);
            dataSet11.Cities.AddCitiesRow("London", "1274", "44", 10);
            dataSet11.Cities.AddCitiesRow("Glasgo", "141", "44", 11);
            dataSet11.Cities.AddCitiesRow("Rome", "6", "39", 12);
            dataSet11.Cities.AddCitiesRow("Milan", "2", "39", 13);
            dataSet11.Cities.AddCitiesRow("Moscow", "495", "7", 14);

            dataSet11.Phones.AddPhonesRow(1, "39", "6", "xxx");
            dataSet11.Phones.AddPhonesRow(2, "33", "19", "yyy");
            dataSet11.Phones.AddPhonesRow(3, "1", "202", "zzz");
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            FillDataSet();
        }

        private DataView clone = null;

        private void gridView1_ShownEditor(object sender, System.EventArgs e) {
            DevExpress.XtraGrid.Views.Grid.GridView view;
            view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if(view.FocusedColumn.FieldName == "CityCode" && view.ActiveEditor is DevExpress.XtraEditors.LookUpEdit) {
                DevExpress.XtraEditors.LookUpEdit edit;
                edit = (DevExpress.XtraEditors.LookUpEdit)view.ActiveEditor;

                BindingSource bs = (BindingSource)edit.Properties.DataSource;
                DataTable table = ((DataSet)bs.DataSource).Tables[bs.DataMember];
                clone = new DataView(table);
                DataRow row = view.GetDataRow(view.FocusedRowHandle);
                clone.RowFilter = "[CountryCode] = " + row["CountryCode"].ToString();
                edit.Properties.DataSource = new BindingSource(clone, "");
            }
        }

        private void gridView1_HiddenEditor(object sender, System.EventArgs e) {
            if(clone != null) {
                clone.Dispose();
                clone = null;
            }
        }

        private void repositoryItemLookUpEdit1_EditValueChanged(object sender, System.EventArgs e) {
            DevExpress.XtraGrid.Views.Grid.GridView view = gridView1;
            view.SetRowCellValue(view.FocusedRowHandle, "CityCode", DBNull.Value);
        }
    }
}