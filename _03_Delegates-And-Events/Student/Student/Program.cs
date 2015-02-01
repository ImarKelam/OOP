using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Pesho", 20);
            student.ChangeEvent += (string str) => Console.WriteLine(str);

            student.Age = 22;
            student.Name = "Kiro";
        }
    }
}
