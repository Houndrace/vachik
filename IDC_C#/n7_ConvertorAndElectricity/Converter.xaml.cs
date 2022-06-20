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
using System.Windows.Shapes;

namespace n7_ConvertorAndElectricity {
    /// <summary>
    /// Interaction logic for Converter.xaml
    /// </summary>
    public partial class Converter : Window {
        public Converter() {
            InitializeComponent();
        }
        //
        // Event for limited input in the Price textbox
        //
        private void txtPrice_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Double.TryParse(e.Text, out double val)) 
                if (!((e.Text == ",") && (txtPrice.Text.IndexOf(",") == -1)))
                    e.Handled = true; // reject input
        }
        //
        // Auxiliary events for the Price textbox
        //
        private void txtPrice_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space) 
                e.Handled = true; // reject input
            if (e.Key == Key.Enter)
                txtRate.Focus();
            ClearAll(e.Key);
        }
        //
        // Event for limited input in the Rate textbox
        //
        private void txtRate_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Double.TryParse(e.Text, out double val))
                if (!((e.Text == ",") && (txtRate.Text.IndexOf(",") == -1)))
                    e.Handled = true; // reject input
        }
        //
        // Auxiliary events for the Rate textbox
        //
        private void txtRate_PreviewKeyDown(object sender, KeyEventArgs e) {
            if(e.Key == Key.Space)
                e.Handled = true; // reject input
            if (e.Key == Key.Enter)
                btnRecalc.Focus();
            ClearAll(e.Key);
        }
        //
        // Recalculation button
        //
        private void btnRecalc_Click(object sender, RoutedEventArgs e) {
            double rate = 0;
            double usd = 0;
            double rub = 0;

            if (String.IsNullOrEmpty(txtPrice.Text) || String.IsNullOrEmpty(txtRate.Text)) {
                MessageBox.Show("Ошибка исходных данных. \n" + "Необходимо ввести данные в оба поля.", "Конвертер", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            usd = Convert.ToDouble(txtPrice.Text);
            rate = Convert.ToDouble(txtRate.Text);
            rub = usd * rate;

            lblAnswerField.Content = "$" + usd.ToString("F") + " = " + rub.ToString("F") + "₽";
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e) {
            ClearAll(e.Key);
        }

        private void ClearAll(Key key) {
            if (key == Key.Escape) {
                txtPrice.Text = "";
                txtRate.Text = "";
                lblAnswerField.Content = "";
            }
        }

        
    }
}
