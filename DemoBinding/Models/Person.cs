using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBinding.Models
{
    public class Person
    {
        private string _firstname;
        private string _lastname;

        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }

        public string FullName => Firstname + " " + Lastname;
    }
}
