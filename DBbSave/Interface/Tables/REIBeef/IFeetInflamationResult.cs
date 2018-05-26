namespace LanBO.ServiceModel.Tables.REIBeef
{
	public interface IFeetInflamationResult
	{
		long FeetId { get; set; }
		int IndexValid { get; set; }
		string Normal { get; set; }
		string SlightlyDeformed { get; set; }
		string HightlyDeformed { get; set; }
		string CountNumberLame { get; set; }
		string CountNumberNoLame { get; set; }
		bool ValidCategory { get; set; }
	}
}