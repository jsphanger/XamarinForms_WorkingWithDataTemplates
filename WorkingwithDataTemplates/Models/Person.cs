using System.Collections.Generic;
using Xamarin.Forms;

namespace WorkingwithDataTemplates.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Location { get; set; }

        public Person() { }
    }

    public class PersonView : Grid
    {
        private Label _name = new Label(),
                      _age = new Label(),
                      _location = new Label();

        public PersonView()
        {
            _name.SetBinding(Label.TextProperty, "Name");
            _age.SetBinding(Label.TextProperty, "Age");
            _location.SetBinding(Label.TextProperty, "Location");

            Children.Add(_name, 0, 0);
            Children.Add(_age, 1, 0);
            Children.Add(_location, 2, 0);
        }
    }

    public class PersonBindableLayout : StackLayout
    {
        public PersonBindableLayout()
        {
            /* NOTE: All these versions of DataTemplate work.  I'm just leaving these here for example reasons. */

            var personList = (List<Person>)GetValue(BindableLayout.ItemsSourceProperty);
            BindableLayout.SetItemsSource(this, personList);
            BindableLayout.SetItemTemplate(this, new DataTemplate(typeof(PersonView)));

            //BindableLayout.SetItemTemplate(this, new DataTemplate(() => new PersonView()));
            //BindableLayout.SetItemTemplate(this, new DataTemplate(() => { return new PersonView(); }));
        }
    }
}
