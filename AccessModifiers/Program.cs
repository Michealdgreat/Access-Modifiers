using demoLibrary;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

namespace AccessModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            personClass person = new personClass();
          //  DataAccess data = new DataAccess();


            person.savePerson(); // calls the dataconnection class that was instantiated. instead of calling the class directly, we called it from another class method.
            Console.ReadLine();
        }
    }


    
    // you should only have PUBLIC, PROTECTED or INTERNAL Classes
    public class modifiedDataAccess : DataAccess
    {
        public void getUnsecureConnectionInfo()
        {
            GetConnectionString();
        }
    }

}
