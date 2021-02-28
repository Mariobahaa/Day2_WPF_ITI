using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace P1
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    public partial class Calculator : Window
    {
        bool SymbPressed = false;
        float Prev = 0;
        String prevSymb = "=";
        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var digit = (e.Source as Button).Content.ToString();

            if (Result.Text=="0" || SymbPressed)
            {
                Result.Text = digit ;
            }
            else
            {
                Result.Text += digit;
            }
            SymbPressed = false;
        }

        private void Button_Click_op(object sender, RoutedEventArgs e)
        {
            var symbol = prevSymb;
            prevSymb = (e.Source as Button).Content.ToString();

            switch (symbol)
            {
                case ".":
                    Result.Text += symbol;
                    Point.IsEnabled = false;
                    break;
                case "+":
                    Prev = float.Parse(Result.Text.ToString()) + Prev;
                    Result.Text = Prev.ToString();
                    Point.IsEnabled = true;
                    SymbPressed = true;
                    break;
                case "/":
                    Prev = float.Parse(Result.Text.ToString()) / Prev;
                    Result.Text = Prev.ToString();
                    Point.IsEnabled = true;
                    SymbPressed = true;
                    break;
                case "x":
                    Prev = float.Parse(Result.Text.ToString()) * Prev;
                    Result.Text = Prev.ToString();
                    Point.IsEnabled = true;
                    SymbPressed = true;
                    break;
                case "-":
                    Prev = float.Parse(Result.Text.ToString()) - Prev;
                    Result.Text = Prev.ToString();
                    Point.IsEnabled = true;
                    SymbPressed = true;
                    break;
                case "=":
                    Prev = float.Parse(Result.Text.ToString());
                    Result.Text = Prev.ToString();
                    Point.IsEnabled = true;
                    SymbPressed = true;
                    break;
            }

        }
    }
}
