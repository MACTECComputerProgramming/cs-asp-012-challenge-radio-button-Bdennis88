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

            if (labelButton1)

            LabelAnswer.Content = " Must pick one ";

            if (labelCheckBox1.IsChecked == true)

                labelAnswer.Content = " Pencil, Very reliable!";

            if (labelCheckBox2.IsChecked == true)

                labelAnswer.Content = " Pen, nice choice!";

            if 

        }
    }
}
