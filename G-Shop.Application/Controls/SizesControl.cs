using G_Shop.Database.Repositories;
using G_Shop.Domain.Warehouses;

namespace G_Shop.Application.Controls;

public partial class SizesControl : UserControl
{
    private readonly WarehouseRepository _warehouseRepository = new ();
    private Warehouse _warehouse = new (0,0,0,0,0,0,0,0); // Склад = один товар
    private Action<int>? showSizesCountCallback = null;

    public SizesControl()
    {
        InitializeComponent();
    }

    internal void DisplaySizes(int productId, Action<int> showSizesCount)
    {
        _warehouse = _warehouseRepository.GetWarehouseByProductId(productId);
        showSizesCountCallback = showSizesCount;

        SwitchCheckedState();
    }

    private void SwitchCheckedState()
    {
        radioButtonS.Checked = true;
        radioButtonXS.Checked = true;
    }

    private void RadioButtonXS_CheckedChanged(object sender, EventArgs e)
    {
        showSizesCountCallback?.Invoke(_warehouse.Xs);
    }

    private void RadioButtonS_CheckedChanged(object sender, EventArgs e)
    {
        showSizesCountCallback?.Invoke(_warehouse.S);
    }

    private void RadioButtonM_CheckedChanged(object sender, EventArgs e)
    {
        showSizesCountCallback?.Invoke(_warehouse.M);
    }

    private void RadioButtonL_CheckedChanged(object sender, EventArgs e)
    {
        showSizesCountCallback?.Invoke(_warehouse.L);
    }

    private void RadioButtonXL_CheckedChanged(object sender, EventArgs e)
    {
        showSizesCountCallback?.Invoke(_warehouse.Xl);
    }

    private void RadioButtonXXL_CheckedChanged(object sender, EventArgs e)
    {
        showSizesCountCallback?.Invoke(_warehouse.Xxl);
    }

    private void RadioButtonXXXL_CheckedChanged(object sender, EventArgs e)
    {
        showSizesCountCallback?.Invoke(_warehouse.Xxxl);
    }
}