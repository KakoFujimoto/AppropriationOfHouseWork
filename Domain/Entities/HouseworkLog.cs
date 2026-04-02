namespace AppropriationOfHouseWork.Domain.Entities
{
    public class HouseworkLog
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int DurationMinutes => (int)(EndTime - StartTime).TotalMinutes;
    }
}
