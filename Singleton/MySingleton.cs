using System;
using System.Threading.Tasks;

namespace Singleton
{
    // Example 1: Classic Singleton with Double-Checked Locking
    public class MySingleton
    {
        // Private constructor prevents external instantiation.
        private MySingleton() { }

        // Holds the single instance of the class.
        private static MySingleton? Instance;

        // Lock object used to synchronize threads during instance creation.
        private static readonly object Locker = new object();

        // Public method to provide a global access point to the single instance.
        public static MySingleton GetInstance()
        {
            if (Instance == null) // First check (no lock)
            {
                lock (Locker) // Ensure only one thread enters this block at a time
                {
                    if (Instance == null) // Second check (with lock)
                    {
                        Instance = new MySingleton();
                    }
                }
            }
            return Instance;
        }
    }

    // Example 2: Real-Life Singleton — Logger
    public class Logger
    {
        // Private constructor ensures external code cannot instantiate it.
        private Logger() { }

        // Lazy<T> ensures that the instance is created only when it's needed (lazy initialization).
        // It's also thread-safe by default, so no need to add extra locks.
        private static readonly Lazy<Logger> _instance =
            new Lazy<Logger>(() => new Logger());

        // Public property to access the single Logger instance.
        public static Logger Instance => _instance.Value;

        // Example log method
        public void Log(string message)
        {
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss.fff}] {message}");
        }
    }
}
