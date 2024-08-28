using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main()
    {
        var cashRegister = new Dictionary<int, int>
        {
            { 100, 2 }, { 50, 3 }, { 10, 5 }, { 5, 6 }, { 2, 3 }, { 1, 25 } // Словарик с монетами в кассе
        };

        Console.WriteLine("Введите сумму сдачи:");
        if (!int.TryParse(Console.ReadLine(), out int changeAmount) || changeAmount <= 0)
        {
            Console.WriteLine("Некорректное значение");
            return;
        }

        var change = GetChange(cashRegister, changeAmount);

        if (change != null)
        {
            Console.WriteLine("Можно выдать сдачу:");
            foreach (var coin in change)
            {
                Console.WriteLine($"{coin.Key}: {coin.Value}");
            }
        }
        else
        {
            Console.WriteLine("Невозможно выдать сдачу - оплата кредитной картой");
        }
    }
    public static Dictionary<int, int>? GetChange(Dictionary<int, int> cashRegister, int changeAmount)
    {
        var result = new Dictionary<int, int>(); // Монеты, которые будут использованы для выдачи сдачи

        // Сортируем монеты по убыванию номинала
        foreach (var coin in cashRegister.OrderByDescending(x => x.Key))
        {
            int coinValue = coin.Key;
            int availableCoins = coin.Value;
            int neededCoins = Math.Min(changeAmount / coinValue, availableCoins);
            if (neededCoins > 0)
            {
                result[coinValue] = neededCoins;
                changeAmount -= neededCoins * coinValue;
            }
            if (changeAmount == 0) // При выдаче всей сдачи, возвращаем результат
                return result;
        }
        return null; // Возвращаем null, если не вышло собрать сдачу
    }
}