using EFCoreLibraryHomework.Service;
using System;
using System.Data.Common;
using System.Linq;

namespace EFCoreLibraryHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new LibraryContext())
            {

                //1) Выведите список должников. 
                var debtors = from users in context.Users
                              join tickets in context.Ticket on users.Id equals tickets.UserId
                              join book in context.Books on tickets.BookId equals book.Id
                              select users;

                foreach(var user in debtors)
                {
                    Console.WriteLine($"{user.Id}, {user.Login}, {user.Password}");
                }




                //2) Выведите список авторов книги №3 (по порядку из таблицы ‘Book’). 
                /*var authorOfBook = from authors in context.Authors
                                   join bookAuthor in context.BookAuthor on authors.Id equals bookAuthor.AuthorId
                                   join books in context.Books on bookAuthor.BookId equals books.Id  
                                   where books.Id == 3
                                   select authors;

                foreach (var author in authorOfBook)
                {
                    Console.WriteLine($"{author.Id}. {author.FullName}");
                }*/



                // 3) Выведите список книг, которые доступны в данный момент.
                /*var availableBooks = from book in context.Books
                                     where !context.Ticket.Any(ticket => (ticket.BookId == book.Id))
                                     select book;

                foreach (var book in availableBooks)
                {
                    Console.WriteLine($"{book.Id}. {book.Name}");
                }*/



                // 4) Вывести список книг, которые на руках у пользователя №2.
                /*var userBooks = from users in context.Users
                                join tickets in context.Ticket on users.Id equals tickets.UserId
                                join books in context.Books on tickets.BookId equals books.Id
                                where users.Id == 2
                                select books;

                foreach(var book in userBooks)
                {
                    Console.WriteLine($"{book.Id}. {book.Name}");
                }*/


                // 5) Обнулите задолженности всех должников.

                /*var tickets = context.Ticket.ToList(); 
                foreach(var ticket in tickets)
                {
                    context.Ticket.Remove(ticket);
                }
                context.SaveChanges();*/

            }
        }
    }
}
