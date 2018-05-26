using System;
using System.Collections.Generic;
using LanBO.ServiceModel.Interface.Tables;
using LanBO.ServiceModel.Interface.Tables.REIBeef;
using ServiceStack.DataAnnotations;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	[Schema("REIBeef")] //Specifique to REIBeef
	public class Audit : AuditBOFields, IAudit, IConcurrency
	{
		[PrimaryKey, AutoIncrement]
		public long AuditId { get; set; }
		public string Name { get; set; }
		public string FlatStage { get; set; }
		public string MainType { get; set; }
		public string AnimalNb { get; set; }
		public string AnimalAge { get; set; }
		public string AnimalSex { get; set; }
		public string AnimalDietType { get; set; }
		public DateTime Date { get; set; }
		public string State { get; set; }
		public double Progress { get; set; }
		public string Score { get; set; }
		public string Benchmark { get; set; }
		public string Vignet { get; set; }
		public string Comment { get; set; }

		//[References(typeof(Farm)),]
		//public long FarmId { get; set; }
		//[Reference]
		//public Farm Farm { get; set; } 

		[References(typeof(DietResult))]
		public long? DietId { get; set; }
		[Reference]
		public DietResult DietResult { get; set; }

		[References(typeof(ManureResult))]
		public long? ManureId { get; set; }
		[Reference]
		public ManureResult ManureResult { get; set; }

		[References(typeof(RumenFillResult))]
		public long? RumenId { get; set; }
		[Reference]
		public RumenFillResult RumenFillResult { get; set; }

		//[References(typeof(FacilitiesResult))]
		//public long? FacilityId { get; set; }
		//[Reference]
		//public FacilitiesResult FacilitiesResult { get; set; }

		//[References(typeof(CleanlinessResult))]
		//public long? CleanId { get; set; }
		//[Reference]
		//public CleanlinessResult CleanlinessResult { get; set; }

		//[References(typeof(FeetInflamationResult))]
		//public long? FeetId { get; set; }
		//[Reference]
		//public FeetInflamationResult FeetInflamationResult { get; set; }

		//[References(typeof(HornsInflamationResult))]
		//public long? HornsInflamationRowId { get; set; }
		//[Reference]
		//public HornsInflamationResult HornsInflamationResult { get; set; }

		//[References(typeof(AnimalPerformanceResult))]
		//public long? ApId { get; set; }
		//[Reference]
		//public AnimalPerformanceResult AnimalPerformanceResult { get; set; }

		//[References(typeof(TemperaturehumidityResult))]
		//public long? TempId { get; set; }
		//[Reference]
		//public TemperaturehumidityResult TemperaturehumidityResult { get; set; }

		//[References(typeof(BehaviourObservationsResult1))]
		//public long? Bo1Id { get; set; }
		//[Reference]
		//public BehaviourObservationsResult1 BehaviourObservationsResult1 { get; set; }

		//[References(typeof(BehaviourObservationsResult2))]
		//public long? Bo2Id { get; set; }
		//[Reference]
		//public BehaviourObservationsResult2 BehaviourObservationsResult2 { get; set; }

		public ulong RowVersion { get; set; }
	}
}
