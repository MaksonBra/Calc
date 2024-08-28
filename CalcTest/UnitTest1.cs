using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace CalcTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        static void Test1()
        {
            // В этом тесте проверяется случай, когда сдачу можно выдать
            // В кассе есть монеты номиналом 50, 5, 2, и 1 . Сумма сдачи — 165
            // Ожидается, что программа вернёт сдачу в виде трех монет по 10 , двух монет по 5 , двух монет по 2  и одной монеты по 1 
            var cashRegister = new Dictionary<int, int>
            {
                { 100, 0 },
                { 50, 3 }, // 3 по 50 
                { 10, 0 },
                { 5, 2 }, // 2 по 5 
                { 2, 2 }, // 2 по 2 
                { 1, 1 } // 1 по 1 
            };
            int changeAmount = 165;

            // Ожидаемый результат
            var expectedChange = new Dictionary<int, int>
            {
                { 50, 3 },
                { 5, 2 },
                { 2, 2 },
                { 1, 1 }
            };

            // Вызов функции
            var actualChange = Program.GetChange(cashRegister, changeAmount);

            // Проверка результата
            Assert.AreEqual(expectedChange, actualChange);

        }
    }
}