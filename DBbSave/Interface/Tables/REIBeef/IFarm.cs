using System;
namespace LanBO.ServiceModel.Interface.Tables.REIBeef
{
	public interface IFarm
	{
		long FarmId { get; set; }
		string Name { get; set; }
		string City { get; set; }
		string Country { get; set; }
		string Phone { get; set; }
		string Email { get; set; }
		int NbFatteningPlaces { get; set; }
		int AuditNumber { get; set; }
		string AuditNumberTxt { get; set; }
		DateTime LastAuditDate { get; set; }
		string LastAuditDateTxt { get; set; }
		bool Archived { get; set; }
		int UserId { get; set; }
	}
}
