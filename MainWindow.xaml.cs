using System;
using System.Windows;
using System.Windows.Controls;

namespace calculator_v1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private float a, b;
        private int oper;
        private bool znak = true;

        #region numbers
        //button 1
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }
        
        //button 2
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        //button 3
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        //button 4
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        //button 5
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        //button 6
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        //button 7
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        //button 8
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        //button 9
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        //button 0
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
            
        }
        
        //button .
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }


#endregion

        //button +
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            oper = 1;
            textBox1.Clear();
            label1.Content = a.ToString() + "+";
            znak = true;          
            
        }

        //signed or asigned values +-
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (znak == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                znak = false;
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace("-","");
                znak = true;
            }
        }

        //button =
        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            calculation();
            //label1.Content = " ";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
            label1.Content = "";
        }

        //button -
        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            oper = 2;
            textBox1.Clear();
            label1.Content = a.ToString() + "-";
            znak = true;
        }

        //button *
        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
           // float.TryParse//обробити ситуацію, коли користувач натискає кнопку арифметичної операціїї перш аніж введе перше число
            a = float.Parse(textBox1.Text);
            oper = 3;
            textBox1.Clear();
            label1.Content = a.ToString() + "*";
            znak = true;
        }

        //button /
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            a = float.Parse(textBox1.Text);
            oper = 4;
            textBox1.Clear();
            label1.Content = a.ToString() + "/";
            znak = true;
        }

        //button <--
        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
        }

        //function for calculating operations
        private void calculation()
        {
            b = float.Parse(textBox1.Text);

            switch (oper)
            {
                case 1:
                    label1.Content = a.ToString() + "+" + b.ToString();
                    textBox1.Text = (a + b).ToString();
                   
                    break;
                case 2:
                    label1.Content = a.ToString() + "-" + b.ToString();
                    textBox1.Text = (a - b).ToString();

                    break;
                case 3:
                    label1.Content = a.ToString() + "*" + b.ToString();
                    textBox1.Text = (a * b).ToString();

                    break;
                case 4:
                    if (b != 0)
                    {
                    label1.Content = a.ToString() + "/" + b.ToString();
                    textBox1.Text = (a / b).ToString();
                    }
                    else
                    {
                        MessageBox.Show("You can not divide by zero!", "Error");
                    }
                    

                    break;
                default:
                    break;
            }
        }
    }
}
