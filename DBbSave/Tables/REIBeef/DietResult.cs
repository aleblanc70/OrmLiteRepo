using System;
using LanBO.ServiceModel.Interface.Tables;
using ServiceStack.DataAnnotations;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	[Schema("REIBeef")] //Specifique to REIBeef
	public class DietResult : AuditBOFields, IDietResult, IConcurrency
    {
		[PrimaryKey, AutoIncrement]
        public long DietId { get; set; }
        public int AccessFiber { get; set; }
        public int MainFiber { get; set; }
        public int FiberQuality { get; set; }
        public int FiberRegularity { get; set; }
        public bool ValidCategory { get; set; }
        public ulong RowVersion { get; set; }
    }
}