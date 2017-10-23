using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Mentor_Group
{
    class Student
    {
        public string Name { get; set; }
        public List<string> Comment { get; set; }
        public List<DateTime> Date { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var inputNameDates = Console.ReadLine();
            var nameDateDict = new Dictionary<string, List<DateTime>>();
            while (inputNameDates != "end of dates")
            {
                var tokens = inputNameDates.Split(' ', ',');
                var name = tokens[0];
                var dates = tokens.Skip(1).Select(a => DateTime.ParseExact(a, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();

                if (!nameDateDict.ContainsKey(name))
                {
                    nameDateDict.Add(name, new List<DateTime>());
                }
                nameDateDict[name].AddRange(dates);
                inputNameDates = Console.ReadLine();
            }

            var inputComment = Console.ReadLine();
            var nameCommentsDict = new Dictionary<string, List<string>>();
            while (inputComment != "end of comments")
            {
                var tokenss = inputComment.Split('-');
                var student = tokenss[0];

                var comment = tokenss[1];
                if (!nameDateDict.ContainsKey(student))
                {
                    inputComment = Console.ReadLine();
                    continue;
                }

                if (!nameCommentsDict.ContainsKey(student))
                {
                    nameCommentsDict.Add(student, new List<string>());
                }
                nameCommentsDict[student].Add(comment);
                inputComment = Console.ReadLine();
            }

            var studentList = new List<Student>();
            foreach (var student in nameDateDict)
            {
                var name = student.Key;
                var dates = student.Value;
                List<string> studentComments = new List<string>();
                if (nameCommentsDict.ContainsKey(name))
                {
                    studentComments = nameCommentsDict[name];
                }
                Student currentStudent = new Student()
                {
                    Name = name,
                    Date = dates,
                    Comment = studentComments
                };
                studentList.Add(currentStudent);
            }

            foreach (var student in studentList.OrderBy(x => x.Name))
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                if (student.Comment.Count > 0)
                {
                    Console.WriteLine($"- {string.Join("\r\n- ", student.Comment)}");
                }
                Console.WriteLine("Dates attended:");
                if (student.Date.Count > 0)
                {
                    foreach (var date in student.Date.OrderBy(x => x.Date))
                    {
                        Console.WriteLine($"-- {date:dd/MM/yyyy}");
                    }
                }
            }
        }
    }
}
