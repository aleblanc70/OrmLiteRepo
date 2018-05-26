using System;
namespace LanBO.ServiceModel.Interface.Tables.REIBeef
{
	public interface IUserType
	{
		string TypeCode { get; set; }
		string TypeDescription { get; set; }
		Guid? CultureRowId { get; set; }
		bool Active { get; set; }
	}
}
