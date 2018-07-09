using System;
using System.Windows;

namespace Calculator1
{

    public partial class MainWindow : Window
    {

        decimal FirstNumber = 0m;
        
        string Operation;

        public MainWindow()
        {
            InitializeComponent();

        }
        
        private void screen_Click(object sender, RoutedEventArgs e)
        {
            var buttonValue = ((System.Windows.Controls.Button)e.Source).Content.ToString();

            if(IsOperation(buttonValue))
            {
                FirstNumber = Convert.ToDecimal(screen1.Text);
                screen1.Text = "";
                Operation = buttonValue;
            }else if(IsDigit(buttonValue))
            {
                screen1.Text = screen1.Text + buttonValue;
            }
            else if(buttonValue == "=")
            {
                Calculate();
            }

            Console.WriteLine("sss");
        }

        private bool IsOperation(string buttonValue)
        {
            switch(buttonValue)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    return true;
                default:
                    return false;
            }
        }

        private bool IsDigit(string buttonValue)
        {
            switch (buttonValue)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case ".":
                    return true;
                default:
                    return false;
            }
        }

        private void Calculate()
        {
            decimal SecondNumber = Convert.ToDecimal(screen1.Text);
            decimal Result = 0m;

            switch (Operation)
            {
                case "+":
                    Result = FirstNumber + SecondNumber;
                    break;

                case "-":
                    Result = FirstNumber - SecondNumber;
                    break;

                case "*":
                    Result = FirstNumber * SecondNumber;
                    break;

                case "/":
                    Result = FirstNumber / SecondNumber;
                    break;
                default:
                    break;
            }
            screen1.Text = Convert.ToString(Result);
        }
    }
 
  }



