namespace BookMVC.Entities
{
     using System;
     using System.Data.Entity;
     using System.ComponentModel.DataAnnotations.Schema;
     using System.Linq;

     public partial class BookMVCDbContext : DbContext
     {
          public BookMVCDbContext()
              : base("name=BookMVCDbContext")
          {
          }

          public virtual DbSet<Book> Books { get; set; }
          public virtual DbSet<BookCategory> BookCategories { get; set; }
          public virtual DbSet<Category> Categories { get; set; }
          public virtual DbSet<Contact> Contacts { get; set; }
          public virtual DbSet<Content> Contents { get; set; }
          public virtual DbSet<ContentTag> ContentTags { get; set; }
          public virtual DbSet<Feedback> Feedbacks { get; set; }
          public virtual DbSet<Footer> Footers { get; set; }
          public virtual DbSet<Menu> Menus { get; set; }
          public virtual DbSet<MenuType> MenuTypes { get; set; }
          public virtual DbSet<Order_Detail> Order_Detail { get; set; }
          public virtual DbSet<PublishingHouse> PublishingHouses { get; set; }
          public virtual DbSet<Slide> Slides { get; set; }
          public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
          public virtual DbSet<SystemConfig> SystemConfigs { get; set; }
          public virtual DbSet<Tag> Tags { get; set; }
          public virtual DbSet<User> Users { get; set; }
          public virtual DbSet<Admin> Admins { get; set; }
          public virtual DbSet<Order> Orders { get; set; }

          protected override void OnModelCreating(DbModelBuilder modelBuilder)
          {
               modelBuilder.Entity<Book>()
                   .Property(e => e.code)
                   .IsUnicode(false);

               modelBuilder.Entity<Book>()
                   .Property(e => e.MetaTitle)
                   .IsUnicode(false);

               modelBuilder.Entity<Book>()
                   .Property(e => e.Price)
                   .HasPrecision(18, 0);

               modelBuilder.Entity<Book>()
                   .Property(e => e.PromotionPrice)
                   .HasPrecision(18, 0);

               modelBuilder.Entity<Book>()
                   .Property(e => e.ModifiedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<Book>()
                   .Property(e => e.MetaDescription)
                   .IsFixedLength();

               modelBuilder.Entity<Book>()
                   .HasOptional(e => e.Book1)
                   .WithRequired(e => e.Book2);

               modelBuilder.Entity<BookCategory>()
                   .Property(e => e.MetaTitle)
                   .IsFixedLength();

               modelBuilder.Entity<BookCategory>()
                   .Property(e => e.CreateBy)
                   .IsUnicode(false);

               modelBuilder.Entity<BookCategory>()
                   .Property(e => e.ModifiedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<BookCategory>()
                   .Property(e => e.MetaDescription)
                   .IsFixedLength();

               modelBuilder.Entity<Category>()
                   .Property(e => e.MetaTitle)
                   .IsFixedLength();

               modelBuilder.Entity<Category>()
                   .Property(e => e.CreatedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<Category>()
                   .Property(e => e.ModifiedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<Category>()
                   .Property(e => e.MetaDescription)
                   .IsFixedLength();

               modelBuilder.Entity<Content>()
                   .Property(e => e.MetaTitle)
                   .IsUnicode(false);

               modelBuilder.Entity<Content>()
                   .Property(e => e.Description)
                   .IsFixedLength();

               modelBuilder.Entity<Content>()
                   .Property(e => e.CreatedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<Content>()
                   .Property(e => e.ModifiedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<Content>()
                   .Property(e => e.MetaDescription)
                   .IsFixedLength();

               modelBuilder.Entity<ContentTag>()
                   .Property(e => e.TagID)
                   .IsUnicode(false);

               modelBuilder.Entity<Order_Detail>()
                   .Property(e => e.Price)
                   .HasPrecision(18, 0);

               modelBuilder.Entity<PublishingHouse>()
                   .Property(e => e.MetaTitle)
                   .IsUnicode(false);

               modelBuilder.Entity<PublishingHouse>()
                   .Property(e => e.Description)
                   .IsFixedLength();

               modelBuilder.Entity<PublishingHouse>()
                   .Property(e => e.CreatedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<PublishingHouse>()
                   .Property(e => e.ModifiedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<PublishingHouse>()
                   .Property(e => e.MetaDescription)
                   .IsFixedLength();

               modelBuilder.Entity<Slide>()
                   .Property(e => e.CreatedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<Slide>()
                   .Property(e => e.ModifiedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<Slide>()
                   .Property(e => e.MetaDescription)
                   .IsFixedLength();

               modelBuilder.Entity<SystemConfig>()
                   .Property(e => e.ID)
                   .IsUnicode(false);

               modelBuilder.Entity<Tag>()
                   .Property(e => e.ID)
                   .IsUnicode(false);

               modelBuilder.Entity<User>()
                   .Property(e => e.Password)
                   .IsUnicode(false);

               modelBuilder.Entity<User>()
                   .Property(e => e.Email)
                   .IsUnicode(false);

               modelBuilder.Entity<User>()
                   .Property(e => e.CreatedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<User>()
                   .Property(e => e.ModifiedBy)
                   .IsUnicode(false);

               modelBuilder.Entity<Admin>()
                   .Property(e => e.UserName)
                   .IsFixedLength();

               modelBuilder.Entity<Order>()
                   .Property(e => e.ShipMobile)
                   .IsUnicode(false);
          }
     }
}
