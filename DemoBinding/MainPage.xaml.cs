using DemoBinding.ViewModels;

namespace DemoBinding
{
    public partial class MainPage : ContentPage
    {
        //string result;
        //Person person;

        //public string Firstname { get => person.Firstname; set => person.Firstname = value; }
        //public string Lastname { get => person.Lastname; set => person.Lastname = value; }

        //public string FullName { get => person.FullName; }

        public MainPage()
        {
            InitializeComponent();
            ValidButton.Clicked += OnButtonClicked;
            //person = new Person();
            BindingContext = new PersonViewModel();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            //result = EditorFirstname.Text + " " + EditorLastname.Text;
            //    person.Firstname = EditorFirstname.Text;
            //    person.Lastname = EditorLastname.Text;
            //    Result.Text = person.FullName;
        }
    }
}