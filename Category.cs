using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanieL_Prog2_Final
{
    public class Category
    {
        //Fields
        string _name;
        List<Item> _todoItemsInCategory;

        //Constructors 
        public Category(string name)
        {
            Name = name;

            _todoItemsInCategory = new List<Item>();

        }

        public Category(string name, List<Item> todoItemsInCategory)
        {
            Name = name;
            _todoItemsInCategory = todoItemsInCategory;
        }

        //Properties
        public string Name { get => _name; set => _name = value; }
        public List<Item> TodoItemsInCategory { get => _todoItemsInCategory; set => _todoItemsInCategory = value; }

        public override string ToString()
        {
            return Name;
        }



    }
}
