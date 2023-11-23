using LearnGuardClauses;

// First, an order that works fine - the Happy Path!
var o = new Order("Some Order", 1, 10, (decimal)0.25, DateTime.Now);
Console.WriteLine(o.ToString());

// Now, let's start messing things up
var badName = new Order(string.Empty, 1, 10, (decimal)0.25, DateTime.Now);
Console.WriteLine(badName.ToString());