using AF.DateTime;

namespace AF.DTConsumer
{
    public class MyConsumer
    {
        public required IDateTime _dateTime { get; set; }

        public string WriteDTNow()
        {
            return $"The current date time is {_dateTime.Now}";
        }

        public string WriteDTNextWeek()
        {
            System.DateTime today = _dateTime.Now;

            return $"Tomorrow it will be {today.AddDays(7)}";  
        }
    }
}
