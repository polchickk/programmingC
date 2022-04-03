using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class CorrespondenceStudent : Student
    {
        public string WorkPlace;
        public string Position;

        public CorrespondenceStudent(string name, string surname, string number, string group, string institute, Degree directionOfStudy, string workPlace, string position) 
            : base(name, surname, number, group, institute, directionOfStudy)
        {
            WorkPlace = workPlace;
            Position = position;
        }

        public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Студент заочного обучения работает в {WorkPlace}");
            Console.WriteLine($"Занимаемая должность: {Position}");
        }
    }
}
