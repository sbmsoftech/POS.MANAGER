using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using POS_Store_6._0.Usercontrol;
using POS_DataLayer;
using POS_B_Layer;
using System.Xml;

namespace POS_Store_6._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string value = "0";
        BAL b_layer = new BAL();
        public MainWindow()
        {
            InitializeComponent();            
        }
       
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var ItemlookupCodeuserControl = (ItemCodeUserconrol)Application.Current.MainWindow.FindName("ItemCode");
                var ItemsuserControl = (ItemUserControl)Application.Current.MainWindow.FindName("ItemUser");

                SupplierList sup_list = new SupplierList();
                sup_list.Cost =StringTodecimal(ItemsuserControl.txtCost.Text);
                sup_list.ReorderNumber = ItemsuserControl.txtReorder.Text;
                sup_list.MasterPackQuantity = StringToint(ItemsuserControl.txtMPQ.Text);
                sup_list.MinimumOrder = StringTofloat(ItemsuserControl.txtMIN.Text);
                sup_list.SupplierID = StringToint(ItemsuserControl.cmbSupplier.SelectedValue.ToString());

                Item itm = new Item();


                itm.Cost = StringTodecimal(ItemsuserControl.txtCost.Text);

                itm.I_ItemLookupCode = ItemlookupCodeuserControl.txtItemcode.Text;
                itm.I_Description = ItemsuserControl.txtDescription.Text;
                itm.I_DepartmentID = StringToint(ItemsuserControl.cmbDepartment.SelectedValue.ToString());
                itm.CategoryID = StringToint(ItemsuserControl.cmbCategory.SelectedValue.ToString());
                itm.I_TaxID = StringToint(ItemsuserControl.cmbtax.SelectedValue.ToString());
                itm.I_Cost = StringTodecimal(ItemsuserControl.txtCost.Text);
                itm.I_ExtendedDescription = ItemsuserControl.txtExtdescription.Text;
                itm.I_SubDescription1 = ItemsuserControl.txtsunDes1.Text;
                itm.I_SubDescription2 = ItemsuserControl.txtsubDes2.Text;
                itm.I_SubDescription3 = ItemsuserControl.txtsubdes3.Text;
                itm.I_Quantity = StringTodouble(ItemsuserControl.txtOnHand.Text);
                itm.I_ReorderPoint = StringTodouble(ItemsuserControl.txtRestockPoint.Text);
                itm.I_RestockLevel = StringTodouble(ItemsuserControl.txtRestocklevel.Text);
                itm.I_SupplierID = StringToint(ItemsuserControl.cmbSupplier.SelectedValue.ToString());
                itm.I_Price = StringTodecimal(ItemsuserControl.txtPrice.Text);
                itm.I_SalePrice = StringTodecimal(ItemsuserControl.txtOnsalePrice.Text);
                itm.I_SaleStartDate = ItemsuserControl.dtstartDate.SelectedDate;
                itm.I_SaleEndDate = ItemsuserControl.dtEndDate.SelectedDate;
                itm.I_SaleType = booltoInt(ItemsuserControl.ckOnSale.IsChecked);
                itm.I_MSRP = StringTodecimal(ItemsuserControl.txtMSRP.Text);
                itm.I_PriceMustBeEntered = Convert.ToBoolean(ItemsuserControl.ckPriceatPOS.IsChecked);
                itm.I_WebItem = Convert.ToBoolean(ItemsuserControl.ckWebItem.IsChecked);

                MessageBox.Show(b_layer.addOrUpdateItems(itm,sup_list));

                ItemlookupCodeuserControl.txtItemcode.Focus();
                ItemlookupCodeuserControl.txtItemcode.SelectAll();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        public double StringTodouble(string value)
        {
            if(value=="" || value==null)
            {
                return 0;
            }
            else
            {
                return Convert.ToDouble(value);
            }
        }
        public decimal StringTodecimal(string value)
        {
            if (value == "" || value == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToDecimal(value);
            }
        }
        public int StringToint(string value)
        {
            if (value == "" || value == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(value);
            }
        }
        public float StringTofloat(string value)
        {
            if (value == "" || value == null)
            {
                return 0;
            }
            else
            {
                return float.Parse(value);
            }
        }

        public DateTime? StringToDatetime(DateTime value)
        {
            if (value == null)
            {
                return DateTime.Now;
            }
            else
                return  value;
            
        }
    }
}
