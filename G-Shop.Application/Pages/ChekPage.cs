using G_Shop.Application.Reports;
using G_Shop.Application.Reports.SalesReportDataSetTableAdapters;
using Microsoft.Reporting.WinForms;

namespace G_Shop.Application.Pages;

public partial class ChekPage : UserControl
{
    public ChekPage()
    {
        InitializeComponent();
    }

    private void ChekPage_Load(object sender, EventArgs e)
    {
        reportViewer.LocalReport.ReportPath = "Reports/SalesReport.rdlc";

        SalesReportDataSet salesReportDataSet = new();

        SalesTableAdapter salesTableAdapter = new();
        salesTableAdapter.Fill(salesReportDataSet.Sales);

        reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataSourceValue: salesReportDataSet.Sales.AsEnumerable()));
        reportViewer.RefreshReport();
    }
}
