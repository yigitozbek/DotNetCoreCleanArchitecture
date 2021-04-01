using System;

namespace Nightrain.Base.Core.Entities
{
    public class AuditedEntity<TType> : Entity<TType>
    {
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
