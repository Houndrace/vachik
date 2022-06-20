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

namespace n7_ConvertorAndElectricity {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void Converter_Click(object sender, RoutedEventArgs e) {
            Converter convertor = new Converter();
            convertor.Show();
        }
        private void Electricity_Click(object sender, RoutedEventArgs e) {
            Electricity electricity = new Electricity();
            electricity.Show();
        }
        private void btnQuit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }
    }
}
