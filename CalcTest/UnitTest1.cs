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
            // � ���� ����� ����������� ������, ����� ����� ����� ������
            // � ����� ���� ������ ��������� 50, 5, 2, � 1 . ����� ����� � 165
            // ���������, ��� ��������� ����� ����� � ���� ���� ����� �� 10 , ���� ����� �� 5 , ���� ����� �� 2  � ����� ������ �� 1 
            var cashRegister = new Dictionary<int, int>
            {
                { 100, 0 },
                { 50, 3 }, // 3 �� 50 
                { 10, 0 },
                { 5, 2 }, // 2 �� 5 
                { 2, 2 }, // 2 �� 2 
                { 1, 1 } // 1 �� 1 
            };
            int changeAmount = 165;

            // ��������� ���������
            var expectedChange = new Dictionary<int, int>
            {
                { 50, 3 },
                { 5, 2 },
                { 2, 2 },
                { 1, 1 }
            };

            // ����� �������
            var actualChange = Program.GetChange(cashRegister, changeAmount);

            // �������� ����������
            Assert.AreEqual(expectedChange, actualChange);

        }
    }
}