namespace BirthdayProblem.Service;

class Program
{
    static void Main()
    {
        var today = DateTime.Today;
        var birthdayService = new BirthdayService(today);

        List<Person> persons = PersonCsvAdapter.GetPersonsFromCsv("BirthdayProblem.Service/person.csv");

        foreach (Person p in persons)
        {
            if (birthdayService.IsBirthdayToday(p.DateOfBirth))
            {
                Console.WriteLine($"Happy Birthday, {p.Name}!");
            }
        }
    }
}
