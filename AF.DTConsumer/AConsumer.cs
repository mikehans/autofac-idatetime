using AF.DateTime;

namespace AF.DTConsumer
{
    public class AConsumer
    {
        readonly IDateTime dt;
        public AConsumer(IDateTime dt)
        {
            this.dt = dt;
        }

        public string GetTomorrow()
        {
            System.DateTime d = dt.Now;

            return $"Tomorrow will be {d.AddDays(1)}";
        }
    }
}
