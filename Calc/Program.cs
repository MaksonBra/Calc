using System;
using System.Collections.Generic;
using System.Linq;


public class Program
{
    static void Main()
    {
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