using EnsekTest.Model;
using System.Collections.Generic;

namespace EnsekTest.Repository
{
    public interface IMeterReadRepo
    {
        int AddReading(AccountMeterReading accountMeterReading);
        Account GetAccount(int accountId);
        List<Account> GetAccounts();
        List<AccountMeterReading> GetMeterReading(int accountId);
        List<AccountMeterReading> GetMeterReadings();
    }
}
