using System;
using LanBO.ServiceModel.Interface.Tables;
using ServiceStack.DataAnnotations;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	[Schema("REIBeef")] //Specifique to REIBeef
	public class CleanlinessResult: AuditBOFields, ICleanlinessResult, IConcurrency
    {
		[PrimaryKey, AutoIncrement]
		public long CleanId { get; set; }
        public string Clean { get; set; }
        public string Usual { get; set; }
        public string Dirty { get; set; }
        public bool ValidCategory { get; set; }	
		public ulong RowVersion { get; set; }
    }
}