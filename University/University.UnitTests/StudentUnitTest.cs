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
    public class StudentUnitTest
    {
        [Test]
        public void ConstructorTest()
        {
            var polina = CreateTestStudent();

            Assert.AreEqual("Polina", polina.Name);
            Assert.AreEqual("Pavlova", polina.Surname);
            Assert.AreEqual(30603, polina.Number);
            Assert.AreEqual(116004, polina.Group);
            Assert.AreEqual("УГИ", polina.Institute);
            Assert.AreEqual(Degree.Undergraduate, polina.DirectionOfStudy);
        }

        [Test]
        public void ToString_Student_NameSpaceSurname()
        {
            var polina = CreateTestStudent();
            Assert.AreEqual("Polina Pavlova", polina.ToString());
        }

        private Student CreateTestStudent()
        {
            return new Student("Polina", "Pavlova", "30603", "116004", "УГИ", Degree.Undergraduate);
        }

        [Test]
        public void GetInfo_Student_TwoStringsInfo()
        {
            var polina = CreateTestStudent();

            var info = polina.GetInfo();

            Assert.AreEqual(2, info.Length);
            Assert.AreEqual("Polina Pavlova", info[0]);
            Assert.AreEqual($"Номер зачетной книжки: 30603. Группа: 116004. Институт: УГИ. Направление обучения : бакалавриат.", info[1]); 
        }
    }
}

