using System;

namespace Strategy_pattern
{
    /// <summary>
    /// Strategy interface declaring the Execute method.
    /// All concrete strategies must implement this.
    /// </summary>
    public interface IOperationsStrategy
    {
        int Execute(int a, int b);
    }

    /// <summary>
    /// Concrete strategy for performing addition.
    /// </summary>
    public class AdditionStrategy : IOperationsStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }

    /// <summary>
    /// Concrete strategy for performing subtraction.
    /// </summary>
    public class SubtractionStrategy : IOperationsStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }

    /// <summary>
    /// Concrete strategy for performing multiplication.
    /// </summary>
    public class MultiplicationStrategy : IOperationsStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }

    /// <summary>
    /// Concrete strategy for performing division.
    /// Includes validation to prevent divide-by-zero errors.
    /// </summary>
    public class DivisionStrategy : IOperationsStrategy
    {
        public int Execute(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return a / b;
        }
    }

    /// <summary>
    /// Concrete strategy for performing modulo (remainder) operation.
    /// Includes validation to prevent modulo by zero errors.
    /// </summary>
    public class ModuloStrategy : IOperationsStrategy
    {
        public int Execute(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Modulo by zero is not allowed.");
            return a % b;
        }
    }
}
