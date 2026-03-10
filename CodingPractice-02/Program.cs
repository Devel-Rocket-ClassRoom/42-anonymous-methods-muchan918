using System;

Calculator calc = delegate (int x)
{
    return x * x;
};

Console.WriteLine(calc(5));

int factor = 3;

Func<int, int> multiplier = delegate (int n)
{
    return n * factor;
};

Console.WriteLine(multiplier(10));

factor = 2;

multiplier = delegate (int n)
{
    return n * factor;
};
Console.WriteLine($"factor = 2일 때: {multiplier(5)}");

factor = 10;
Console.WriteLine($"factor = 10일 때: {multiplier(5)}");

int counter = 0;

Action increment = delegate
{
    counter++;
    Console.WriteLine($"현재 카운터: {counter}");
};

increment();
increment();
increment();

Console.WriteLine($"최종 카운터: {counter}");

Func<int> counter1 = CreateCounter();
Func<int> counter2 = CreateCounter();

Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter1: {counter1()}");
Console.WriteLine($"counter2: {counter2()}");
Console.WriteLine($"counter2: {counter2()}");

Func<int> CreateCounter()
{
    int count = 0;
    return delegate
    {
        count++;
        return count;
    };
}

delegate int Calculator(int x);