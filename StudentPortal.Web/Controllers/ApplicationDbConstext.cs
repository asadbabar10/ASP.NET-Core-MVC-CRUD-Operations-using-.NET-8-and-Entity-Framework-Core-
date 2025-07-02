namespace StudentPortal.Web.Controllers
{
    public class ApplicationDbConstext
    {
        public object Students { get; internal set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}