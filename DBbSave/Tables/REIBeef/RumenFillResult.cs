using ServiceStack.DataAnnotations;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	[Schema("REIBeef")] //Specifique to REIBeef 
	public class RumenFillResult : AuditBOFields, IRumenFillResult, IConcurrency
	{
		[PrimaryKey, AutoIncrement]
		public long RumenId { get; set; }

		public string Normal { get; set; }
		public string SlightlyEmpty { get; set; }
		public string Bloated { get; set; }
		public bool ValidCategory { get; set; }
		public ulong RowVersion { get; set; }
	}
}