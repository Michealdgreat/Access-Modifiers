namespace demoLibrary
{
    public class manager : employee {

        public string getAllNames()
        {
            return $"{firstName}, {lastName}, {formerLastName}";
    }

    }
    
}
