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

namespace CalculatorV1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        long num1;
        long num2;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_one_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num1 = (num1 * 10) + 1;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 1;
                txt_display.Text = num2.ToString();
            }
    
        }

        private void btn_two_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 2;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 2;
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_three_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 3;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 3;
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_four_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 4;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 4;
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_five_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 5;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 5;
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_six_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 6;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 6;
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_seven_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 7;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 7;
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_eight_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 8;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 8;
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_nine_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10) + 9;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10) + 9;
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_zero_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 = (num1 * 10);
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 * 10);
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_Add_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txt_display.Text = "0";
        }

        private void btn_Subtract_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txt_display.Text = "0";
        }

        private void btn_Multiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txt_display.Text = "0";
        }

        private void btn_Divide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txt_display.Text = "0";
        }

        private void btn_Del_Click(object sender, RoutedEventArgs e)
        {
            //remove last digit
            if (operation == "")
            {
                num1 = (num1 / 10);
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 = (num2 / 10);
                txt_display.Text = num2.ToString();
            }
        }

        private void btn_Equals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txt_display.Text = (num1 + num2).ToString();
                    break;
                case "-":
                    txt_display.Text = (num1 - num2).ToString();
                    break;
                case "*":
                    txt_display.Text = (num1 * num2).ToString();
                    break;
                case "/":
                    txt_display.Text = (num1 / num2).ToString();
                    break;

            }
        }

        private void btn_CE_Click(object sender, RoutedEventArgs e)
        {
            if(operation == "")
            {
                num1 = 0;
            }
            else
            {
                num1 = 0;
            }
            txt_display.Text = "0";
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operation = "";
            txt_display.Text = "0";
        }

        private void btn_PosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                num1 *= - 1;
                txt_display.Text = num1.ToString();
            }
            else
            {
                num2 *= -1;
                txt_display.Text = num2.ToString();
            }
        }


    }
}
