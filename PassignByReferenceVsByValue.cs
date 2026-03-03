
using System;

namespace CSharpLearning
{
    public static class PassignByReferenceVsByValue
    {

        // key word ref will pass the reference to the real object
        public static void ByReferenceWillChangeName(ref string name, string newName)
        {
            // will change the real object
            name = newName;
        }

        // the reference copy is passed, not the real reference to the object
        public static void ByValueWillNotChangeName(string name, string newName)
        {
            // will create a new string object and change the reference in the parameter 'name'
            name = newName;
        }

        public static void CheckByReferenceVsByValueDifference()
        {
            string name = "Sandra";
            Console.WriteLine($"Initial name: {name}");

            PassignByReferenceVsByValue.ByValueWillNotChangeName(name, "Another");
            Console.WriteLine($"Passed by value. Name unchanged: {name}");

            PassignByReferenceVsByValue.ByReferenceWillChangeName(ref name, "Another");
            Console.WriteLine($"Passed by reference. Name changed: {name}");
        }
    }
}
