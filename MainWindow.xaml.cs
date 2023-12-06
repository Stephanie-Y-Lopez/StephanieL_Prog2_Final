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
        List<Category> Task;
        //For ComboBox List

        public MainWindow()
        {
            InitializeComponent();

            Task = new List<Category>
            {
            new Category("Item"),
            new Category("Category")
            };

            Task[0].TodoItemsInCategory.Add(new Item("This is an item"));
            Task[1].TodoItemsInCategory.Add(new Item("This is the second item"));

            CMBcategories.ItemsSource = Task;
        }

        private void CMBcategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = CMBcategories.SelectedIndex;
            Category selected = Task[index];
            LVtask.ItemsSource = selected.TodoItemsInCategory;
        }
    }
}
