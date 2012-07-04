using System;

namespace Kavand.DI.Objects {
    public abstract class ObjectBase {
        protected ObjectBase() {
            CreatedAt = DateTimeOffset.UtcNow;
            UpdatedAt = DateTimeOffset.UtcNow;
        }
        public virtual int Id { get; set; }
        public virtual DateTimeOffset CreatedAt { get; set; }
        public virtual DateTimeOffset UpdatedAt { get; set; }
    }
}
