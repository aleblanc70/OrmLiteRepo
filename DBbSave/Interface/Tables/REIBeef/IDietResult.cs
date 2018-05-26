namespace LanBO.ServiceModel.Tables.REIBeef
{
	public interface IDietResult
	{
		long DietId { get; set; }
		int AccessFiber { get; set; }
		int MainFiber { get; set; }
		int FiberQuality { get; set; }
		int FiberRegularity { get; set; }
		bool ValidCategory { get; set; }
	}
}