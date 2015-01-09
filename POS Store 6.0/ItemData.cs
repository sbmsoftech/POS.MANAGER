using POS_Store_6._0.Usercontrol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace POS_DataLayer
{
    public class ItemData
    {
        public decimal itemlookupCode { get; set; }
        public ItemData()
        {
            Item itm = new Item();
            var ItemlookupCodeuserControl = (ItemCodeUserconrol)Application.Current.MainWindow.FindName("ItemCode");
            var ItemsuserControl = (ItemUserControl)Application.Current.MainWindow.FindName("ItemUser");

            itm.Cost = decimal.Parse(ItemsuserControl.txtCost.Text);

            itm.I_ItemLookupCode = ItemlookupCodeuserControl.txtItemcode.Text;
            itm.I_Description = ItemsuserControl.txtDescription.Text;
            itm.I_DepartmentID = int.Parse(ItemsuserControl.cmbDepartment.SelectedValue.ToString());
            itm.I_TaxID = int.Parse(ItemsuserControl.cmbtax.SelectedValue.ToString());
            itm.I_Cost = decimal.Parse(ItemsuserControl.txtCost.Text);
            itm.I_ExtendedDescription = ItemsuserControl.txtExtdescription.Text;
            itm.I_SubDescription1 = ItemsuserControl.txtsunDes1.Text;
            itm.I_SubDescription2 = ItemsuserControl.txtsubDes2.Text;
            itm.I_SubDescription3 = ItemsuserControl.txtsubdes3.Text;
            itm.I_Quantity = double.Parse(ItemsuserControl.txtOnHand.Text);
            itm.I_ReorderPoint = double.Parse(ItemsuserControl.txtRestockPoint.Text);
            itm.I_RestockLevel = double.Parse(ItemsuserControl.txtRestocklevel.Text);
            itm.I_SupplierID = int.Parse(ItemsuserControl.cmbSupplier.SelectedValue.ToString());
            itm.I_Price = decimal.Parse(ItemsuserControl.txtPrice.Text);
            itm.I_SalePrice = decimal.Parse(ItemsuserControl.txtOnsalePrice.Text);
            itm.I_SaleStartDate = ItemsuserControl.dtstartDate.SelectedDate;
            itm.I_SaleEndDate = ItemsuserControl.dtEndDate.SelectedDate;
            itm.I_SaleType = booltoInt(ItemsuserControl.ckOnSale.IsChecked);
            itm.I_MSRP = decimal.Parse(ItemsuserControl.txtMSRP.Text);
            itm.I_PriceMustBeEntered = Convert.ToBoolean(ItemsuserControl.ckPriceatPOS.IsChecked);
            itm.I_WebItem = Convert.ToBoolean(ItemsuserControl.ckWebItem.IsChecked);
        }
        public int booltoInt(object onsale)
        {
            if (Convert.ToBoolean(onsale) == true)
            {
                return 1;
            }
            else
                return 0;
        }

    }

}
