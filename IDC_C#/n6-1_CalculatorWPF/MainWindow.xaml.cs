using System;
using System.Windows;

namespace n6_1_CalculatorWPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        double number1 = 0;
        double number2 = 0;
        private void btnPlus_Click(object sender, EventArgs e) {
            if (!isCorrect(tbNumber1.Text, tbNumber2.Text)) {
                MessageBox.Show("The wrong input");
                return;
            }

            number1 = Convert.ToDouble(tbNumber1.Text);
            number2 = Convert.ToDouble(tbNumber2.Text);

            lbAnswerField.Content = Convert.ToString(number1 + number2);
        }

        private void btnMinus_Click(object sender, EventArgs e) {
            if (!isCorrect(tbNumber1.Text, tbNumber2.Text)) {
                MessageBox.Show("The wrong input");
                return;
            }

            number1 = Convert.ToDouble(tbNumber1.Text);
            number2 = Convert.ToDouble(tbNumber2.Text);

            lbAnswerField.Content = Convert.ToString(number1 - number2);
        }

        private void btnMultiply_Click(object sender, EventArgs e) {
            if (!isCorrect(tbNumber1.Text, tbNumber2.Text)) {
                MessageBox.Show("The wrong input");
                return;
            }

            number1 = Convert.ToDouble(tbNumber1.Text);
            number2 = Convert.ToDouble(tbNumber2.Text);

            lbAnswerField.Content = Convert.ToString(number1 * number2);
        }

        private void btnDivide_Click(object sender, EventArgs e) {
            if (!isCorrect(tbNumber1.Text, tbNumber2.Text)) {
                MessageBox.Show("The wrong input");
                return;
            }

            number1 = Convert.ToDouble(tbNumber1.Text);
            number2 = Convert.ToDouble(tbNumber2.Text);
            if (number2 == 0) {
                MessageBox.Show("Attempting to divide by zero");
                return;
            }

            lbAnswerField.Content = Convert.ToString(number1 / number2);
        }

        private bool isCorrect(string str1, string str2) {
            double num = 0;

            try {
                num = double.Parse(str1);
                num = double.Parse(str2);
            } catch {
                return false;
            }
            if (String.IsNullOrWhiteSpace(tbNumber1.Text) || String.IsNullOrWhiteSpace(tbNumber2.Text)) {
                return false;
            }
            return true;
        }
    }
}
