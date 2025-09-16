using Prototype_pattern;

var original = new Person("Alice", 30, new Address("Paris", "France"));

// Using Clone() -> shallow copy
var clone = (Person)original.Clone();

// Using shallowClone() -> shallow copy
var shallow = original.shallowClone();

// Using deepClone() -> deep copy
var deep = original.deepClone();

Console.WriteLine("Initial state:");
Console.WriteLine("Original: " + original);
Console.WriteLine("Clone   : " + clone);
Console.WriteLine("Shallow : " + shallow);
Console.WriteLine("Deep    : " + deep);

Console.WriteLine("\n-- Modify Clone's Address --");
clone.Address.City = "London";

Console.WriteLine("Original: " + original);
Console.WriteLine("Clone   : " + clone);
Console.WriteLine("Shallow : " + shallow);
Console.WriteLine("Deep    : " + deep);

Console.WriteLine("\n-- Modify Shallow's Address --");
shallow.Address.City = "Berlin";

Console.WriteLine("Original: " + original);
Console.WriteLine("Clone   : " + clone);
Console.WriteLine("Shallow : " + shallow);
Console.WriteLine("Deep    : " + deep);

Console.WriteLine("\n-- Modify Deep's Address --");
deep.Address.City = "Rome";

Console.WriteLine("Original: " + original);
Console.WriteLine("Clone   : " + clone);
Console.WriteLine("Shallow : " + shallow);
Console.WriteLine("Deep    : " + deep);