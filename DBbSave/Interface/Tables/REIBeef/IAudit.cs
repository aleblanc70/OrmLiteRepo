using System;
namespace LanBO.ServiceModel.Interface.Tables.REIBeef
{
	public interface IAudit
	{
		long AuditId { get; set; }
		string Name { get; set; }
		string FlatStage { get; set; }
		string MainType { get; set; }
		string AnimalNb { get; set; }
		string AnimalAge { get; set; }
		string AnimalSex { get; set; }
		string AnimalDietType { get; set; }
		DateTime Date { get; set; }
		string State { get; set; }
		double Progress { get; set; }
		string Score { get; set; }
		string Benchmark { get; set; }
		string Vignet { get; set; }
		string Comment { get; set; }
	}
}
