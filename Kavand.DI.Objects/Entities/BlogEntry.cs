using System.Collections.Generic;

namespace Kavand.DI.Objects.Entities {
    public class BlogEntry : ObjectBase {
        public virtual string Title { get; set; }
        public virtual string Abstraction { get; set; }
        public virtual string Content { get; set; }
        public virtual bool Published { get; set; }
        public virtual IList<BlogComment> Comments { get; set; }
    }
}
