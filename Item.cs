using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StephanieL_Prog2_Final
{
    public class Item
    {
        //Fields
        string _name; //For Name Category
        bool _highImportance; //If or if it is not of high important
        bool _timeSensitive; //If or if it is not time sensitive
        bool _completed; //If the task has been completed
        string _description; //Description of the task

        public Item(string name, bool highImportance, bool timeSensitive, bool completed, string description)
        {
            _name = name;
            _highImportance = highImportance;
            _timeSensitive = timeSensitive;
            _completed = completed;
            _description = description;
        }

        public Item(string name)
        {
            _name = name;
        }

        public string Name { get => _name; set => _name = value; }
        public bool HighImportance { get => _highImportance; set => _highImportance = value; }
        public bool TimeSensitive { get => _timeSensitive; set => _timeSensitive = value; }
        public bool Completed { get => _completed; set => _completed = value; }
        public string Description { get => _description; set => _description = value; }

        public void CompletedTask()
        {
            Completed = true;
            Description += "\n***Task Completed***";
        }        // For RadioButton Complete

        public void highimportanceTask()
        {
            HighImportance = !HighImportance;

  

        }       // For Checkbox Time Sensitive


        public void timesensitiveTask()
        {
           TimeSensitive = true;
        }       // For CheckBox Time Sensitive

 

        //Method
        public string DisplayInformation()
        {
            string fullInformation = "";
            fullInformation += $"Task Name: {_name}\n";
            fullInformation += $" \n";
            fullInformation += $"Task Of High Importance: {_highImportance}\n";
            fullInformation += $" \n";
            fullInformation += $"Task Is Time Sensitive: {_timeSensitive}\n";
            fullInformation += $" \n";
            fullInformation += $"Task Completion: {_completed}\n";
            fullInformation += $" \n";
            fullInformation += $"Task Description: {_description}\n";

            return fullInformation;
        }
    }
}