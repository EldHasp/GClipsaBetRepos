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
using System.Xml.Linq;

namespace GClipsaWPF
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            /// Загрузка словаря соответствия полученных названий 
            /// рисунков их названиям в ресурсах
            //Dictionary<string, string> names = new Dictionary<string, string>()
            //    {
            //        {"nophoto","Image/nophoto.png" }
            //    };

            // Загрузка словаря из xml файла
            Dictionary<string, string> names = XDocument
                 .Load("NameToImage.xml")
                 .Root
                 .Elements("item")
                 .ToDictionary(item => item.Attribute("name").Value, item => item.Attribute("image").Value);
            ((DictionaryKeyToValueConverter)Resources["DictionaryKeyToValueConverter"]).SetDictionary(names);

            ParseData model = new ParseData("Data for connection");
            ViewModel viewModel = new ViewModel(model);

            new MainWindow() { DataContext = viewModel }
             .Show();
        }

    }
}
