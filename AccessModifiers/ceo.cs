using demoLibrary;

// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/access-modifiers

namespace AccessModifiers
{
    public class ceo : manager { 

        public void getconnectioninfo()
        {
            DataAccess data = new demoLibrary();
            formerLastName = "Test";
            
        }
    }

}
