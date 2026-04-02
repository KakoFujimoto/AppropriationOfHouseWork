using AppropriationOfHouseWork.Domain.Entities;
using AppropriationOfHouseWork.Infrastructure.Data;

namespace AppropriationOfHouseWork.Application.Services
{
    public class HouseworkAppService
    {
        private readonly AppDbContext _dbContext;

        public HouseworkAppService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<HouseworkLog> AddHouseworkLogAsync(HouseworkLog houseworkLog, CancellationToken cancellationToken = default)
        {
            _dbContext.HouseworkLogs.Add(houseworkLog);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return houseworkLog;
        }
    }
}
