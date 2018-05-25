using System;
namespace LanBO.ServiceModel.Tables.REIBeef
{
    public interface IRumenFillResult
    {
        long RumenId { get; set; }
        string Normal { get; set; }
        string SlightlyEmpty { get; set; }
        string Bloated { get; set; }
        bool ValidCategory { get; set; }
		//Guid? AuditRowId { get; set; }
    }
}