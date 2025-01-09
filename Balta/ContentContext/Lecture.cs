namespace Balta.ContentContext;
using  Balta.SharedContext;

    public class Lecture : Base
    {
        public int Ordem { get; set; }
        public string Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; } 
    }
