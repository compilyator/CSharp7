using System;

namespace Pattern_matching_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var humans = new Human[]
               {
                new Human("Vasya"),
                new Student("Kolya", "CS2016", 4),
                new Student("Lena", "CS2016", 5),
                new Teacher("Ivan Ivanovich", "Philosophy"),
                null
               };

            foreach (var human in humans)
            {
                Console.WriteLine(GetString(human));
            }
            Console.ReadKey();
        }

        static string GetString(Human human)
        {
            switch (human)
            {
                case Student student when student.AverageMark > 4.5:
                    return $"Good student {student.Name} from group {student.Group}";
                case Student student:
                    return $"Student {student.Name} from group {student.Group}";
                case Teacher teacher:
                    return $"Teacher {teacher.Name} which teach {teacher.Discipline}";
                case null:
                    return "Nothing to show";
                default:
                    return $"Human {human.Name}";
            }
        }
    }

    public class Human
    {
        public string Name { get; }

        public Human(string name)
        {
            Name = name;
        }
    }

    public class Student : Human
    {
        public float AverageMark { get; }

        public string Group { get; }

        public Student(string name, string group, float averageMark) : base(name)
        {
            Group = group;
            AverageMark = averageMark;
        }
    }

    public class Teacher : Human
    {
        public string Discipline { get; }

        public Teacher(string name, string discipline) : base(name)
        {
            Discipline = discipline;
        }
    }
}
