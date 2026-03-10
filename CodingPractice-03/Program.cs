using System;
using System.Diagnostics;

Calculator anonymous = delegate (int x)
{
    return x * x;
};

Calculator lambda1 = (int x) =>
{
    return x * x;
};

Calculator lambda2 = x => x * x;

Console.WriteLine($"익명 메서드: {anonymous(5)}");
Console.WriteLine($"람다식 (블록): {lambda1(5)}");
Console.WriteLine($"람다식 (표현식): {lambda2(5)}");

EventHandler handler1 = delegate
{
    Console.WriteLine("이벤트 처리됨");
};

// 람다식: 매개변수 생략 불가능
// EventHandler handler2 = () =>    // 컴파일 오류!
// {
//     Console.WriteLine("이벤트 처리됨");
// };

// 람다식: 매개변수를 명시해야 함 (사용하지 않더라도)
EventHandler handler2 = (sender, e) =>
{
    Console.WriteLine("이벤트 처리됨");
};

handler1(null, EventArgs.Empty);
handler2(null, EventArgs.Empty);

GameEvent onScoreChange = delegate { };
GameEvent onGameOver = delegate { };

onScoreChange("점수 변경", 100);
onGameOver("게임 종료", 0);

onScoreChange += delegate (string name, int value)
{
    Console.WriteLine($"[이벤트] {name}: {value}");
};

onScoreChange("점수 변경", 500);

int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

ProcessData(numbers, delegate (int n)
{
    sum += n;
    Console.WriteLine($"처리 중: {n}, 누적: {sum}");
});

void ProcessData(int[] data, Action<int> callback)
{
    foreach (int item in data)
    {
        callback(item);
    }
}

delegate int Calculator(int x);
delegate void EventHandler(object sender , EventArgs e);
delegate void GameEvent(string eventName, int value);