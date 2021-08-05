using EnsekTest.Model;
using System;
using System.Collections.Generic;

namespace EnsekTest.Helper
{
    public static class Mapper
    {
        public static List<AccountMeterReading> MeterReadingCsvDTO_To_AccountMeterReading(List<MeterReadingCsvDTO> meterReadingCsvDTOList)
        {
            List<AccountMeterReading> accountMeterReading = new List<AccountMeterReading>();

            int accountId;
            DateTime meterReadingDateTime;
            int meterReadValue;

            foreach (MeterReadingCsvDTO reading in meterReadingCsvDTOList)
            {
                if (int.TryParse(reading.AccountId, out accountId)
                    && DateTime.TryParse(reading.MeterReadingDateTime, out meterReadingDateTime)
                    && int.TryParse(reading.MeterReadValue, out meterReadValue))
                    accountMeterReading.Add(new AccountMeterReading()
                    {
                        AccountId = accountId,
                        MeterReadingDateTime = meterReadingDateTime,
                        MeterReadValue = meterReadValue.ToString().PadLeft(5, '0')
                    }); ;
            }
            return accountMeterReading;
        }
    }
}
