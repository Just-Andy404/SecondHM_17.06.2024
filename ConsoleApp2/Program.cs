/*
Создайте приложение для учета книг, которое будет хранить следующую
информацию:
 название книги;
 Ф.И.О. автора;
 жанр книги;
 год издания.
Для хранения данных работников используйте класс
LinkedList<T>.
Приложение должно предоставлять следующую функциональность:
 добавлять книги;
 удалять книги;
 изменять информацию о книгах;
 поиск книг по параметрам;
 вставить книги в начало списка;
 вставить книги в конец списка;
 вставить книги в определенную позицию;
 удалить книги из начала списка;
 удалить книги из конца списка;
 удалить книги с определенной позиции.
*/

using ConsoleApp2;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bookkeeping.AddBook(new Book("Book1", new FullName("John", "Doe", ""), "Fantasy", 2000));
            Bookkeeping.AddBook(new Book("Book2", new FullName("Jane", "Smith", ""), "Science Fiction", 1995));
            Bookkeeping.AddBook(new Book("Book3", new FullName("Michael", "Johnson", ""), "Thriller", 2010));
            Bookkeeping.AddBook(new Book("Book4", new FullName("Emily", "Brown", ""), "Romance", 2020));
            Bookkeeping.AddBook(new Book("Book5", new FullName("David", "Lee", ""), "Mystery", 2005));

            Bookkeeping.AddBookByPosition(new Book("Book6", new FullName("David", "Lee", ""), "Mystery", 2005), 3);
            Bookkeeping.RemoveBookByPosition(5); // Book4
            Bookkeeping.Show();

            Console.WriteLine("-----Change-----");
            try
            {
                Bookkeeping.ChageBookData(book => book.Name == "Book2", (book) => { book.Year = 3; });
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("-----Find-----");
            try
            {
                Console.WriteLine(Bookkeeping.FindBook(book => book.Name == "Book2"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
