using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    public class SrudentOfTargetedTraining : Student
    {
        public string CompanyName;
        public int SumOfEducation;

        public SrudentOfTargetedTraining(string name, string surname, string number, string group, string institute, Degree directionOfStudy, string companyName, int sumOfEducation)
            : base(name, surname, number, group, institute, directionOfStudy)
        {
            CompanyName = companyName;
            SumOfEducation = sumOfEducation;

        }

        public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Студент целевого обучения будет работает в {CompanyName}");
            Console.WriteLine($"Сумма обучение: {SumOfEducation}");
        }
    }
}
