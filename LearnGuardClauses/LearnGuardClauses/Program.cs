using LearnGuardClauses;

// First, an order that works fine - the Happy Path!
var o = new Order("Some Order", 1, 10, (decimal)0.25, DateTime.Now);
Console.WriteLine(o.ToString());

// Now, let's start messing things up
Console.WriteLine("Starting to mess things up, passing in a name that is empty");
try
{
    var badName = new Order(string.Empty, 1, 10, (decimal)0.25, DateTime.Now);
    Console.WriteLine(badName.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// mess up something in the middle
try
{
    var badMax = new Order("The Name is OK", 1, 0, (decimal)0.25, DateTime.Now);
    Console.WriteLine(badMax.ToString());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// now mess up a couple of things
try
{
    var coupleOfBadThings = new Order("Two Bad Parameters", -1, 10, (decimal)-0.25, DateTime.Now);
    Console.WriteLine(coupleOfBadThings.ToString());
}
catch (Exception ex)
{
    // Not surprisingly, if two or more things are bad, only the first one will be reported on
    Console.WriteLine(ex.Message);
}

