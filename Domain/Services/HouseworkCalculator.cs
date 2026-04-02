using AppropriationOfHouseWork.Domain.Entities;

namespace AppropriationOfHouseWork.Domain.Services
{
    public class HouseworkCalculator
    {
        public decimal CalculateAmount(HouseworkLog houseworkLog, decimal hourlyRate)
        {
            return (houseworkLog.DurationMinutes / 60m) * hourlyRate;
        }
    }
}
