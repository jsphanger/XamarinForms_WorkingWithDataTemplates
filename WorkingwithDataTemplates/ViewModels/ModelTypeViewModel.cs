using System;
using System.Linq;
using System.Collections.Generic;
using WorkingwithDataTemplates.Models;

namespace WorkingwithDataTemplates.ViewModels
{
    public class ModelTypeViewModel : BaseViewModel
    {
        private List<Person> _personList = new List<Person>();

        public List<Person> PersonList { get { return _personList; } set { _personList = value; OnPropertyChanged(nameof(PersonList)); } }
        
        public ModelTypeViewModel() {
            LoadPersonList();
        }

        public bool LoadPersonList()
        {
            PersonList.Clear();

            PersonList.Add(new Person() { Name = "Steve", Age = 21, Location = "USA" });
            PersonList.Add(new Person() { Name = "John", Age = 37, Location = "USA" });
            PersonList.Add(new Person() { Name = "Tom", Age = 42, Location = "UK" });
            PersonList.Add(new Person() { Name = "Lucas", Age = 29, Location = "Germany" });
            PersonList.Add(new Person() { Name = "Tariq", Age = 39, Location = "UK" });
            PersonList.Add(new Person() { Name = "Jane", Age = 30, Location = "USA" });

            return true;
        }
    }
}
