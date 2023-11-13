using System.Globalization;
using csharp_exercise_abstracted_methods2.Entities;

List<Person> list = new List<Person>();
Console.Write("Enter the number of tax payers: ");
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine($"Tax payer #{i + 1} data:");
    Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    if (ch == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new PhysicalPerson(name, annualIncome, healthExpenditures));
    }
    else
    {
        Console.Write("Number of employees: ");
        int numberOfEmployees = int.Parse(Console.ReadLine());
        list.Add(new LegalPerson(name, annualIncome, numberOfEmployees));
    }
}
Console.WriteLine();
Console.WriteLine("TAXES PAID:");
double sum = 0.0;
foreach (Person person in list)
{
    Console.WriteLine(person.Name + ": R$ " + person.Tax().ToString("F2", CultureInfo.InvariantCulture));
    sum += person.Tax();
}

Console.WriteLine();
Console.WriteLine("TOTAL TAXES: $" + sum.ToString("F2"));