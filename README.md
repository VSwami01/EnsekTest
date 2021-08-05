# EnsekTest
WebApi to upload csv and save it to Database

Steps to run!
1. Create a database "ENSEK"
2. Create tables "Test_Accounts" and "Meter_Reading" using sql script file "EnsekTest/EnsekTest/DatabaseScripts/Script.sql"
3. Seed test accounts using insert statements in sql scripts file "EnsekTest/EnsekTest/DatabaseScripts/Script.sql"
4. Run the solution (F5) to open Swagger (https://localhost:44359/swagger/index.html)
5. Swagger page shows all the apis.
6. In Swagger, select POST api ("/api/MeterReader/ProcessMeterReadingCSV") and select file "Meter_Reading" supplied by ENSEK as part of this test
7. Execute
8. The api should return Sucess/Fail count.
9. Check the table "Meter_Reading" in the database. This should have rows imported now.
10. Try again with the same file. All rows in the csv file should fail as duplicates are not allowed.

Thank you

