//using APBD_TEMPLATE.Models;

using APBD_TEMPLATE.Migrations;
using Microsoft.EntityFrameworkCore;

namespace APBD_TEMPLATE.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

    
    public DbSet<Author> Authors { get; set; } = null!;
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Borrowing> Borrowings { get; set; } = null!;
    public DbSet<Member> Members { get; set; } = null!;
    public DbSet<Review> Reviews { get; set; } = null!;
    
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.Entity<Review>()
            .HasKey(r => new { r.MemberId, r.BookId });

        var authors = new[]
        {
            new Author
            {
                AuthorId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@gmail.com",
                Country = "USA",
                BirthYear = 1983
            }
        };
        
        var books = new[]
        {
            new Book
            {
                BookId = 1,
                Title = "The Life",
                ISBN = "11123",
                PublishedYear = 1888,
                AuthorsId = 1
            }
        };

        var borrowings = new[]
        {
            new Borrowing
            {
                BorrowingId = 1,
                BorrowDate = new DateTime(2012, 12, 31, 16, 45, 0),
                ReturnDate =  null,
                Status = "Borrowed",
                MemberId = 1,
                BookId = 1
            }
        };

        var members = new[]
        {
            new Member
            {
                MemberId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "johndoe@gmail.com",
                Phone = "111111111"
            }
        };

        var reviews = new[]
        {
            new Review
            {
                MemberId = 1,
                BookId = 1,
                Rating = 5,
                Comment = "Reviewed",
                ReviewDate = new DateTime(2012, 12, 31, 16, 45, 0),
            }
        };
        
        modelBuilder.Entity<Author>().HasData(authors);
        modelBuilder.Entity<Book>().HasData(books);
        modelBuilder.Entity<Borrowing>().HasData(borrowings);
        modelBuilder.Entity<Member>().HasData(members);
        modelBuilder.Entity<Review>().HasData(reviews);
    }
    
}