using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

DataProcessor dataProcessor = new DataProcessor();
dataProcessor.numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

Console.WriteLine("=== 원본 배열 출력 ===");
dataProcessor.ForEach(delegate (int i)
{
    Console.Write($"{i} ");
});
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("=== 2배로 변환 ===");
int [] newNumbers = dataProcessor.Transform(delegate (int i)
{
    return i * 2;
});
Console.WriteLine(string.Join(" ", newNumbers));
Console.WriteLine();

Console.WriteLine("=== 짝수만 필터링 ===");
List<int> evens = dataProcessor.Filter(delegate (int i)
{
    return i % 2 == 0;
});
Console.WriteLine(string.Join(" ", evens));
Console.WriteLine();

Console.WriteLine("=== 합계 계산 ===");
int sum = dataProcessor.Reduce(delegate (int a, int b)
{
    return a + b;
}, 0);
Console.WriteLine($"합계: {sum}");
