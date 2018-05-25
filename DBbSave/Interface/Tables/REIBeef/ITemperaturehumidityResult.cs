using System;
namespace LanBO.ServiceModel.Tables.REIBeef
{
    public interface ITemperaturehumidityResult
    {
        long TempId { get; set; }
        string Humidity { get; set; }
        string Temperature { get; set; }
        string Thi { get; set; }
        bool ValidCategory { get; set; }
		//Guid? AuditRowId { get; set; }
    }
}