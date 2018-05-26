namespace LanBO.ServiceModel.Interface.Tables.REIBeef
{
	public interface IAnimalPerformanceResult
	{
		long ApId { get; set; }
		string CarcassTarget { get; set; }
		string CarcassDessing { get; set; }
		int LiverAbcessesAtSlaughterhouse { get; set; }
		int PrincipalCauseOfMortality { get; set; }
		string LiverAbcessesAtSlaughterhouseStr { get; set; }
		string PrincipalCauseOfMortalityStr { get; set; }
		bool ValidCategory { get; set; }
	}
}