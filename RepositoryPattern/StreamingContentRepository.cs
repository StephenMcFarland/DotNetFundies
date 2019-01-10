using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class StreamingContentRepository
    {
        List<StreamingContent> listOfStreamingContent = new List<StreamingContent>();

        public void AddContentToList(StreamingContent content)
        {
            listOfStreamingContent.Add(content);
        }

        public List<StreamingContent> GetStreamingContentList()
        {
            return listOfStreamingContent;
        }
    }
}
