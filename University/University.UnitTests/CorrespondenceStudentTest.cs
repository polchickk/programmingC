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
    public class CorrespondenceStudentTest
    {
        [Test]
        public void ConstructorTest()
        {
            var polina = GetTestCorrespondenceStudentTest();

            Assert.AreEqual("магазине", polina.WorkPlace);
            Assert.AreEqual("менеджер", polina.Position);
        }

        [Test]
        public void GetInfo_CorrespodenceStudent_TwoStringInfo()
        {
            var polina = GetTestCorrespondenceStudentTest();
            var lines = new[]
            {
                "Полина Павлова",
                $"Номер зачетной книжки: 30603. Группа: 116004. Институт: УГИ. Направление обучения : бакалавриат.",
                "Студент заочного обучения работает в магазине ",
                "Занимаемая должность: мменеджер"
            };

            var info = polina.GetInfo();

            Assert.AreEqual(2, info.Length);

            for (var i = 0; i < info.Length; i++)
                Assert.AreEqual(lines[i], info[i]);

        }

        private CorrespondenceStudent GetTestCorrespondenceStudentTest()
        {
            var student = new CorrespondenceStudent("Полина", "Павлова", "30603", "116004", "УГИ", Degree.Undergraduate, "магазине", "менеджер");

            return student;
        }
    }
}
