using System;
using System.Collections.Generic;
using LanBO.ServiceModel.Interface.Tables;
using LanBO.ServiceModel.Interface.Tables.REIBeef;
using ServiceStack.DataAnnotations;

namespace LanBO.ServiceModel.Tables.REIBeef
{
	[Schema("REIBeef")] //Specifique to REIBeef
	public class Farm : AuditBOFields, IFarm, IConcurrency
    {  
		[PrimaryKey, AutoIncrement]
		public long FarmId { get; set; }
		public string Name { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NbFatteningPlaces { get; set; }
        public int AuditNumber { get; set; }
        public string AuditNumberTxt { get; set; }
        public DateTime LastAuditDate { get; set; }
        public string LastAuditDateTxt { get; set; }
        public bool Archived { get; set; }
        public int UserId { get; set; }

        [Reference]
        public List<Audit> Audits { get; set; }
        public ulong RowVersion { get; set; }

        public Farm()
        {
            Archived = true;
       }
    }
}
