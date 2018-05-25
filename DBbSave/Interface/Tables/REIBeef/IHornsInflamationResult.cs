using System;
namespace LanBO.ServiceModel.Tables.REIBeef
{
    public interface IHornsInflamationResult
    {
        long HornId { get; set; }
        string Nofounder { get; set; }
        string Brilliant { get; set; }
        string Purple { get; set; }
        bool ValidCategory { get; set; }
		//Guid? AuditRowId { get; set; }
    }
}