using G_Shop.Application.Reports;
using G_Shop.Application.Reports.SalesReportDataSetTableAdapters;
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;
using G_Shop.Database.DatabaseRepositories.Helpers;
using G_Shop.Database.Interfaces;
using G_Shop.Database;
using System.Data;

namespace G_Shop.Application.Pages;

public partial class ChekPage : UserControl
{
    private readonly IOperationsRepository _operationsRepository = RepositoryProvider.OperationsRepository;


    public ChekPage()
    {
        InitializeComponent();
    }

    private void buttonClearAll_Click(object sender, EventArgs e)
    {
        _operationsRepository.ClearDatabase();
        reportViewer.LocalReport.DataSources.Clear();
        reportViewer.RefreshReport();
    }

    private void buttonUpdateSale_Click(object sender, EventArgs e)
    {
        reportViewer.LocalReport.ReportPath = "Reports/SalesReport.rdlc";

        _operationsRepository.DisplayAllSales();

        SalesReportDataSet salesReportDataSet = new();

        SalesTableAdapter salesTableAdapter = new();
        salesTableAdapter.Fill(salesReportDataSet.Sales);

        reportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dataSourceValue: salesReportDataSet.Sales.AsEnumerable()));
        reportViewer.RefreshReport();
    }
}
