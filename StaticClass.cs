
namespace CSharpLearning
{
    public static class StaticClass
    {
        // Static class should contain only static feilds and methods
        public static int Number = 1;
        public static string Name;

        public static void IncrementNumber()
        {
            Number++;
        }

        public static void SetName(string name)
        {
            Name = name; 
        }

        public static string GetName()
        {
            return Name;
        }

    }
}
