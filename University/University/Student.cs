using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class Student
    {
        public string Name;
        public string Surname;
        public readonly int Number;
        public int Group;
        public string Institute;
        public Degree DirectionOfStudy;

        public Student(string name, string surname, string number, string group, string institute, Degree directionOfStudy)
        {
            Name = name;
            Surname = surname;
            Number = int.Parse(number);
            Group = int.Parse(group);
            Institute = institute;
            DirectionOfStudy = directionOfStudy;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);

            var directionOfStudy = "";
            switch (DirectionOfStudy)
            {
                case Degree.Undergraduate:
                    directionOfStudy = "бакалавриат";
                    break;
                case Degree.Specialty:
                    directionOfStudy = "специалитет";
                    break;
                case Degree.Magistracy:
                    directionOfStudy = "магистратура";
                    break;
            }

            Console.WriteLine($"Номер зачетной книжки: {Number}. Группа: {Group}. Институт: {Institute}. Направление обучения : {DirectionOfStudy}.");
        }
    }
}
