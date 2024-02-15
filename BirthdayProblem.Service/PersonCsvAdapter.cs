namespace BirthdayProblem.Service;

using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

public class PersonCsvAdapter : ClassMap<Person>
{
    public PersonCsvAdapter()
    {
        Map(x => x.Name).Name("Name");
        Map(x => x.DateOfBirth).Name("DateOfBirth").TypeConverterOption.Format("yyyy-MM-dd");
    }

    public static List<Person> GetPersonsFromCsv(string filePath)
    {
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture) { HasHeaderRecord = true });
        csv.Context.RegisterClassMap<PersonCsvAdapter>();

        return csv.GetRecords<Person>().ToList();
    }
}
