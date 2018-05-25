using System;
using LanBO.ServiceModel.Interface.Tables;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

namespace LanBO.ServiceModel.Tables
{
    public abstract class BackOfficeFields: IBackOfficeField
    {
        private Guid? rowId;
        private DateTime? createdDateUtc;
        private DateTime? updatedDateUtc;

        protected BackOfficeFields()
        {
            createdDateUtc = DateTime.UtcNow;   
        }
        /// <summary>
        /// Gets the created date UTC TimeZone.
        /// </summary>
        /// <value>The created date UTC.</value>
        [Default(OrmLiteVariables.SystemUtc)]
        public DateTime? CreatedDateUtc
        {
            get => createdDateUtc ?? (createdDateUtc = DateTime.UtcNow);
            set => createdDateUtc = value;
        }

        /// <summary>
        /// Gets or sets the updated date in UTC TimeZone.
        /// </summary>
        /// <value>The updated date UTC.</value>
        [Default(OrmLiteVariables.SystemUtc)]
        public DateTime? UpdatedDateUtc
        {
            get => updatedDateUtc ?? (updatedDateUtc = DateTime.UtcNow);
            set => updatedDateUtc = value;
        }

        /// <summary>
        /// Gets the row identifier will be use to make sure we are on the correct record.
        /// When merging info. on the back office
        /// GUID is always unique
        /// </summary>
        /// <value>The row identifier.</value>
        [PrimaryKey]
        public Guid? RowId
        {
            get => rowId ?? (rowId = Guid.NewGuid());
            set => rowId = value;
        }
    }
}
