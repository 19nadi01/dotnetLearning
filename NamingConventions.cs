
namespace CSharpLearning
{
    public class NamingConventions
    {
        // ************* LOWER CASE LETTER *************

        // private feild names 
        private string name = "Paradise";

        // variables
        int number = 13;

        // method parameters
        private void SetName(string newName)
        {
            name = newName;
        }


        // ************* UPPER CASE LETTER *************
        // classes, structs, enumerations, properties, constants, methods, and events with any accessibility, the default naming style is Pascal case

        // constant names
        const int DaysInWeek = 7;

        // public feild names
        public bool Done = true;

        // method names (public and private)
        public string GetName()
        {
            return name;
        }

        enum Colors 
        { 
            Red,
            Green,
            Yellow
        }

    }
}
