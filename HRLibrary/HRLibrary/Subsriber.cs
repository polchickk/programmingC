using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Subsriber
    {
        public string Name;
        public string Surname;
        public string TelephoneNumber;
        public readonly int Number;
        public string NameOfTheTariff;
        public double Sum;
        public PaymentType Payment;

        public Subsriber(string name, string surname, string telephonenumber, int number)
        {
            Name = name;
            Surname = surname;
            TelephoneNumber = telephonenumber;
            Number = number;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);

            var payment = "";
            switch (Payment)
            {
                case PaymentType.Credit:
                    payment = "кредит";
                    break;
                case PaymentType.Prepayment:
                    payment = "предоплата";
                    break;
            }

            Console.WriteLine($"Телефонный номер: {TelephoneNumber}. Номер договора: {Number}. Название тарифа: {NameOfTheTariff}. Тип оплаты: {payment}. Сумма на личном счете: {Sum}.");
        }
    }
}
