using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace CalcTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        static void Test2()
        {
            // Этот тест проверяет ситуацию, когда сдачу выдать невозможно 
            // В кассе есть одна монета номиналом 5  и две монеты номиналом 1, а сумма сдачи — 7 
            // Ожидается, что функция вернёт null, так как невозможно собрать нужную сумму из имеющихся монет
            var cashRegister = new Dictionary<int, int>
            {
                { 100, 0 },
                { 50, 0 },
                { 10, 0 },
                { 5, 1 },   // 1 по 5 
                { 2, 0 },
                { 1, 2 }    // 2 по 1
            };
            int changeAmount = 7;

            // Ожидаемый результат: null
            var expectedChange = null as Dictionary<int, int>;

            // Вызов функции
            var actualChange = Program.GetChange(cashRegister, changeAmount);

            // Проверка результата
            Assert.AreEqual(expectedChange, actualChange);
        }
    }
}