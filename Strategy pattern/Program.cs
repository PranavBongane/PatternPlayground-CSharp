using Strategy_pattern;


int a = 10, b = 5;

// Start with Addition strategy
Operations operation = new Operations(new AdditionStrategy());
Console.WriteLine($"Addition: {operation.Execute(a, b)}");

// Switch to Subtraction at runtime
operation.SetStrategy(new SubtractionStrategy());
Console.WriteLine($"Subtraction: {operation.Execute(a, b)}");

// Switch to Multiplication
operation.SetStrategy(new MultiplicationStrategy());
Console.WriteLine($"Multiplication: {operation.Execute(a, b)}");

// Switch to Division
operation.SetStrategy(new DivisionStrategy());
Console.WriteLine($"Division: {operation.Execute(a, b)}");

// Switch to Modulo
operation.SetStrategy(new ModuloStrategy());
Console.WriteLine($"Modulo: {operation.Execute(a, b)}");

