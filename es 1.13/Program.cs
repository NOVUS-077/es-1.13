using System.Diagnostics;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Thread t1 = new Thread(() =>
{
    Thread.Sleep(3000);
});

Thread t2 = new Thread(() =>
{
    Thread.Sleep(4000);
});

Thread t3 = new Thread(() =>
{
    Thread.Sleep(5000);
});

t1.Start();
t2.Start();
t3.Start();
t1.Join();
t2.Join();
t3.Join();

stopwatch.Stop();
Console.WriteLine("Totale tempo di esecuzione: ");
Console.WriteLine($" {stopwatch.ElapsedMilliseconds} ms");
Console.WriteLine($"{stopwatch.Elapsed.TotalSeconds} secondi");