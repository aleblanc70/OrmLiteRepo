using System;
namespace LanBO.ServiceModel.Tables.REIBeef
{
    public interface IBehaviourObservationsResult1
    {
        long BoId { get; set; }
        string Ruminating { get; set; }
        string NoRuminating { get; set; }
        string Lying { get; set; }
        string NoLying { get; set; }
        bool ValidCategory { get; set; }
		//Guid? AuditRowId { get; set; }
    }
}