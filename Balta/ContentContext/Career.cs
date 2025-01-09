namespace Balta.ContentContext
{
    public class Career : Content
    {
        public IList<CareerItem> Items { get; set; }
        public int TotalCourses => Items.Count; // Expression Body
     
        public Career(string title, string url)
            : base(title, url)
        {
            Items = new List<CareerItem>();
        }
    }

}