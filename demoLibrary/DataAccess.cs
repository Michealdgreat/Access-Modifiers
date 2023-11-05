namespace demoLibrary
{
    public class DataAccess
    {
        // protected internal class allows local classes and method to have access and Only allowed acces from ecternal method or class that inherit fron itt.
        protected internal string GetConnectionString() // 04, internal class; all the class library can access
        {
            return "Sensitive data";
        }
    }
    
}
