using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using app_wpf.View;
using app_wpf.Views;

namespace app_wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            //    var loginView = new LoginView();
            //    loginView.Show();
            //    loginView.IsVisibleChanged += (s, ev) =>
            //    {
            //        if (loginView.IsVisible == false && loginView.IsLoaded)
            //        {
            var mainView = new MainView();
                    mainView.Show();
                    //loginView.Close();
        //        }
        //    };
        }
    }
}
