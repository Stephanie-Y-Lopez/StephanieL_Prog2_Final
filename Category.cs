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
            _name = name;

            _todoItemsInCategory = new List<Item>();

        }

        public List<Item> TodoItemsInCategory { get => _todoItemsInCategory; set => _todoItemsInCategory = value; }

        public override string ToString()
        {
            return _name;
        }

    }
}
