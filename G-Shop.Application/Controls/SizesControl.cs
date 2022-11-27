using G_Shop.Database;
using G_Shop.Database.Interfaces;
using G_Shop.Domain.Warehouses;

namespace G_Shop.Application.Controls;

public partial class SizesControl : UserControl
{
    private readonly IWarehouseRepository _warehouseRepository = RepositoryProvider.WarehouseRepository;
    private Warehouse _warehouse = new(0, 0, 0, 0, 0, 0, 0, 0); // Склад = один товар
    private Action<int>? showSizesCountCallback = null;


    public SizesControl()
    {
        InitializeComponent();
    }

    internal void SetCountForSelectedSize(int count)
    {
        showSizesCountCallback?.Invoke(count);

        if (radioButtonS.Checked)
        {
            _warehouse.S = count;
            return;
        }

        if (radioButtonL.Checked)
        {
            _warehouse.L = count;
            return;
        }

        if (radioButtonXL.Checked)
        {
            _warehouse.XL = count;
            return;
        }

        if (radioButtonM.Checked)
        {
            _warehouse.M = count;
            return;
        }

        if (radioButtonXS.Checked)
        {
            _warehouse.XS = count;
            return;
        }

        if (radioButtonXXL.Checked)
        {
            _warehouse.XXL = count;
            return;
        }

        if (radioButtonXXXL.Checked)
        {
            _warehouse.XXXL = count;
            return;
        }
    }

    internal void DisplaySizes(int productId, Action<int> showSizesCount)
    {
        Warehouse? warehouseFromDatabase = _warehouseRepository.GetWarehouseByProductId(productId);

        if (warehouseFromDatabase is not null)
        {
            _warehouse = warehouseFromDatabase;
        }

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
        showSizesCountCallback?.Invoke(_warehouse.XS);
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
        showSizesCountCallback?.Invoke(_warehouse.XL);
    }

    private void RadioButtonXXL_CheckedChanged(object sender, EventArgs e)
    {
        showSizesCountCallback?.Invoke(_warehouse.XXL);
    }

    private void RadioButtonXXXL_CheckedChanged(object sender, EventArgs e)
    {
        showSizesCountCallback?.Invoke(_warehouse.XXXL);
    }

    internal void SaveChangedToDatabase()
    {
        _warehouseRepository.UpdateWarehouse(_warehouse);
    }

    internal void AddNewWarehouseToDatabase(int addedProductId)
    {
        _warehouse.ProductId = addedProductId;
        _warehouseRepository.AddNewWarehouse(_warehouse);
    }

    public int GetCurrentSizeCount()
    {
        if (radioButtonL.Checked == true)
        {
            return _warehouse.L;
        }
        if (radioButtonXS.Checked == true)
        {
            return _warehouse.XS;
        }
        if (radioButtonS.Checked == true)
        {
            return _warehouse.S;
        }
        if (radioButtonM.Checked == true)
        {
            return _warehouse.M;
        }
        if (radioButtonXL.Checked == true)
        {
            return _warehouse.XL;
        }
        if (radioButtonXXL.Checked == true)
        {
            return _warehouse.XXL;
        }
        if (radioButtonXXXL.Checked == true)
        {
            return _warehouse.XXXL;
        }

        throw new NotImplementedException("Selected radiobutton not found");
    }
}