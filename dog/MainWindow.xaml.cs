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

namespace dog
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double value = Math.Round(HeightSlider.Value, 1);
            HeightNumber.Text = value.ToString();

            double v = (value / 200 * 320);
            Canvas.SetLeft(Height, v);




            double h = double.Parse(HeightNumber.Text);
            double w = double.Parse(WeightNumber.Text);
            double bmi = w/Math.Pow((h/100),2);

            string[] parts = bmi.ToString().Split('.');

            BmiNumber1.Text = parts[0];
            if (parts.Length > 1)
             BmiNumber2.Text = "." + parts[1]; 
            else
                BmiNumber2.Text = ".0";
        }

        private void WeightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            double value = Math.Round(WeightSlider.Value, 1);
            WeightNumber.Text = value.ToString();

            double v = (value / 200 * 320);
            Canvas.SetLeft(Weight, v);



            double h = double.Parse(HeightNumber.Text);
            double w = double.Parse(WeightNumber.Text);


            double bmi =Math.Round( w / Math.Pow((h / 100), 2),1);
            string[] parts = bmi.ToString().Split('.');

            BmiNumber1.Text = parts[0];
            if (parts.Length > 1)
                BmiNumber2.Text = "." + parts[1];
            else
                BmiNumber2.Text = ".0";



        }


    }
}
