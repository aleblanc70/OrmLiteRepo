using System;

namespace LanBO.ServiceModel.Interface.Tables
{
    public interface IBackOfficeField
    {
        DateTime? CreatedDateUtc { get; set; }
        DateTime? UpdatedDateUtc { get; set; }
        Guid? RowId { get; }
    }
}