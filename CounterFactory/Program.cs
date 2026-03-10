using System;

Console.WriteLine("=== 단순 카운터 ===");
Func<int> counter1 = CounterFactory.CreateSimpleCounter();
for(int i = 0; i < 5; i++)
{
    Console.Write($"{counter1()} ");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("=== 스텝 카운터 (step=3) ===");
Func<int> counter2 = CounterFactory.CreateStepCounter(3);
for (int i = 0; i < 4; i++)
{
    Console.Write($"{counter2()} ");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("=== 범위 카운터 (1~3) ===");
Func<int> counter3 = CounterFactory.CreateBoundedCounter(1, 3);
for (int i = 0; i < 7; i++)
{
    Console.Write($"{counter3()} ");
}
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("=== 리셋 가능 카운터 ===");
Func<int> next;
Action reset;

CounterFactory.CreateResettableCounter(out next, out reset);
Console.Write("호출: ");
Console.Write($"{next()} ");
Console.Write($"{next()} ");
Console.Write($"{next()} ");

reset();

Console.Write("\n리셋 후: ");
Console.Write($"{next()} ");
Console.Write($"{next()} ");