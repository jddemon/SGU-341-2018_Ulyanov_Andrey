using System.IO;

namespace Book
{
    public class Book
    {
        private string _title;
        private int _numberOfPages;
        private string _publishingHouse;
        private string _publicationTime;
        private string _writingTime;
        private Author _author;

        public Book(string title, int numberOfPages, string publishingHouse, string publicationTime, string writingTime, Author author)
        {
            Title = title;
            NumberOfPages = numberOfPages;
            PublishingHouse = publishingHouse;
            PublicationTime = publicationTime;
            WritingTime = writingTime;
            Author = author;
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        public int NumberOfPages
        {
            get
            {
                return _numberOfPages;
            }
            set
            {
                _numberOfPages = value;
            }
        }

        public string PublishingHouse
        {
            get
            {
                return _publishingHouse;
            }
            set
            {
                _publishingHouse = value;
            }
        }

        public string PublicationTime
        {
            get
            {
                return _publicationTime;
            }
            set
            {
                _publicationTime = value;
            }
        }

        public string WritingTime
        {
            get
            {
                return _writingTime;
            }
            set
            {
                _writingTime = value;
            }
        }

        public Author Author
        {

            get
            {
                return _author;
            }
            set
            {
                if (value == null)
                {
                    throw new InvalidDataException("author can't be null");
                }

                _author = value;
            }
        }

        public override string ToString()
        {
            return $"{Title},{NumberOfPages},{PublishingHouse},{PublicationTime},{WritingTime},{Author}{System.Environment.NewLine}";
        }

    }
}
