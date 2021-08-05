using EnsekTest.Model;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EnsekTest.Service
{
    public interface IMeterService
    {
        ProcessingResult ProcessReadings(IFormFile file);
        Account GetAccount(int accountId);
        List<Account> GetAllAccounts();
        List<AccountMeterReading> GetReading(int accountId);
        List<AccountMeterReading> GetAllReadings();

    }
}
