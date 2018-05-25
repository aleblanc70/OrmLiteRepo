using System;
using LanBO.ServiceModel.Interface.Tables;
using ServiceStack.DataAnnotations;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	[Schema("REIBeef")] //Specifique to REIBeef
	public class ManureResult: AuditBOFields, IManureResult, IConcurrency
    {

		[PrimaryKey, AutoIncrement]
        public long ManureId { get; set; }
        public string Medium { get; set; }
        public string Pasty { get; set; }
        public string Liquid { get; set; }
        public bool ValidCategory { get; set; }      
		public ulong RowVersion { get; set; }
    }
}