using System;
namespace LanBO.ServiceModel.Tables.REIBeef
{
    public interface ICleanlinessResult
    {
        long CleanId { get; set; }
        string Clean { get; set; }
        string Usual { get; set; }
        string Dirty { get; set; }
        bool ValidCategory { get; set; }
		//Guid? AuditRowId { get; set; }
    }
}