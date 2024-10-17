using System.Globalization;
using System.Text.Json;

namespace BirthdayProblem.Service;

public class PersonJsonAdapter
{

    public static List<Person> GetPersonsFromJson(string filePath)
    {
        using var reader = new StreamReader(filePath);

        string jsonString = File.ReadAllText(filePath);

        List<Person> persons = JsonSerializer.Deserialize<List<Person>>(jsonString);

        return persons;
    }
}
