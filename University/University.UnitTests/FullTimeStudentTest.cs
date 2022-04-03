using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;
using NUnit.Framework;

namespace University.UnitTests
{
    [TestFixture]
   public class FullTimeStudentTest
    {
     [Test]
     public void ConstructorTest()
        {
            var polina = GetTestFullTimeStudent();

            Assert.AreEqual(264,polina.WorkPlace);
            Assert.AreEqual(83, polina.Position);
        }

      [Test]
      public void GetInfo_FullTimeStudent_TwoStringInfo()
        {
            var polina = GetTestFullTimeStudent();
            var lines = new[]
            {
                "Полина Павлова", 
                $"Номер зачетной книжки: 30603. Группа: 116004. Институт: УГИ. Направление обучения : бакалавриат.",
                "Студент очного обучения с 264баллами ЕГЭ",
                "Средний балл рейтинга БРС: 83"
            };
            
            var info = polina.GetInfo();

            Assert.AreEqual(2, info.Length);

            for (var i = 0; i < info.Length; i++) 
                Assert.AreEqual(lines[i], info[i]);

        }

        private FullTimeStudent GetTestFullTimeStudent()
        {
            var student = new FullTimeStudent("Полина", "Павлова", "30603", "116004", "УГИ", Degree.Undergraduate, 264, 83);

            return student;
        }
    }
}
