using System.Security.Cryptography.X509Certificates;

namespace Balta.ContentContext
{
    public class Course : Content
    {
        public string Tag { get; set; }
        public IList<Modules> Modules { get; set; }

        public Course()
        {
            Modules = new List<Modules>();
        }
    }

    public class Modules
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }

        public Modules()
        {
            Lectures = new List<Lecture>();
        }
    } 

    public class Lecture
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
    }
}