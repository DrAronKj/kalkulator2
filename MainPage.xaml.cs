using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace kalkulator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int _outnum = 0;
        int active_base = 10;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void calc(char op)
        {
            int a, b;
            try
            {
                a = Convert.ToInt32(op1.Text);
                b = Convert.ToInt32(op2.Text);
            }
            catch
            {
                Console.WriteLine("Unable to convert to number.");
                a = 0;
                b = 0;
            }
            switch (op)
            {
                case '+':
                    _outnum = a + b;
                    break;
                case '-':
                    _outnum = a - b;
                    break;
                case '*':
                    _outnum = a * b;
                    break;
                case '/':
                    _outnum = a / b;
                    break;
                default:
                    break;
            }
        }

        private void output()
        {
            switch (active_base)
            {
                case 2:
                    _out.Text = Convert.ToString(_outnum, 2);
                    break;
                case 8:
                    _out.Text = Convert.ToString(_outnum, 8);
                    break;
                case 16:
                    _out.Text = Convert.ToString(_outnum, 16);
                    break;
                default:
                    _out.Text = Convert.ToString(_outnum);
                    break;
            }
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            calc('+');
            output();
        }

        private void sub_Click(object sender, RoutedEventArgs e)
        {
            calc('-');
            output();
        }

        private void mul_Click(object sender, RoutedEventArgs e)
        {
            calc('*');
            output();
        }

        private void div_Click(object sender, RoutedEventArgs e)
        {
            calc('/');
            output();
        }

        private void _base_Checked(object sender, RoutedEventArgs e)
        {
            active_base = 10;
            output();
        }

        private void _base1_Checked(object sender, RoutedEventArgs e)
        {
            active_base = 2;
            output();
        }

        private void _base2_Checked(object sender, RoutedEventArgs e)
        {
            active_base = 8;
            output();
        }

        private void _base3_Checked(object sender, RoutedEventArgs e)
        {
            active_base = 16;
            output();
        }
    }
}


