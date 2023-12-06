using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanieL_Prog2_Final
{
    public class Today
    {
        //Fields
        string _Name; //For Name Category
        bool _HighImportance; //If or if it is not of high important
        bool _TimeSensitive; //If or if it is not time sensitive
        bool _Completed; //If the task has been completed
        string _Description; //Description of the task

        //Constructor
        public Today(string name, bool highImportance, bool timeSensitive, bool completed, string description)
        {
            _Name = name;
            _HighImportance = highImportance;
            _TimeSensitive = timeSensitive;
            _Completed = completed;
            _Description = description;
        }

        //Properties
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }
    }
}
