using System.Security.Cryptography.X509Certificates;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Module> Modules { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; } 

        public Course(string title, string url)
            : base(title, url)
        {
            Modules = new List<Module>();
        }
    }
}