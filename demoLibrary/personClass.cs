using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoLibrary
{
    public class personClass
    {

        public void savePerson()
        {
            DataAccess data = new DataAccess();
            string conn = data.GetConnectionString();
        }

        // protected type of variable allows all other child-class of the parent class to be able to use the variable.
        private protected string formerLastName = ""; //03


        public string firstName { get; set; }
        public string lastName { get; set; } //02


        private string _ssn; //01

        public string SSN
        {
            get { 
                return $"***-**-{_ssn.Substring(_ssn.Length -4)}"; 
                }
            set { 
                _ssn = value; 
                }
        }

        public void changeLastName(string newLastaname)
        {
            formerLastName = lastName;
            lastName = newLastaname;
        }
        public void SayHello()
        {
            Console.WriteLine($"Hello {firstName}");
        }
    }
    
}
