using System;
using System.Collections.Generic;

class DataProcessor
{
    public int[] numbers;

    public void ForEach(Action<int> action)
    {
        foreach (int n in numbers)
        {
            action(n);
        }
    }

    public int[] Transform(Func<int, int> transformer)
    {
        int[] newNumbers = new int[numbers.Length];
        for(int i = 0; i < numbers.Length; i++)
        {
            newNumbers[i] = transformer(numbers[i]);
        }
        return newNumbers;
    }

    public List<int> Filter(Func<int, bool> predicate)
    {
        List<int> result = new List<int>();

        foreach (int n in numbers)
        {
            if (predicate(n))
            {
                result.Add(n);
            }
        }
        return result;
    }
}