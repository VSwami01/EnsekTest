using EnsekTest.Model;
using EnsekTest.Repository;
using System;
using System.Collections.Generic;

namespace EnsekTest.Helper
{
    public static class Validation
    {
        const int MIN_READING = 0;
        const int MAX_READING = 99999;
        public static bool IsValidReading(IMeterReadRepo meterReadRepo, AccountMeterReading newReading)
        {
            //Validation rules
            //1. Account should exist
            //2. Reading should be new (no reading with same Account and DatTime)
            //3. Format NNNNN (so assuming range is 0 to 99999)

            List<Account> accounts = meterReadRepo.GetAccounts();

            List<AccountMeterReading> meterReadings = meterReadRepo.GetMeterReadings();

            return (accounts.FindIndex(account => account.AccountId == newReading.AccountId) >= 0
                    && meterReadings.FindIndex(meterReading => meterReading.AccountId == newReading.AccountId && meterReading.MeterReadingDateTime == newReading.MeterReadingDateTime) < 0
                    && Convert.ToInt32(newReading.MeterReadValue) >= MIN_READING && Convert.ToInt32(newReading.MeterReadValue) <= MAX_READING);
        }
    }
}
