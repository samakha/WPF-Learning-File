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

namespace WpfApp_Silver1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBlock temp;
        bool isSama = false; 
        public MainWindow()
        {
            InitializeComponent();

           temp = new TextBlock(); 
            
            
        }
         private void click_button_change(object sender , RoutedEventArgs e)
        {
         
        }
    }
}
