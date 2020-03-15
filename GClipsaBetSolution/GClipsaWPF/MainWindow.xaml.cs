using Common;
using System.Collections.Generic;
using System.Windows;

namespace GClipsaWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            /// Загрузка словаря соответствия полученных названий 
            /// рисунков их названиям в ресурсах
            Dictionary<string, string> names = new Dictionary<string, string>()
                {
                    {"nophoto","Image/nophoto.png" }
                };
            ((DictionaryKeyToValueConverter)Resources["DictionaryKeyToValueConverter"]).SetDictionary(names);

        }

    }

}
