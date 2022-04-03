using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class FullTimeStudent : Student
    {
        public int WorkPlace;
        public double Position;

        public FullTimeStudent(string name, string surname, string number, string group, string institute, Degree directionOfStudy, int satScores, double averageScore)
            : base(name, surname, number, group, institute, directionOfStudy)
        {
            WorkPlace = satScores;
            Position = averageScore;
        }

        public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Студент очного обучения с {WorkPlace}баллами ЕГЭ");
            Console.WriteLine($"Средний балл рейтинга БРС: {Position}");
        }
    }
}
