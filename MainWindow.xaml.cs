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
        Category selectedCategory;

        public MainWindow()
        {
            InitializeComponent();
            Preload();

            CMBcategories.ItemsSource = _categories;

            CMBcategories.SelectedIndex = 0;
        }


        public void Preload()
        {
            _categories = new List<Category>();


            //Index0
            _categories.Add(new Category("Item"));
            _categories[0].AddItem(new Item("Presentation", false, true, false, "Prepare presentation slides"));
            _categories[0].AddItem(new Item("Meeting", true, false, false, "Attend team meeting"));
            _categories[0].AddItem(new Item("Read", false, false, false, "Read industry articles"));
            _categories[0].AddItem(new Item("Follow up", true, true, false, "Follow up with important client"));

            //Index1
            _categories.Add(new Category("Category"));
            _categories[1].AddItem(new Item("Exercise", false, false, false, "Exercise for 30 minutes"));
            _categories[1].AddItem(new Item("Review Project", true, true, false, "Review project deadlines"));
            _categories[1].AddItem(new Item("Organize", false, false, false, "Organize workspace"));
            _categories[1].AddItem(new Item("Online Training", true, false, false, "Complete online training"));
            _categories[1].AddItem(new Item("Write code", false, true, false, "Write code for new feature"));

            _Items = new List<Item>()
            {
            new Item("Presentation", false, true, false, "Prepare presentation slides"),
            new Item("Meeting", true, false, false, "Attend team meeting"),
            new Item("Read", false, false, false, "Read industry articles"),
            new Item("Follow up", true, true, false, "Follow up with important client"),
            new Item("Exercise", false, false, false, "Exercise for 30 minutes"),
            new Item("Review Project", true, true, false, "Review project deadlines"),
            new Item("Organize", false, false, false, "Organize workspace"),
            new Item("Online Training", true, false, false, "Complete online training"),
            new Item("Write code", false, true, false, "Write code for new feature")
            }; //Task List

        }

        // If(rbCompeted.Value == true) { }

        private void LVtask_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Validation
            int selectedIndex = LVtask.SelectedIndex;

            if(selectedIndex != -1)
            {

                Item selectedItem = _Items[selectedIndex];

                RunRTXTB.Text = selectedItem.DisplayInformation();


                TXTBtask.Text = selectedItem.Name;

                TXTBdescription.Text = selectedItem.Description;

                CBhighimport.IsChecked = selectedItem.HighImportance;

                CBtimesensitive.IsChecked = selectedItem.TimeSensitive;

                //LVtask.Items.Refresh();

            }// To Display within appropriate sections when clicked
 
        }


        private void CMBcategories_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedClass = CMBcategories.SelectedIndex;
            Category dpt = _categories[selectedClass];
            LVtask.ItemsSource = dpt.TodoItemsInCategory;
        } //This is for Task to appear in selected Class

        private void BTNupdate_Click(object sender, RoutedEventArgs e)
        {

            // Grabbing the selected indexs from our combobox and listview
            int cmbIndex = CMBcategories.SelectedIndex;
            int lvIndex = LVtask.SelectedIndex;

            if (cmbIndex == -1 || lvIndex == -1) return; // Gatekeeping validation

            Category selectedCategory = _categories[cmbIndex];
            Item selectedItem = selectedCategory.TodoItemsInCategory[lvIndex];

            selectedItem.HighImportance = CBhighimport.IsChecked.Value;
            selectedItem.TimeSensitive = CBtimesensitive.IsChecked.Value;

            if(RBTNcompleted.IsChecked.Value == true)
            {
                selectedItem.CompletedTask();
            }

            LVtask.Items.Refresh();
            RunRTXTB.Text = selectedItem.DisplayInformation();

            // cat == dog // false
            // dog == dog // true
            // if(true)
            // if(false)
            // true == true // true
            //if (value == false)

            // ! Not
            // !True = false
            // !False = true
            //if (CBhighimport.IsChecked.Value)
            //{
            //    selectedItem.highimportanceTask();
            //    LVtask.Items.Refresh();
            //    RunRTXTB.Text = selectedItem.DisplayInformation();
            //}


            //if (CBtimesensitive.IsChecked.Value == true)
            //{
            //    selectedItem.timesensitiveTask();
            //    LVtask.Items.Refresh();
            //    RunRTXTB.Text = selectedItem.DisplayInformation();
            //}


        }

        private void BTNclearbox_Click(object sender, RoutedEventArgs e)
        {
            TXTBdescription.Text = "";
            TXTBtask.Text = "";
            RunRTXTB.Text = "";
            CBhighimport.IsChecked = false;
            CBtimesensitive.IsChecked = false;
            RBTNcompleted.IsChecked = false;
            RBTNnotcompleted.IsChecked = false;
            LVtask.SelectedIndex = -1;
        } //To clear all appropriate 

        private void BTNadd_Click(object sender, RoutedEventArgs e)
        {
            // Get category name
            string categoryName = TXTBnewcategory.Text;

            // Make a new category item
            Category newCategory = new Category(categoryName);

            // Add category to list
            _categories.Add(newCategory);
    
            // Refresh combobox
            CMBcategories.Items.Refresh();
        }

        private void BTNaddtolist_Click(object sender, RoutedEventArgs e)
        {
            // Get all the values from our GUI
            string TaskBox = TXTBtask.Text;
            string TaskDescription = TXTBdescription.Text;
            bool TaskImportance = CBhighimport.IsChecked.Value;
            bool TaskTime = CBtimesensitive.IsChecked.Value;
            bool Taskcomplete = RBTNcompleted.IsChecked.Value;

            // Create a new item
            Item newitem = new Item(TaskBox, TaskImportance, TaskTime, Taskcomplete, TaskDescription);

            // Get the currently selected category
            // 1. Get the selected index of the combo box
            int cmbSelectedIndex = CMBcategories.SelectedIndex;

            // 2. Add to category
            _categories[cmbSelectedIndex].AddItem(newitem);

            // Add the item to the category

            // Refresh the listview
            LVtask.Items.Refresh();
        }
    }
}
