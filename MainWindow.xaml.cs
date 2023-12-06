using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        List<Category> _categories;
        List<Item> _Items;
        //Classes

        public MainWindow()
        {
            InitializeComponent();

               _categories = new List<Category>
               {
                 new Category("Item"),
                 new Category("Category")
               };
            CMBcategories.ItemsSource = _categories;
            //For Classes In ComboBox

            Preload();

            LVtask.ItemsSource = _Items;

            RunRTXTB.Text = _Items[0].DisplayInformation();
        }


        public void Preload()
        {
            

            _Items = new List<Item>()
            {

            new Item("Presentation", false, true, false, "Prepare presentation slides"),
            new Item("Meeting", true, false, false, "Attend team meeting"),
            new Item("Read", false, false, false, "Read industry articles"),
            new Item("Follow up", true, true, false, "Follow up with important client"),
            new Item("Task 6", false, false, false, "Exercise for 30 minutes"),
            new Item("Task 7", true, true, false, "Review project deadlines"),
            new Item("Task 8", false, false, false, "Organize workspace"),
            new Item("Task 9", true, false, false, "Complete online training"),
            new Item("Task 10", false, true, false, "Write code for new feature")
            }; //Task List
        }
        private void LVtask_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {

            int selectedIndex = LVtask.SelectedIndex;

            RunRTXTB.Text = _Items[selectedIndex].DisplayInformation();

            }

        private void CMBcategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = CMBcategories.SelectedIndex;
            Category selected = _categories[index];
            LVtask.ItemsSource = selected.TodoItemsInCategory;
        } //This is for Task to appear in selected Class
    }
}
