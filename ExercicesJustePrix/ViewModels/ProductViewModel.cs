using ExercicesJustePrix.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ExercicesJustePrix.ViewModels
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        public Product product;

        private Func<string, string, string, Task> alertAction;

        public event PropertyChangedEventHandler PropertyChanged;

        private int guessPrice;

        public ICommand CheckPriceCommand { get; set; }
        
        public string Title { get => product.Title; }
        public string Description { get => product.Description; }
        public string ImgUrl { get => product.ImgUrl; }
        public int Price { get => product.Price; }
        public int GuessPrice
        {
            get => guessPrice; set
            {
                guessPrice = value;
                if (guessPrice == product.Price)
                {
                    Result = "Good";
                    RaisePropertyChanged("Result");
                    alertAction("Gagné", "C'est la bonne réponse", "Ok");
                }
                else
                {
                    Result = "Wrong";
                    RaisePropertyChanged("Result");
                }
            }
        }

        public string Result { get; set; }
        public string Hint { get; set; }

        public ProductViewModel(Func<string, string, string, Task> alertA)
        {
            product = new Product("Télévision 4k", "C'est une super Télé qui coute la blinde !", new Random().Next(0, 2000), "https://m.media-amazon.com/images/I/71CJ6zGYBDL._AC_SL1500_.jpg");
            alertAction = alertA;
            CheckPriceCommand = new Command(execute: () => CheckPrice());
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CheckPrice()
        {
            if (guessPrice > product.Price)
            {
                Hint = "C'est moins !";
                RaisePropertyChanged("Hint");
            }
            else if (guessPrice < product.Price)
            {
                Hint = "C'est plus !";
                RaisePropertyChanged("Hint");
            }
            else
            {
                Hint = "";
                RaisePropertyChanged("Hint");
            }
        }
    }
}
