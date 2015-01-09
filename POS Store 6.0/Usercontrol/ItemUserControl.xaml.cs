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
using POS_DataLayer;

namespace POS_Store_6._0.Usercontrol
{
    /// <summary>
    /// Interaction logic for ItemUserControl.xaml
    /// </summary>
    public partial class ItemUserControl : UserControl
    {
        DAL datalayer = new DAL();
        public double Cost;
        public double Price;
        public double ProfitMargin;
        public double MPQ;
        public double CasePrice;

        public double d_Cost;
        public double d_Price;
        public double d_ProfitMargin;
        public double d_MPQ;
        public double d_CasePrice;
        public ItemUserControl()
        {            
            InitializeComponent();
            getDepartmentList();
            Getsupplire();
            Gettax();
            GetAlias();
        }
        public string reorderno
        {
            get { return this.txtReorder.Text; }
            set { this.txtReorder.Text = value; }
        }
        public string description
        {
            get { return this.txtDescription.Text; }
            set { this.txtDescription.Text = value; }
        }
        public object department
        {
            get { return this.cmbDepartment.SelectedValue; }
            set { this.cmbDepartment.SelectedValue = value; }
        }
        

        public void getDepartmentList()
        {
            var list = datalayer.getdepartment();
            cmbDepartment.ItemsSource = list;
            cmbDepartment.DisplayMemberPath = "Name";
            cmbDepartment.SelectedValuePath = "ID";
            cmbDepartment.SelectedIndex = 0;
        }
        private void cmbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbDepartment.SelectedValue != null)
            {
                GetCategory(int.Parse(cmbDepartment.SelectedValue.ToString()));
            }
        }
        public void GetCategory(int DeparmentID)
        {
            cmbCategory.ItemsSource = datalayer.Getcategory(DeparmentID);
            cmbCategory.DisplayMemberPath = "Name";
            cmbCategory.SelectedValuePath = "ID";
            cmbCategory.SelectedIndex = 0;
                
        }
        public void Getsupplire()
        {
            cmbSupplier.ItemsSource = datalayer.Getsupplires();
            cmbSupplier.DisplayMemberPath = "SupplierName";
            cmbSupplier.SelectedValuePath = "ID";
            cmbSupplier.SelectedIndex = 0;
        }
        public void Gettax()
        {
            cmbtax.ItemsSource = datalayer.Gettax();
            cmbtax.DisplayMemberPath = "Description";
            cmbtax.SelectedValuePath = "ID";
            cmbtax.SelectedIndex = 0;
        }
        public void GetAlias()
        {
            cmbAlias.ItemsSource = datalayer.GetAliases();
            cmbAlias.DisplayMemberPath = "Alias";
            cmbAlias.SelectedValuePath = "ID";
            cmbAlias.SelectedIndex = 0;
        }
        public void clearValues()
        {
            foreach(UIElement ele in Root.Children)
            {
                var userControlItemcode = (ItemCodeUserconrol)Application.Current.MainWindow.FindName("ItemCode");
                if (userControlItemcode.txtItemcode.Text.Length > 0)
                {
                    if (ele.GetType() == typeof(TextBox))
                    {
                        TextBox tx = (TextBox)ele;
                        tx.Text = string.Empty;
                    }
                    else if(ele.GetType()==typeof(ComboBox))
                    {
                        ComboBox com = (ComboBox)ele;
                        com.SelectedIndex = 0;
                    }
                }
            }
        }

        private void Mathod_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                if(txtCost.Text!=string.Empty)
                {
                    Cost = double.Parse(txtCost.Text);
                }                

                if(txtPrice.Text!=string.Empty)
                {
                    Price = double.Parse(txtPrice.Text);
                }                

                         
                if(txtMPQ.Text!=string.Empty)
                {
                    MPQ = double.Parse(txtMPQ.Text);
                }

                if(txtProfitMargin.Text!=string.Empty)
                {
                    ProfitMargin = double.Parse(txtProfitMargin.Text.Replace("%", ""));
                }

                if (txtCasePrice.Text != string.Empty)
                {
                    CasePrice = double.Parse(txtCasePrice.Text);
                }
               

                if (d_Cost != Cost)
                {
                    if(MPQ==0)
                    {
                        txtMPQ.Text = MPQ.ToString();
                        txtCasePrice.Text = (0).ToString();
                    }
                    else
                    {
                        txtCasePrice.Text = (Cost * MPQ).ToString();
                    }

                    if(Price==0)
                    {
                        txtProfitMargin.Text = (0).ToString();
                    }
                    else
                    {
                        ProfitMargin = ((Price - Cost) * 100) / Price;
                        txtProfitMargin.Text = ProfitMargin.ToString() == "NaN" ? "0.00" : String.Format("{0:0.000}", ProfitMargin) + "%";
                    }
                }
                 if(d_Price!=Price)
                {
                    if (Price == 0)
                    {
                        txtProfitMargin.Text = (0).ToString();
                    }
                    else
                    {
                        ProfitMargin = ((Price - Cost) * 100) / Price;
                        txtProfitMargin.Text = ProfitMargin.ToString() == "NaN" ? "0.00" : String.Format("{0:0.000}", ProfitMargin) + "%";
                        ProfitMargin = double.Parse(txtProfitMargin.Text.Replace("%", ""));
                    }
                }
                 if(d_ProfitMargin!=ProfitMargin)
                {
                    Price = Convert.ToDouble(txtCost.Text) / ((100 - ProfitMargin) / 100);
                    txtPrice.Text = Price.ToString() == "NaN" ? "0.00" : String.Format("{0:0.00}", Price);
                    txtProfitMargin.Text = ProfitMargin.ToString() == "NaN" ? "0.00" : String.Format("{0:0.000}", ProfitMargin) + "%";
                    
                }
                 if(d_MPQ!=MPQ)
                {
                    CasePrice = Cost * MPQ;
                    txtCasePrice.Text = CasePrice.ToString() == "NaN" ? "0.00" : String.Format("{0:0.00}", CasePrice);
                }
                if(d_CasePrice!=CasePrice)
                {
                    if (MPQ == 0)
                    {
                        txtMPQ.Text = MPQ.ToString() == "NaN" ? "0.00" : String.Format("{0:0.00}", MPQ);
                        txtCasePrice.Text = MPQ.ToString() == "NaN" ? "0.00" : String.Format("{0:0.00}", MPQ);
                    }
                    else
                    {
                        Cost = CasePrice / MPQ;
                        txtCost.Text = Cost.ToString() == "NaN" ? "0.00" : String.Format("{0:0.00}", Cost);

                        if (Price == 0)
                        {
                            txtProfitMargin.Text = (0).ToString();
                        }
                        else
                        {
                            ProfitMargin = ((Price - Cost) * 100) / Price;
                            txtProfitMargin.Text = ProfitMargin.ToString() == "NaN" ? "0.00" : String.Format("{0:0.000}", ProfitMargin) + "%";
                            ProfitMargin = double.Parse(txtProfitMargin.Text.Replace("%", ""));
                        }
                    }
                }

                d_Cost = Cost;
                d_Price = Price;
                d_ProfitMargin = ProfitMargin;
                d_MPQ = MPQ;
                d_CasePrice = CasePrice;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Method_GotFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                TextBox tx = sender as TextBox;
                tx.SelectAll();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OnsalePrice_LostFocus(object sender, RoutedEventArgs e)
        {
            try
            {
                double saleAmount = 0;
                double SalePer = 0;
                double t_amount = 0;
                TextBox tx = sender as TextBox;
                if (tx.Name == "txtOnsalePrice")
                {
                    if (tx.Text != string.Empty && txtPrice.Text != string.Empty)
                    {
                        saleAmount = double.Parse(tx.Text);
                        t_amount = double.Parse(txtPrice.Text);
                        SalePer = ((saleAmount * 100) / t_amount);
                        txtOnsalePer.Text = Math.Round((100 - SalePer),0).ToString();
                    }
                }
                else
                {
                    if (tx.Text != string.Empty && txtPrice.Text != string.Empty)
                    {
                        SalePer = double.Parse(tx.Text);
                        t_amount = double.Parse(txtPrice.Text);
                        saleAmount = (SalePer / 100) * t_amount;
                        txtOnsalePrice.Text = (t_amount - saleAmount).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

    }
}
