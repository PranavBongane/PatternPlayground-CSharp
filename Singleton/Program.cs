using Singleton;

Console.WriteLine("=== Singleton Pattern Demo ===\n");

// Using MySingleton (Double-Checked Locking Singleton)
var s1 = MySingleton.GetInstance();
var s2 = MySingleton.GetInstance();

Console.WriteLine("MySingleton:");
Console.WriteLine($"s1 and s2 are same instance? {ReferenceEquals(s1, s2)}");
// Output: True

Console.WriteLine();

Console.WriteLine("=== Real-Life Singleton Example: Logger ===\n");

// Sequential logging
var logger1 = Logger.Instance;
var logger2 = Logger.Instance;

logger1.Log("Application started.");
logger2.Log("Performing initialization...");

Console.WriteLine($"\nlogger1 and logger2 are same instance? {ReferenceEquals(logger1, logger2)}");
// Output: True

Console.WriteLine("\n=== Multithreaded Logging Demo ===\n");

// Parallel logging to show thread safety
Parallel.For(0, 5, i =>
{
    Logger.Instance.Log($"Message from task {i}");
});