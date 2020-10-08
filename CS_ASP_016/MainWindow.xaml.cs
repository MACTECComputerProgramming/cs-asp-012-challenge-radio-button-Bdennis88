using System;
using System.Windows;
using System.Windows.Controls;

namespace CS_ASP_016
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

        // Instantiate tow Date Time variables

        public DateTime myFirstDate, mySecondDate;



        // Get First Date                       
        public void myCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            myFirstDate = myCalendar.SelectedDate.Value;
            
        }

        // Get my Second Date

        public void mySecondCalendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            mySecondDate = mySecondCalendar.SelectedDate.Value;

        }

        // Call Black Out Method
        private void button_Click(object sender, RoutedEventArgs e)
        {

            


        }




    }
}
