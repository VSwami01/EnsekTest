using EnsekTest.Helper;
using EnsekTest.Model;
using EnsekTest.Repository;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EnsekTest.Service
{
    public class MeterService : IMeterService
    {
        IMeterReadRepo _meterReadRepo;

        public MeterService(IMeterReadRepo meterReadRepo)
        {
            _meterReadRepo = meterReadRepo;
        }
       

        public ProcessingResult ProcessReadings(IFormFile file)
        {
            var input  = Csv.GetMeterReadingFromCSV(file);

            var accountMeterReadings = Mapper.MeterReadingCsvDTO_To_AccountMeterReading(input);

            int success = 0;

            // Validate each reading
            foreach (AccountMeterReading newReading in accountMeterReadings)
            {
                if (Validation.IsValidReading(_meterReadRepo, newReading))
                    if(_meterReadRepo.AddReading(newReading) > 0)
                        success ++;
            }

            return new ProcessingResult()
            {
                Success = success,
                Fail = input.Count - success
            };
        }

        public Account GetAccount(int accountId)
        {
            return _meterReadRepo.GetAccount(accountId);
        }
        public List<Account> GetAllAccounts()
        {
            return _meterReadRepo.GetAccounts();
        }
        public List<AccountMeterReading> GetReading(int accountId)
        {
            return _meterReadRepo.GetMeterReading(accountId);
        }
        public List<AccountMeterReading> GetAllReadings()
        {
            return _meterReadRepo.GetMeterReadings();
        }
    }
}
