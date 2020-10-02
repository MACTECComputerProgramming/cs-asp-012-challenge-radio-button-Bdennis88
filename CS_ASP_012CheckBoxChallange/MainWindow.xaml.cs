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

namespace CS_ASP_012
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

        private void labelButton1_Click(object sender, RoutedEventArgs e)
        {

            if (radioButton1.IsChecked == true)

                labelAnswer.Content = "Pencil, Very reliable";

            if (radioButton2.IsChecked == true)

                labelAnswer.Content = "Pen, nice choice";

            if (radioButton3.IsChecked == true)

                labelAnswer.Content = " Phone, must be from the future";

            if (radioButton4.IsChecked == true)

                labelAnswer.Content = "Pad, Welcome to 2020!";





        }
    }
}
