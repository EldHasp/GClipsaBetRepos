using Common;
using GClipsaBetModel;
using GClipsaBetViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GClipsaWPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

            Startup += App_Startup;

        }

        private void App_Startup(object sender, StartupEventArgs e)
        {
            /// Загрузка словаря соответствия полученных названий 
            /// рисунков их названиям в ресурсах
            Dictionary<string, string> names = new Dictionary<string, string>()
                {
                    {"nophoto","Image/nophoto.png" }
                };
            ((DictionaryKeyToValueConverter)Resources["DictionaryKeyToValueConverter"]).SetDictionary(names);

            ParseData model = new ParseData("Data for connection");
            ViewModel viewModel = new ViewModel(model);

            new MainWindow() { DataContext = viewModel }
             .Show();
        }

    }
}
