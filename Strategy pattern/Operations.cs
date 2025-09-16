using System;

namespace Strategy_pattern
{
    /// <summary>
    /// Context class that uses a strategy object (IOperationsStrategy).
    /// It delegates the execution of the operation to the chosen strategy.
    /// </summary>
    public class Operations
    {
        // Reference to a strategy instance
        private IOperationsStrategy _strategy;

        /// <summary>
        /// Constructor sets the strategy to be used.
        /// </summary>
        /// <param name="strategy">Concrete strategy (e.g., AdditionStrategy, SubtractionStrategy).</param>
        public Operations(IOperationsStrategy strategy)
        {
            _strategy = strategy;
        }

        /// <summary>
        /// Executes the current strategy with the given operands.
        /// </summary>
        /// <param name="a">First operand</param>
        /// <param name="b">Second operand</param>
        /// <returns>Result of the operation defined by the strategy</returns>
        public int Execute(int a, int b)
        {
            return _strategy.Execute(a, b);
        }

        /// <summary>
        /// Allows switching the strategy at runtime.
        /// </summary>
        /// <param name="strategy">New strategy to apply</param>
        public void SetStrategy(IOperationsStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
