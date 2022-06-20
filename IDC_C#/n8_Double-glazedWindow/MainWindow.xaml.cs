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

namespace n8_Double_glazedWindow {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            btnOK.IsEnabled = false;
            rdoOneChamber.IsChecked = true;
            lblWindowsillDepth.Visibility = Visibility.Hidden;
            lblWindowsillWidth.Visibility = Visibility.Hidden;
            txtWindowsillDepth.Visibility = Visibility.Hidden;
            txtWindowsillWidth.Visibility = Visibility.Hidden;
        }
        //
        // Events for limited input in the WindowWidth textbox
        //
        private void txtWindowWidth_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Double.TryParse(e.Text, out double val))
                if (!((e.Text == ",") && (txtWindowWidth.Text.IndexOf(",") == -1)))
                    e.Handled = true; // reject input
        }
        private void txtWindowWidth_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space)
                e.Handled = true; // reject input
            if (e.Key == Key.Enter)
                txtWindowHeight.Focus();
        }
        private void txtWindowWidth_TextChanged(object sender, TextChangedEventArgs e) {
            ClearAnswer();
            CheckInput();
        }
        //
        // Events for limited input in the WindowHeight textbox
        //
        private void txtWindowHeight_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Double.TryParse(e.Text, out double val))
                if (!((e.Text == ",") && (txtWindowHeight.Text.IndexOf(",") == -1)))
                    e.Handled = true; // reject input
        }
        private void txtWindowHeight_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space)
                e.Handled = true; // reject input
            if ((e.Key == Key.Enter) && ((bool)chkWindowsill.IsChecked))
                txtWindowsillWidth.Focus();
            else if (e.Key == Key.Enter)
                btnOK.Focus();
        }
        private void txtWindowHeight_TextChanged(object sender, TextChangedEventArgs e) {
            ClearAnswer();
            CheckInput();
        }

        private void ClearAnswer() {
            if (blkTotal.Text != String.Empty)
                blkTotal.Text = String.Empty;
        }
        //
        // When changing the CheckButton, we clear the answer
        //
        private void rdoOneChamber_Unchecked(object sender, RoutedEventArgs e) {
            ClearAnswer();
        }

        private void rdoTwoChamber_Unchecked(object sender, RoutedEventArgs e) {
            ClearAnswer();
        }
        //
        // Procedure determining the possibility of using the button
        //
        private void CheckInput() {
            if ((txtWindowWidth.Text == String.Empty) ||
                (txtWindowHeight.Text == String.Empty) ||
                (txtWindowWidth.Text == ",") ||
                (txtWindowHeight.Text == ",")) {
                btnOK.IsEnabled = false;
            } else if (chkWindowsill.IsChecked == true) {
                if ((txtWindowsillWidth.Text == String.Empty) ||
                    (txtWindowsillDepth.Text == String.Empty) ||
                    (txtWindowsillWidth.Text == ",") ||
                    (txtWindowsillDepth.Text == ",")) {
                    btnOK.IsEnabled = false;
                } else {
                    btnOK.IsEnabled = true;
                }
            } else {
                btnOK.IsEnabled = true;
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e) {
            Single wWidth;      // Window width
            Single wHeight;     // Window height
            Single wSquare;     // Window square
            Single wsWidth;     // Windowsill width
            Single wsDepth;     // Windowsill depth
            Single price;      // Window price per 1 sq.m.
            Single total;

            wWidth = Convert.ToSingle(txtWindowWidth.Text);
            wHeight = Convert.ToSingle(txtWindowHeight.Text);
            wSquare = wWidth * wHeight / 10000;

            if ((bool)rdoOneChamber.IsChecked)
                price = 5000;
            else
                price = 6000;

            total = wSquare * price;

            if ((bool)rdoOneChamber.IsChecked) {
                if ((bool)chkWindowsill.IsChecked) {
                    wsWidth = Convert.ToSingle(txtWindowsillWidth.Text);
                    wsDepth = Convert.ToSingle(txtWindowsillDepth.Text);
                    blkTotal.Text = "Window price - " + total.ToString("F") + "₽\n" +
                                    "Window size - " + wWidth.ToString("N") + " x " + wHeight.ToString("N") + " cm\n" +
                                    "Glass unit - " + rdoOneChamber.Content +
                                    "\nWindowsill size - " + wsWidth.ToString("N") + " x " + wsDepth.ToString("N") + " cm";
                } else {
                    blkTotal.Text = "Window price - " + total.ToString("F") + "₽\n" +
                                    "Window size - " + wWidth.ToString("N") + " x " + wHeight.ToString("N") + " cm\n" +
                                    "Glass unit - " + rdoOneChamber.Content;
                }
            } else {
                if ((bool)chkWindowsill.IsChecked) {
                    wsWidth = Convert.ToSingle(txtWindowsillWidth.Text);
                    wsDepth = Convert.ToSingle(txtWindowsillDepth.Text);
                    blkTotal.Text = "Window price - " + total.ToString("F") + "₽\n" +
                                    "Window size - " + wWidth.ToString("N") + " x " + wHeight.ToString("N") + " cm\n" +
                                    "Glass unit - " + rdoTwoChamber.Content +
                                    "\nWindowsill size - " + wsWidth.ToString("N") + " x " + wsDepth.ToString("N") + " cm"; ;
                } else {
                    blkTotal.Text = "Window price - " + total.ToString("F") + "₽\n" +
                                    "Window size - " + wWidth.ToString("N") + " x " + wHeight.ToString("N") + " cm\n" +
                                    "Glass unit - " + rdoTwoChamber.Content;
                }
            }
        }
        //
        // Hiding or showing the data entry fields of windowsill
        //
        private void chkWindowsill_Checked(object sender, RoutedEventArgs e) {
            lblWindowsillDepth.Visibility = Visibility.Visible;
            lblWindowsillWidth.Visibility = Visibility.Visible;
            txtWindowsillDepth.Visibility = Visibility.Visible;
            txtWindowsillWidth.Visibility = Visibility.Visible;

            CheckInput();
        }
        private void chkWindowsill_Unchecked(object sender, RoutedEventArgs e) {
            lblWindowsillDepth.Visibility = Visibility.Hidden;
            lblWindowsillWidth.Visibility = Visibility.Hidden;
            txtWindowsillDepth.Visibility = Visibility.Hidden;
            txtWindowsillWidth.Visibility = Visibility.Hidden;

            CheckInput();
        }
        //
        // Events for limited input in the WindowsillWidth textbox
        //
        private void txtWindowsillWidth_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Double.TryParse(e.Text, out double val))
                if (!((e.Text == ",") && (txtWindowsillWidth.Text.IndexOf(",") == -1)))
                    e.Handled = true; // reject input
        }
        private void txtWindowsillWidth_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space)
                e.Handled = true; // reject input
            if (e.Key == Key.Enter)
                txtWindowsillDepth.Focus();
        }
        private void txtWindowsillWidth_TextChanged(object sender, TextChangedEventArgs e) {
            ClearAnswer();
            CheckInput();
        }
        //
        // Events for limited input in the WindowsillDepth textbox
        //
        private void txtWindowsillDepth_PreviewTextInput(object sender, TextCompositionEventArgs e) {
            if (!Double.TryParse(e.Text, out double val))
                if (!((e.Text == ",") && (txtWindowsillDepth.Text.IndexOf(",") == -1)))
                    e.Handled = true; // reject input
        }
        private void txtWindowsillDepth_PreviewKeyDown(object sender, KeyEventArgs e) {
            if (e.Key == Key.Space)
                e.Handled = true; // reject input
            if (e.Key == Key.Enter)
                btnOK.Focus();
        }
        private void txtWindowsillDepth_TextChanged(object sender, TextChangedEventArgs e) {
            ClearAnswer();
            CheckInput();
        }

        private void btnСlear_Click(object sender, RoutedEventArgs e) {
            txtWindowsillDepth.Text = String.Empty;
            txtWindowsillWidth.Text = String.Empty;
            txtWindowWidth.Text = String.Empty;
            txtWindowHeight.Text = String.Empty;
        }
    }
}