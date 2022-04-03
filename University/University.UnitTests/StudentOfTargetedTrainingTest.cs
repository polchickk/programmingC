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
    public class SrudentOfTargetedTrainingTest
    {
        [Test]
        public void ConstructorTest()
        {
            var polina = GetTestSrudentOfTargetedTrainingTest();

            Assert.AreEqual("концерне Калашников", polina.CompanyName);
            Assert.AreEqual(200000, polina.SumOfEducation);
        }

        [Test]
        public void GetInfo_SrudentOfTargetedTraining_TwoStringInfo()
        {
            var polina = GetTestSrudentOfTargetedTrainingTest();
            var lines = new[]
            {
                "Полина Павлова",
                $"Номер зачетной книжки: 30603. Группа: 116004. Институт: УГИ. Направление обучения : бакалавриат.",
                "Студент целевого обучения будет работает в концерне Калашников",
                "Сумма обучение: 200000"
            };

            var info = polina.GetInfo();

            Assert.AreEqual(2, info.Length);

            for (var i = 0; i < info.Length; i++)
                Assert.AreEqual(lines[i], info[i]);

        }

        private SrudentOfTargetedTraining GetTestSrudentOfTargetedTrainingTest()
        {
            var student = new SrudentOfTargetedTraining("Полина", "Павлова", "30603", "116004", "УГИ", Degree.Undergraduate, "концерне Калашников", 200000);

            return student;
        }
    }
}
