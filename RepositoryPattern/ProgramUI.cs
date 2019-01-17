using System;
using System.Collections.Generic;

namespace RepositoryPattern
{
    public class ProgramUI
    {
        StreamingContentRepository _contentRepo = new StreamingContentRepository();

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add content to list\n" +
                    "2. Display list\n" +
                    "3. Exit");

                string input = Console.ReadLine();
                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        AddContent();
                        break;
                    case 2:
                        DisplayList();
                        break;
                    case 3:
                        running = false;
                        break;
                }
            }
        }

        private void AddContent()
        {
            //Title Genre Length IsMature Rating
            StreamingContent newContent = new StreamingContent();

            Console.WriteLine("Enter the title:");
            newContent.ContentTitle = Console.ReadLine();

            Console.WriteLine("Enter the genre:");
            newContent.Genre = Console.ReadLine();

            Console.WriteLine("Enter the length in minutes:");
            string lengthAsString = Console.ReadLine();
            newContent.Length = float.Parse(lengthAsString);

            Console.WriteLine("This is mature content (true/false)");
            string isMature = Console.ReadLine().ToLower();
            if(isMature == "true")
            {
                newContent.IsMature = true;
            }
            else
            {
                newContent.IsMature = false;
            }

            Console.WriteLine("Enter the rating:");
            string ratingAsString = Console.ReadLine();
            newContent.Rating = int.Parse(ratingAsString);

            _contentRepo.AddContentToList(newContent);
        }

        private void DisplayList()
        {
            List<StreamingContent> contentList = _contentRepo.GetStreamingContentList();

            foreach (StreamingContent content in contentList)
            {
                Console.WriteLine($"{content.ContentTitle} is {content.Length} minutes long.");

                if (content.IsMature)
                {
                    Console.WriteLine("This is mature content.");
                }
                else
                {
                    Console.WriteLine("This is family friendly");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}