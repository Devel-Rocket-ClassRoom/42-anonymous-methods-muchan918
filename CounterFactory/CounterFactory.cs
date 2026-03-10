using System;

class CounterFactory
{
    public static Func<int> CreateSimpleCounter()
    {
        int counter = 1;

        return delegate
        {
            return counter++;
        };
    }

    public static Func<int> CreateStepCounter(int step)
    {
        int counter = 0;

        return delegate
        {
            return counter += 3;
        };
    }

    public static Func<int> CreateBoundedCounter(int min, int max)
    {
        int counter = min;

        return delegate
        {
            if (counter > max) counter = min;
            return counter++;
        };
    }

    public static void CreateResettableCounter(out Func<int> next, out Action reset)
    {
        int count = 1;

        next = delegate
        {
            return count++;
        };

        reset = delegate
        {
            count = 1;
        };
    }
}