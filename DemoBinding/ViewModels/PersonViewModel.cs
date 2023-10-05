using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using DemoBinding.Models;

namespace DemoBinding.ViewModels
{
    internal class PersonViewModel : /*INotifyPropertyChanged*/ ObservableObject
    {
        public Person person;

        //public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ToUpperCommand {  get; set; }
        
        public string Firstname { get => person.Firstname; set 
            { 
                person.Firstname = value;
                RaisePropertyChanged("FullName");
            }
        }
        public string Lastname
        {
            get => person.Lastname; set
            {
                person.Lastname = value;
                RaisePropertyChanged("FullName");
            }
        }

        public string FullName { get => person.FullName; }

        public PersonViewModel()
        {
            person = new Person();
            ToUpperCommand = new Command(execute: () => ToUpperCase());
        }

        private void RaisePropertyChanged(string propertyName)
        {
            //if (PropertyChanged != null)
            //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            OnPropertyChanged(propertyName);
        }

        private void ToUpperCase()
        {
            person.Firstname = person.Firstname.ToUpper();
            person.Lastname = person.Lastname.ToUpper();
            RaisePropertyChanged("FullName");
        }
    }
}
