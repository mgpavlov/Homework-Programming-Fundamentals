using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Average_Grades
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double Average => Grades.Average();
        }
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");

            var dict = new Dictionary<string, string>();
            var n = int.Parse(lines[0]);
            List<Student> students = new List<Student>();

            for (int k = 1; k <= n; k++)
            {
                Student student = new Student();
                string[] inputArgs = lines[k].Split();
                student.Name = inputArgs[0];
                student.Grades = inputArgs.Skip(1).Select(double.Parse).ToList();

                students.Add(student);
            }

            students.Where(s => s.Average >= 5.00).OrderBy(s => s.Name).ThenByDescending(s => s.Average).ToList().ForEach(s => File.AppendAllText("../../output.txt",($"{s.Name} -> {s.Average:f2}"+ Environment.NewLine)));
        }
    }
}
