namespace LanBO.ServiceModel.Tables.REIBeef
{
    public interface IConcurrency
    {
		ulong RowVersion { get; set; }
    }
}