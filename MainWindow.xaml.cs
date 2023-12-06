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

namespace StephanieL_Prog2_Final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    // Section 1: Name
    // Stephanie Lopez
    // 12.4.23
    // Programming 2 Final

    public partial class MainWindow : Window
    {
        List<string> Task;
        //For ComboBox List

        public MainWindow()
        {
            InitializeComponent();

            Task = new List<string>
            {
             "Today",
             "Shopping",
             "Travel"
             // List for ComboBox
            };
            
            CMBcategories.ItemsSource = Task;
        }
    }
}
