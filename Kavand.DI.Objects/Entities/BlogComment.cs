namespace Kavand.DI.Objects.Entities {
    public class BlogComment : ObjectBase {
        public virtual string Content { get; set; }
        public virtual bool Approved { get; set; }
        public virtual Person Sender { get; set; }
        public virtual BlogEntry Entry { get; set; }
    }
}