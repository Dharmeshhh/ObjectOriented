using System;

namespace ObjectOriented
{
   
    public class ObjectOrientedMain 
    {
        public static void Main()
        {
            ObjectOrientedConcepts o = new ObjectOrientedConcepts("Dharmesh");
            o.PrintName(); //op Dharmesh
            o.NameModificationsRef(ref o.Name);
            o.PrintName(); //op Megatron
            o.NameModificationsOut(out o.Name /*change value of object entity from here so Megatron will be replaced by cybertron inside the function cause we are passing reference as a out argument*/);
            o.PrintName(); //op cybertron
            ref String refName = ref o.RefReturn();
            refName = "Optimus Prime"; // we are changing output copy 
            o.PrintName();
            Console.WriteLine("{0} Age:{1}", refName, ObjectOrientedConcepts.Age());
            Console.ReadKey();
        }
    }
}
