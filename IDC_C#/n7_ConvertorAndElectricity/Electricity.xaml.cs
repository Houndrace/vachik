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
    /// Interaction logic for Electricity.xaml
    /// </summary>
    public partial class Electricity : Window {
        public Electricity() {
            InitializeComponent();
        }
        //
        // Calculation button
        //
        private void btnCalculation_Click(object sender, RoutedEventArgs e) {
            double curr = 0;
            double prev = 0;
            double tariff = 0;
            double price = 0;

            if (String.IsNullOrEmpty(txtTariff.Text) || String.IsNullOrEmpty(txtPrevious.Text) || String.IsNullOrEmpty(txtCurrent.Text)) {
                MessageBox.Show("Ошибка исходных данных. \n" + "Необходимо ввести данные во все поля.", "Электроэнергия", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            prev = Convert.ToDouble(txtPrevious.Text);
            curr = Convert.ToDouble(txtCurrent.Text);
            tariff = Convert.ToDouble(txtTariff.Text);

            if (curr >= prev) {
                price = (curr - prev) * tariff;
                lblAnswerField.Content = price.ToString("F") + "₽";
            } else {
                MessageBox.Show("Ошибка исходных данных. \n" + "Текущее значение показания счетчика\n" + "меньше предыдущего", "Электроэнергия", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //
        // Event for limited input in the Previous textbox
        //
        private void txtPrevious_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Double.TryParse(e.Text, out double val))
                if (!((e.Text == ",") && (txtPrevious.Text.IndexOf(",") == -1)))
                    e.Handled = true; // reject input
        }
        //
        // Auxiliary events for the Previous textbox
        //
        private void txtPrevious_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space)
                e.Handled = true; // reject input
            if (e.Key == Key.Enter)
                txtCurrent.Focus();
            ClearAll(e.Key);
        }
        //
        // Event for limited input in the Current textbox
        //
        private void txtCurrent_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Double.TryParse(e.Text, out double val))
                if (!((e.Text == ",") && (txtCurrent.Text.IndexOf(",") == -1)))
                    e.Handled = true; // reject input
        }
        //
        // Auxiliary events for the Current textbox
        //
        private void txtCurrent_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space)
                e.Handled = true; // reject input
            if (e.Key == Key.Enter)
                txtTariff.Focus();
            ClearAll(e.Key);
        }
        //
        // Event for limited input in the Tariff textbox
        //
        private void txtTariff_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Double.TryParse(e.Text, out double val))
                if (!((e.Text == ",") && (txtTariff.Text.IndexOf(",") == -1)))
                    e.Handled = true; // reject input
        }
        //
        // Auxiliary events for the Tariff textbox
        //
        private void txtTariff_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space)
                e.Handled = true; // reject input
            if (e.Key == Key.Enter)
                btnCalculation.Focus();
            ClearAll(e.Key);
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e) {
            ClearAll(e.Key);
        }

        private void ClearAll(Key key) {
            if (key == Key.Escape) {
                txtCurrent.Text = "";
                txtPrevious.Text = "";
                txtTariff.Text = "";
                lblAnswerField.Content = "";
            }
        }
    }
}
