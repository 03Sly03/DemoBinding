using ExercicesJustePrix.Models;
using ExercicesJustePrix.ViewModels;

namespace ExercicesJustePrix
{
    public partial class MainPage : ContentPage
    {
        //Product tvProduct = new Product()
        //{
        //    Title = "Télévision 4k",
        //    Description = "C'est une super Télé qui coute la blinde !",
        //    Price = 1245
        //};

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new ProductViewModel(DisplayAlert);
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{

        //}
    }
}