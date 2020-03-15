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
namespace Calculator
{
    public partial class MainWindow : Window
    {
        AirthmeticViewModel model;
        public MainWindow()
        {  
            InitializeComponent();           
            model = (AirthmeticViewModel)base.DataContext;
        }
        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("7");
        }
        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("8");
        }
        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("9");
        }
        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("4");
        }
        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("5");
        }
        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("6");
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("1");
        }
        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("2");
        }
        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("3");
        }
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            model.updateNumber = double.Parse("0");
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            model.operation(1);
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            model.operation(5);
        }
        private void equal_Click(object sender, RoutedEventArgs e)
        {
            model.operation(0);
        }
        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            model.operation(3);
        }
        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            model.operation(2);
        }
        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            model.operation(4);
        }
    }
}