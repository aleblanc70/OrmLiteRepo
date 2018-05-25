using System;
using LanBO.ServiceModel.Interface.Tables;
using ServiceStack.DataAnnotations;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	[Schema("REIBeef")] //Specifique to REIBeef
	public class BehaviourObservationsResult1: AuditBOFields, IBehaviourObservationsResult1, IConcurrency
    {
		[PrimaryKey, AutoIncrement]
        public long BoId { get; set; }
        public string Ruminating { get; set; }
        public string NoRuminating { get; set; }
        public string Lying { get; set; }
        public string NoLying { get; set; }
        public bool ValidCategory { get; set; }
		public ulong RowVersion { get; set; }
    }        
}