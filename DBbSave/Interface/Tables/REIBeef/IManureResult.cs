namespace LanBO.ServiceModel.Tables.REIBeef
{
	public interface IManureResult
	{
		long ManureId { get; set; }
		string Medium { get; set; }
		string Pasty { get; set; }
		string Liquid { get; set; }
		bool ValidCategory { get; set; }
	}
}