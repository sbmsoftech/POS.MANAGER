using POS_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.EntityClient;
using System.Diagnostics;
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
using System.Windows.Shapes;


namespace POS_Store_6._0
{
    /// <summary>
    /// Interaction logic for DatabaseSetting.xaml
    /// </summary>
    public partial class DatabaseSetting : Window
    {
        public DatabaseSetting()
        {
            InitializeComponent();
            try
            {
                if (ConString.docallsetting())
                {

                    txtDatabaseName.Text = ConString.DB_Name;
                    pbPassword.Password = ConString.DB_Password;
                    txtServerName.Text = ConString.DB_Server;
                    txtUserName.Text = ConString.DB_User;

                }
                else
                {
                    txtDatabaseName.Text = "store";
                    pbPassword.Password = "";
                    txtServerName.Text = @".\sqlexpress";
                    txtUserName.Text = "sa";
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void btnsave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                bool state = false;
                string errorText = "";
                int x = 0;
                if (!(txtServerName.Text.Length > 0))
                {
                    errorText += "ServerName is required" + "\n";
                    state = true;
                }
                if (!(txtDatabaseName.Text.Length > 0))
                {
                    errorText += "DataBase Name is required" + "\n";
                    state = true;
                }

                if (!(txtUserName.Text.Length > 0))
                {
                    errorText += "UserName is required";
                    state = true;
                }

                if (state == false)
                {
                    try
                    {
                        settings stt = new settings();
                        stt.DB_Server = txtServerName.Text;
                        stt.DB_Name = txtDatabaseName.Text;
                        stt.DB_User = txtUserName.Text;
                        stt.DB_Password = pbPassword.Password;
                        stt.DB_Provider = "System.Data.SqlClient";


                        ConString.docreatesetting(stt);

                        if (MessageBox.Show("Successfully Saved." + "\r\n" + " Press OK to restart the application.", "Info", MessageBoxButton.OKCancel, MessageBoxImage.Information) == MessageBoxResult.OK)
                        {
                            Process.Start(Application.ResourceAssembly.Location);

                            System.Windows.Application.Current.Shutdown();
                        }
                        else
                        {

                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                else
                {
                    MessageBox.Show(errorText, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btntest_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.Cursor = Cursors.Wait;
                bool state = false;
                string errorText = "";
                //  int x = 0;
                if (!(txtServerName.Text.Length > 0))
                {
                    errorText += "ServerName is required" + "\n";
                    state = true;
                }
                if (!(txtDatabaseName.Text.Length > 0))
                {
                    errorText += "DataBase Name is required" + "\n";
                    state = true;
                }

                if (!(txtUserName.Text.Length > 0))
                {
                    errorText += "UserName is required";
                    state = true;
                }

                if (state == true)
                {


                    MessageBox.Show(errorText, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

                }
                else
                {

                    string str = "Server='" + txtServerName.Text + "';";
                    str += "Database='" + txtDatabaseName.Text + "';";
                    str += "User Id='" + txtUserName.Text + "';";
                    str += "Password='" + pbPassword.Password + "';";

                    EntityConnectionStringBuilder stb = new EntityConnectionStringBuilder();
                    stb.Metadata = "res://*/StoreEntity.csdl|res://*/StoreEntity.ssdl|res://*/StoreEntity.msl";
                    stb.Provider = "System.Data.SqlClient";
                    stb.ProviderConnectionString = str + "MultipleActiveResultSets=True;App=EntityFramework";
                    using (var db = new storeEntities(stb.ToString()))
                    {
                        db.Database.Connection.Open();
                        if (db.Database.Connection.State == ConnectionState.Open)
                        {
                            MessageBox.Show("Successfull.");
                            db.Database.Connection.Close();
                        }
                        else
                        {
                            MessageBox.Show("Connetion not established. Check configuration.");
                        }
                    }

                }

                this.Cursor = Cursors.Arrow;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
