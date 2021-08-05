using CsvHelper;
using EnsekTest.Model;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EnsekTest.Helper
{
    public static class Csv
    {
        public static List<MeterReadingCsvDTO> GetMeterReadingFromCSV(IFormFile file)
        {
            List<MeterReadingCsvDTO> input = new List<MeterReadingCsvDTO>();

            using (var reader = new StreamReader(file.OpenReadStream()))
            {
                using (var csvReader = new CsvReader(reader, System.Globalization.CultureInfo.InvariantCulture))
                {
                    input = csvReader.GetRecords<MeterReadingCsvDTO>().ToList();

                }
            }

            return input;
        }
    }
}
