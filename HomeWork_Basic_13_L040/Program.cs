using HomeWork_Basic_13_L040;

Console.WriteLine(" ---- Home Work 13 ----\n");

var people = new List<Person>
{
    new Person (1, "Tom", 20),
    new Person (2, "Bob", 30),
    new Person (3, "Sam", 25),
    new Person (4, "Alice", 18),
    new Person (5, "Jack", 19),
    new Person (6, "Simon", 40),
    new Person (7, "Sara", 60),
    new Person (8, "Joe", 81),
    new Person (9, "Angelina", 49),
    new Person (10, "Pitt", 60)
};

Console.WriteLine("Source List");
Console.WriteLine("-------------------------------------------------");
foreach (var person in people)
{
    Console.WriteLine($"ID: {person.Id}\tNAME: {person.Name}\tAGE: {person.Age}");
}

int percent = 70;
Console.WriteLine($"\n{percent} percent of the sample from the END");
Console.WriteLine("-------------------------------------------------");
var selectedPeople = people.Top(percent);
foreach (var person in selectedPeople)
{
    Console.WriteLine($"ID: {person.Id}\tNAME: {person.Name}\tAGE: {person.Age}");
}

percent = 40;
Console.WriteLine(
    $"\n{percent} percent of the sample from the END.\n" +
    $"Sorting by descending Age");
Console.WriteLine("-------------------------------------------------");

selectedPeople = people.Top(percent, p => p.Age);
foreach (var person in selectedPeople)
{
    Console.WriteLine($"ID: {person.Id}\tNAME: {person.Name}\tAGE: {person.Age}");
}

percent = 90;
Console.WriteLine(
    $"\n{percent} percent of the sample from the END.\n" +
    $"Sorting by descending Name");
Console.WriteLine("-------------------------------------------------");

selectedPeople = people.Top(percent, p => p.Name);
foreach (var person in selectedPeople)
{
    Console.WriteLine($"ID: {person.Id}\tNAME: {person.Name}\tAGE: {person.Age}");
}