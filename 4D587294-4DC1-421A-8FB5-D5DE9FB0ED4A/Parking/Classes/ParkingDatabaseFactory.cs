using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;

namespace Parking.Classes
{
    public class ParkingDatabaseFactory
    {
        private readonly SqlDataAccess sqlDataAccess;
        private readonly Dictionary<string, string> queries = new Dictionary<string, string>();
        private const string MasterId = "4D587294-4DC1-421A-8FB5-D5DE9FB0ED4A";

        public ParkingDatabaseFactory()
        {
            sqlDataAccess = new SqlDataAccess();
            queries.Add("SelectMasterSettings", @"SELECT  
                                                        [CompanyName],
                                                        [ParkingPlaceCode],
                                                        [ParkingPlaceName],
                                                        [TwoWheelerParkingRatePerHour],
                                                        [FourWheelerParkingRatePerHour],
                                                        [LostTicketPenality],
                                                        [PLCBoardPortNumber]
                                                FROM [tbl_master] 
                                                WHERE [Id] = '{0}'");

            queries.Add("UpdateMasterSettings", @"  UPDATE [tbl_master]
                                                    SET 
                                                        [CompanyName] = '{0}',
                                                        [ParkingPlaceCode] = '{1}',
                                                        [ParkingPlaceName] = '{2}',
                                                        [TwoWheelerParkingRatePerHour] = '{3}',
                                                        [FourWheelerParkingRatePerHour] = '{4}',
                                                        [LostTicketPenality] = '{5}',
                                                        [PLCBoardPortNumber] = '{6}' 
                                                    WHERE [Id] = '{7}'");

            queries.Add("InsertVehicleEntry", @"INSERT INTO [tbl_parking]
                                                            ([Id],
                                                             [TicketNumber],
                                                             [ValidationNumber],
                                                             [QRCode],
                                                             [VehicleNumber],
                                                             [VehicleType],
                                                             [EntryTime],
                                                             [ExitTime],
                                                             [ParkingCharge],
                                                             [PenalityCharge],
                                                             [TotalPaidAmount]) 
                                                VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')");

        }


        public void UpdateMasterSettings(string companyName,
                                       string parkingPlaceCode,
                                       string parkingPlaceName,
                                       string twoWheelerParkingRatePerHour,
                                       string fourWheelerParkingRatePerHour,
                                       string lostTicketPenality,
                                       string plcBoardPortNumber)
        {
            var query = string.Format(queries["UpdateMasterSettings"], companyName, parkingPlaceCode, parkingPlaceName,
                                       twoWheelerParkingRatePerHour, fourWheelerParkingRatePerHour, lostTicketPenality, plcBoardPortNumber, MasterId);
            sqlDataAccess.ExecuteNonQuery(query);
        }

        public DataRow GetMasterSettings()
        {
            try
            {
                var query = string.Format(queries["SelectMasterSettings"], MasterId);

                var sqlCommand = sqlDataAccess.GetCommand(query);

                var result = sqlDataAccess.Execute(sqlCommand);

                return result.Rows[0];
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

        }

        public void SaveVehicleEntrySettings(string vehicleNumber)
        {
            var vehicleId = 1;
            var ticketNumber = "num";
            var entryTime = DateTime.Now;
            var exitTime = DateTime.Now;
            var parkingduration = new DateTime().TimeOfDay;
            var parkingCharge = SqlMoney.Parse("10");
            var penaltyCharge = SqlMoney.Parse("10");
            var paidAmout = SqlMoney.Parse("10");
            var validationNumber = "abc";
            var qrCode = "QRCode";
            var vehicleType = "Four";
            try
            {
                var insertQuery = string.Format(queries["InsertVehicleEntry"], vehicleId, ticketNumber, validationNumber, qrCode, vehicleNumber,
                                                vehicleType, entryTime, exitTime, parkingCharge, penaltyCharge, paidAmout);
                sqlDataAccess.ExecuteNonQuery(insertQuery);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
    }
}












