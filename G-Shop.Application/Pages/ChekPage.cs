using G_Shop.Application.Reports;
using G_Shop.Application.Reports.SalesReportDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using G_Shop.Database.DatabaseRepositories.Helpers;
using G_Shop.Database.Interfaces;
using G_Shop.Database;

namespace G_Shop.Application.Pages;

public partial class ChekPage : UserControl
{
    private readonly IOperationsRepository _operationsRepository = RepositoryProvider.OperationsRepository;

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

    private void buttonClearAll_Click(object sender, EventArgs e)
    {
        _operationsRepository.ClearDatabase();
        reportViewer.RefreshReport();
    }
}
