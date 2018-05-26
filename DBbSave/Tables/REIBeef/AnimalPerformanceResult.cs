using ServiceStack.DataAnnotations;
using LanBO.ServiceModel.Interface.Tables.REIBeef;
using LanBO.ServiceModel.Interface.Tables;
using System;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	[Schema("REIBeef")] //Specifique to REIBeef
	public class AnimalPerformanceResult : AuditBOFields, IAnimalPerformanceResult, IConcurrency
	{
		[PrimaryKey, AutoIncrement]
		public long ApId { get; set; }
		public string CarcassTarget { get; set; }
		public string CarcassDessing { get; set; }
		public int LiverAbcessesAtSlaughterhouse { get; set; }
		public int PrincipalCauseOfMortality { get; set; }
		public string LiverAbcessesAtSlaughterhouseStr { get; set; }
		public string PrincipalCauseOfMortalityStr { get; set; }
		public bool ValidCategory { get; set; }
		public ulong RowVersion { get; set; }
	}
}