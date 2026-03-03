
namespace CSharpLearning
{
    /*
     * Struct is a value type, declared with 'sctruct' key word
     * Meanwhile: class is a reference type and is declared with 'class' key word 
     * Both struct and class can have fields, properties, constructors and methods
     * byte, short, int, double, decimal, bool, char are value (primitive) types declared as scruct
     * DateTime is also a value type, declared as struct 
     */
    public struct Point
    {
        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }

    }
}
