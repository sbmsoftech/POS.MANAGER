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

using POS_B_Layer;
using POS_DataLayer;
using POS_Store_6._0;

namespace POS_Store_6._0.Usercontrol
{
    /// <summary>
    /// Interaction logic for ReordrUserControl.xaml
    /// </summary>
    public partial class ItemCodeUserconrol : UserControl
    {
        BAL BusinessLayer = new BAL();
        DAL dataLayer = new DAL();
        
        public ItemCodeUserconrol()
        {
            InitializeComponent();
        }

        private void txtItemcode_SelectionChanged(object sender, RoutedEventArgs e)
        {
            var userControl = (ItemUserControl)Application.Current.MainWindow.FindName("ItemUser");
            //userControl.clearValues();
        }

        private void GetData_ItemCode()
        {
            try
            {
                if (BusinessLayer.checkValidationfor_ItemLookupCode(txtItemcode.Text))
                {

                    var userControl = (ItemUserControl)Application.Current.MainWindow.FindName("ItemUser");
                    var dataList = dataLayer.getData_useCode(txtItemcode.Text);

                    if (BusinessLayer.checkValidationfor_SupplierList(dataList[0].ID, dataList[0].SupplierID))
                    {
                        var SupplierList = dataLayer.getSupplierList_ItemlookupCode(dataList[0].ID, dataList[0].SupplierID);
                        userControl.txtMIN.Text = SupplierList[0].MinimumOrder.ToString();
                        userControl.txtMPQ.Text = SupplierList[0].MasterPackQuantity.ToString();
                        userControl.txtCasePrice.Text = (dataList[0].Cost * SupplierList[0].MasterPackQuantity).ToString();
                        userControl.txtReorder.Text = SupplierList[0].ReorderNumber;
                    }
                    else
                    {
                        userControl.txtMIN.Text = (0).ToString();
                        userControl.txtMPQ.Text = (0).ToString();
                        userControl.txtCasePrice.Text = (0).ToString();
                        userControl.txtReorder.Text = (0).ToString();
                    }


                    userControl.txtCost.Text = dataList[0].Cost.ToString();
                    userControl.txtDescription.Text = dataList[0].Description.ToString();
                    userControl.txtExtdescription.Text = dataList[0].ExtendedDescription.ToString();
                    userControl.txtPrice.Text = dataList[0].Price.ToString();
                    userControl.txtMSRP.Text = dataList[0].MSRP.ToString();

                    userControl.txtProfitMargin.Text = getProfitMargin(double.Parse(dataList[0].Cost.ToString()),
                        double.Parse(dataList[0].Price.ToString())).ToString() == "NaN" ? "0.00" : String.Format("{0:0.000}",
                        getProfitMargin(double.Parse(dataList[0].Cost.ToString()), double.Parse(dataList[0].Price.ToString()))) + "%";


                    userControl.txtOnHand.Text = dataList[0].Quantity.ToString();

                    userControl.txtRestocklevel.Text = dataList[0].RestockLevel.ToString();
                    userControl.txtRestockPoint.Text = dataList[0].ReorderPoint.ToString();
                    userControl.cmbDepartment.SelectedValue = dataList[0].DepartmentID;
                    userControl.GetCategory(dataList[0].DepartmentID);
                    userControl.cmbCategory.SelectedValue = dataList[0].CategoryID;
                    userControl.cmbSupplier.SelectedValue = dataList[0].SupplierID;



                    if (dataList[0].SaleType == 0)
                    {
                        userControl.ckOnSale.IsChecked = false;
                    }
                    else
                    {
                        userControl.ckOnSale.IsChecked = true;
                        double salePrice = double.Parse(dataList[0].SalePrice.ToString());
                        userControl.txtOnsalePrice.Text = salePrice.ToString();
                        double OnsalePer = Math.Round((salePrice * 100) / double.Parse(dataList[0].Price.ToString()), 0);

                        userControl.txtOnsalePer.Text = (100 - OnsalePer).ToString();

                    }

                    userControl.ckWebItem.IsChecked = dataList[0].WebItem;
                    userControl.ckPriceatPOS.IsChecked = dataList[0].PriceMustBeEntered;

                    userControl.cmbtax.SelectedValue = dataList[0].TaxID;

                    userControl.dtstartDate.SelectedDate = dataList[0].SaleStartDate;
                    userControl.dtEndDate.SelectedDate = dataList[0].SaleEndDate;
                    userControl.txtExtdescription.Text = dataList[0].ExtendedDescription;
                    userControl.txtsunDes1.Text = dataList[0].SubDescription1;
                    userControl.txtsubDes2.Text = dataList[0].SubDescription2;
                    userControl.txtsubdes3.Text = dataList[0].SubDescription3;

                    txtItemcode.SelectAll();

                    userControl.Cost = 0;

                    userControl.Price = 0;
                    userControl.ProfitMargin = 0;
                    userControl.MPQ = 0;
                    userControl.CasePrice = 0;

                    userControl.d_Cost = 0;
                    userControl.d_Price = 0;
                    userControl.d_ProfitMargin = 0;
                    userControl.d_MPQ = 0;
                    userControl.d_CasePrice = 0;

                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private double getProfitMargin(double Cost,double Price)
        {

           double ProfitMargin = ((Price - Cost) * 100) / Price;
           return ProfitMargin;
                       
        }
        private void txtItemcode_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key==Key.Enter)
            {
                GetData_ItemCode();
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userControl = (ItemUserControl)Application.Current.MainWindow.FindName("ItemUser");
                userControl.clearValues();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
