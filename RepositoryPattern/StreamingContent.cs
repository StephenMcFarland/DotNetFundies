using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class StreamingContent
    {
        public string ContentTitle { get; set; }
        public string Genre { get; set; }
        public float Length { get; set; }
        public bool IsMature { get; set; }
        public int Rating { get; set; }

        public StreamingContent(string title, string genre, float length, bool isMature, int rating)
        {
            ContentTitle = title;
            Genre = genre;
            Length = length;
            IsMature = isMature;
            Rating = rating;
        }

        public StreamingContent()
        {

        }
    }
}
