using EnsekTest.Model;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EnsekTest.Repository
{
    public class MeterReadRepo : IMeterReadRepo
    {
        IConfiguration _configuration;

        const string DBNAME = "EnsekDatabase";

        public MeterReadRepo(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int AddReading(AccountMeterReading accountMeterReading)
        {
            int result = 0;

            using (SqlConnection connection = GetSQLConnection())
            {

                String query = @"insert into dbo.Meter_Reading(AccountId, MeterReadingDateTime, MeterReadValue)
                                    values (@AccountId, @MeterReadingDateTime, @MeterReadValue)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountId", accountMeterReading.AccountId);
                    command.Parameters.AddWithValue("@MeterReadingDateTime", accountMeterReading.MeterReadingDateTime);
                    command.Parameters.AddWithValue("@MeterReadValue", accountMeterReading.MeterReadValue);

                    connection.Open();
                    result = command.ExecuteNonQuery();

                }

            }

            return result;
        }
        public Account GetAccount(int accountId)
        {
            Account account = new Account();

            using (SqlConnection connection = GetSQLConnection())
            {
                // Creating SqlCommand objcet 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from dbo.Test_Accounts where AccountId = @AccountId";
                cmd.Parameters.AddWithValue("@AccountId", accountId);
                cmd.Connection = connection;
                // Opening Connection  
                connection.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    account = (new Account()
                    {
                        AccountId = Convert.ToInt32(sdr["AccountId"]),
                        FirstName = sdr["FirstName"].ToString(),
                        LastName = sdr["LastName"].ToString()
                    });

                }
            }

            return account;
        }
        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();

            using (SqlConnection connection = GetSQLConnection())
            {
                // Creating SqlCommand objcet 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from dbo.Test_Accounts";
                cmd.Connection = connection;
                // Opening Connection  
                connection.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    accounts.Add(new Account()
                    {
                        AccountId = Convert.ToInt32(sdr["AccountId"]),
                        FirstName = sdr["FirstName"].ToString(),
                        LastName = sdr["LastName"].ToString()
                    });
                }
            }

            return accounts;
        }
        public List<AccountMeterReading> GetMeterReading(int accountId)
        {
            List<AccountMeterReading> meterReading = new List<AccountMeterReading>();

            using (SqlConnection connection = GetSQLConnection())
            {
                // Creating SqlCommand objcet 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from dbo.Meter_Reading where AccountId = @AccountId";
                cmd.Parameters.AddWithValue("@AccountId", accountId);
                cmd.Connection = connection;
                // Opening Connection  
                connection.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    meterReading.Add(new AccountMeterReading()
                    {
                        Id = Convert.ToInt32(sdr["Id"]),
                        AccountId = Convert.ToInt32(sdr["AccountId"]),
                        MeterReadingDateTime = Convert.ToDateTime(sdr["MeterReadingDateTime"]),
                        MeterReadValue = sdr["MeterReadValue"].ToString()
                    });
                }
            }

            return meterReading;
        }
        public List<AccountMeterReading> GetMeterReadings()
        {
            var connString = _configuration.GetConnectionString(DBNAME);

            List<AccountMeterReading> meterReading = new List<AccountMeterReading>();

            using (SqlConnection connection = new SqlConnection(connString))
            {
                // Creating SqlCommand objcet 
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from dbo.Meter_Reading";
                cmd.Connection = connection;
                // Opening Connection  
                connection.Open();
                // Executing the SQL query  
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    meterReading.Add(new AccountMeterReading()
                    {
                        Id = Convert.ToInt32(sdr["Id"]),
                        AccountId = Convert.ToInt32(sdr["AccountId"]),
                        MeterReadingDateTime = Convert.ToDateTime(sdr["MeterReadingDateTime"]),
                        MeterReadValue = sdr["MeterReadValue"].ToString()
                    });
                }
            }

            return meterReading;
        }

        private SqlConnection GetSQLConnection()
        {
            return new SqlConnection(_configuration.GetConnectionString(DBNAME));
        }
    }
}
