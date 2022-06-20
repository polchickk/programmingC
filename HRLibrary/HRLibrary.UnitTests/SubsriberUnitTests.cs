using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HRLibrary;


namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class SubsriberUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var max = CreateTestSubsriber();

            Assert.AreEqual("Max", max.Name);
            Assert.AreEqual("Ramen", max.Surname);
            Assert.AreEqual("891234567890",max.TelephoneNumber);
            Assert.AreEqual(258496, max.Number);
            //Assert.AreEqual("Best", max.NameOfTheTariff);
            //Assert.AreEqual(PaymentType.Credit, max.Payment);
            //Assert.AreEqual(8964.56, max.Sum);

        }

        [Test]
        public void ToString_Subsriber_NameSpaceSurname()
        {
            var max = CreateTestSubsriber();
            Assert.AreEqual("Max Ramen", max.ToString());
        }
        private Subsriber CreateTestSubsriber()
        {
            return new Subsriber("Max", "Ramen", "891234567890", 258496 );
        }
    }
}
