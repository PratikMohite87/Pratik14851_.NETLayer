using System;

namespace EFCodeFirstAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDB();
            Console.WriteLine("Inserted");
        }

        public static void TestDB()
        {
            BookDBContext bookDBContext = new BookDBContext();

            Publisher publisher = new Publisher()
            {
                PublisherId = 10001,
                PublisherName = "Amish",
                PublisherCountry = "India"
            };

            bookDBContext.Publishers.Add(publisher);
            bookDBContext.SaveChanges();

            Book book = new Book()
            {
                BookId = 101,
                BookName = "Bhagvat Gita",
                Publisher = publisher
            };

            bookDBContext.Books.Add(book);
            bookDBContext.SaveChanges();

            Member member = new Member()
            {
                MemberId = 1,
                MemberName = "Pratik",
            };

            bookDBContext.Members.Add(member);
            bookDBContext.SaveChanges();

            Review review = new Review()
            {
                ReviewId = 1001,
                ReviewText = "Good",
                Book = book,
                Member = member,
            };

            bookDBContext.Reviews.Add(review);
            bookDBContext.SaveChanges();
        }
    }
}
