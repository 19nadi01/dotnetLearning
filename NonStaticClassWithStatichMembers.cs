
namespace CSharpLearning
{
    public class NonStaticClassWithStatichMembers
    {
        public static string StaticName = "";
        public string InstanceName = "";

        public void ModifyNamesInstanceMethod()
        {
            // instance methods can access both static and instance feilds 
            StaticName = "Static name is accessed and changed in an instance method";
            InstanceName = "Instance name is accessed and changed in an instance method";
        }

        public static void ModifyNameStaticMethod()
        {
            
            StaticName = "Static name is accessed and changed in an static method";

            // static methods can access static feilds only
            //InstanceName = "Instance name is accessed and changed in an static method";
        }

        public static string  GetStaticName()
        {
            return StaticName;
        }

        public string GetInstanceName()
        {
            // instance methods can access both static and instance feilds  
            return InstanceName;
        }

        public string GetStaticNameByInstanceMethod()
        {
            // instance methods can access both static and instance feilds 
            return StaticName;
        }

    }
}
