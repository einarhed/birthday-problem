namespace BirthdayProblem.Service;

public class BirthdayService
{
    private readonly DateTime _today;

    public BirthdayService(DateTime today)
    {
        _today = today;
    }

    public bool IsBirthdayToday(DateTime birthday)
    {
        if (birthday.Month == 2 && birthday.Day == 29)
        {
            // if leapyear and birthday is on 29th of February
            if (DateTime.IsLeapYear(_today.Year))
            {
                if (_today.Day == birthday.Day)
                {
                    return true;
                }
                return false;
            }

            if (_today.Month == 2 && _today.Day == 28)
            {
                return true;
            }
        }

        return birthday.Month == _today.Month && birthday.Day == _today.Day;
    }
}
