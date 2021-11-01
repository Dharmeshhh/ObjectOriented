using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOriented
{
    public class ObjectOrientedConcepts
    {
        public int sID;
        public string studentName;
        public string studentGrade;

        public static string collegeName;
        // Static constructor
        static ObjectOrientedConcepts()
        {
            collegeName = "Fanshawe";
        }
        
        //instance constructor
        public ObjectOrientedConcepts(int sID, string studentName, string studentGrade)
        {
            this.sID = sID;
            this.studentName = studentName;
            this.studentGrade = studentGrade;
        }

        public ObjectOrientedConcepts()
        {
            this.sID = 11;
        }





        public String Name;
        public ObjectOrientedConcepts(String Name) {
            this.Name = Name;
        }

        public void PrintName()
        {
            Console.WriteLine("Name :" + Name);
        }


        // ref keyword
        public void NameModificationsRef(ref String Name)
        {
            Name = "Megatron";
        }

        //out keyword
        public void NameModificationsOut(out String Name)
        {
            Name = "Cybertron";
        }

        //in keyword
        public void NameModificationsIn(in String Name)
        {
            Console.WriteLine(Name);
            // We cannot change the input variable cause it is read only property
        }

        // ref keyword C# 7.0 for returning object clone or so called ref return feature

        public ref String RefReturn()
        {
            return ref Name;
        }

        public static int Age()
        {
            return 24;
        }

        public static void ParamString(params String[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name {0}:{1}", i+1, names[i]);
            }
        }
        public void PrintStudent()
        {
            Console.WriteLine("College: {0}, StudentID: {1}, StudentName: {2}, StudentGrade: {3}", collegeName,sID, studentName, studentGrade);
        }
    }
}
