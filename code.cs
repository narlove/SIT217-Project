using System;
using System.Collections.Generic;

public class User
{
    public string Name { get; set; }
    public List<Book> CurrentBooks { get; set; }
    public string UserID { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Password { get; set; }
    public int MembershipCardNo { get; set; }
    public bool IsValidMember { get; set; }

    public User(string name, string phone, string email, string address, string password, int membershipCardNo, bool isValidMember)
    {
        Name = name;
        Phone = phone;
        Email = email;
        Address = address;
        Password = password;
        MembershipCardNo = membershipCardNo;
        IsValidMember = isValidMember;
        CurrentBooks = new List<Book>();
    }

    public void AddCurrentBook(Book book)
    {
        CurrentBooks.Add(book);
    }

    public void RemoveCurrentBook(Book book)
    {
        CurrentBooks.Remove(book);
    }

    public List<Book> FindOverdueBooks()
    {
        // Logic for finding overdue books
        return new List<Book>();
    }

    public List<Book> FindBorrowedHistory()
    {
        // Logic for finding borrowed books history
        return new List<Book>();
    }
}

public class Admin
{
    public string AdminId { get; set; }

    public Admin(string adminId)
    {
        AdminId = adminId;
    }

    public void AddBook(Book book)
    {
        // Logic for adding book
    }

    public void UpdateBook(Book book, Book updatedBook)
    {
        // Logic for updating book details
    }

    public void MarkDamaged(Book book)
    {
        // Logic for marking a book as damaged
    }

    public void MarkLost(Book book)
    {
        // Logic for marking a book as lost
    }

    public void GenerateReport(User user)
    {
        // Logic for generating report based on user
    }

    public void GenerateReport(Book book)
    {
        // Logic for generating report based on book
    }
}

public class Book
{
    public string BookID { get; set; }
    public string BookName { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public string ISBN { get; set; }
    public DateTime PublicationDate { get; set; }

    public Book(string bookId, string name, string author, string genre, string isbn, DateTime publicationDate)
    {
        BookID = bookId;
        BookName = name;
        Author = author;
        Genre = genre;
        ISBN = isbn;
        PublicationDate = publicationDate;
    }
}

public class BookStatus
{
    public string BookID { get; set; }
    public string BookStatusValue { get; set; }
    public DateTime DateBorrowed { get; set; }
    public DateTime DateReturned { get; set; }
    public string ISBN { get; set; }

    public BookStatus(string bookId, string status, DateTime dateBorrowed, DateTime dateReturned, string isbn)
    {
        BookID = bookId;
        BookStatusValue = status;
        DateBorrowed = dateBorrowed;
        DateReturned = dateReturned;
        ISBN = isbn;
    }
}

public class Reservation
{
    public string ReservationID { get; set; }
    public string UserID { get; set; }
    public string BookID { get; set; }
    public string ReservationStatus { get; set; }
    public string ReservationNotification { get; set; }

    public Reservation(string userId, string bookId, string reservationStatus)
    {
        ReservationID = Guid.NewGuid().ToString();
        UserID = userId;
        BookID = bookId;
        ReservationStatus = reservationStatus;
    }

    public void GenerateNotification(Notification notification)
    {
        // Logic for generating notification
    }
}

public class Notification
{
    public string NotificationID { get; set; }
    public string UserID { get; set; }
    public string BookID { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsBookOverdue { get; set; }
    public bool IsReservationAvailable { get; set; }

    public Notification(string userId, string bookId, DateTime dueDate, bool isBookOverdue, bool isReservationAvailable)
    {
        NotificationID = Guid.NewGuid().ToString();
        UserID = userId;
        BookID = bookId;
        DueDate = dueDate;
        IsBookOverdue = isBookOverdue;
        IsReservationAvailable = isReservationAvailable;
    }
}
