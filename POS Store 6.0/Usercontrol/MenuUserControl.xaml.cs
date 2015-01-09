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
using POS_Store_6;

namespace POS_Store_6._0.Usercontrol
{
    /// <summary>
    /// Interaction logic for MenuUserControl.xaml
    /// </summary>
    public partial class MenuUserControl : UserControl
    {
        public MenuUserControl()
        {
            InitializeComponent();
        }

        private void setdedaultvaluenewItem_Click(object sender, RoutedEventArgs e)
        {
            newitemrDefaultvalue Object = new newitemrDefaultvalue();
            Object.ShowDialog();
        }

        private void setExistingDefaultCValue_Click(object sender, RoutedEventArgs e)
        {
            ExistingitemrDefaultvalue Object = new ExistingitemrDefaultvalue();
            Object.ShowDialog();
        }

        private void hideUnhideItemdetail_Click(object sender, RoutedEventArgs e)
        {
            HideunhideItemDetail Object = new HideunhideItemDetail();
            Object.ShowDialog();
        }

        private void Wizards_Click(object sender, RoutedEventArgs e)
        {
            ItemWizard Object = new ItemWizard();
            Object.ShowDialog();
        }

        private void labelandPrinterSetting_Click(object sender, RoutedEventArgs e)
        {
            PrintLabel Object = new PrintLabel();
            Object.ShowDialog();
        }

        private void PurchaseOrderMenu_Click(object sender, RoutedEventArgs e)
        {
            PurchaseOrderForm Object = new PurchaseOrderForm();
            Object.ShowDialog();
        }

        private void smtpsetting_Click(object sender, RoutedEventArgs e)
        {
            SMTPemailsetting Object = new SMTPemailsetting();
            Object.ShowDialog();
        }

        private void databasesetting_Click(object sender, RoutedEventArgs e)
        {
            DatabaseSetting Object = new DatabaseSetting();
            Object.ShowDialog();
        }

        private void Suggested_Quantity_Click(object sender, RoutedEventArgs e)
        {
            Suggested_Quantity Object = new Suggested_Quantity();
            Object.ShowDialog();
        }
    }
}
