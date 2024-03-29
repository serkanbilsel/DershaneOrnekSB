using DershaneOrnekSB.Entities;
using Microsoft.EntityFrameworkCore;
using Bogus;

namespace DershaneOrnekSB.Data
{
    public class DatabaseContext : DbContext // DatabaseContext sınıfına EntityFrameworkCore paketinden gelen DbContext sınıfından kalıtım alıyoruz böylece tüm veritabanı işlemlerini yapabileceğiz 
    {
        /*
         * Projede entity framework kullanacağız bu paketi projeye sağ tıklayıp nuget package manager browse yolunu izleyip önce sql server paketini yüklüyoruz sql veritabanı kullanabilmek için, sql server paketi içerisinde entity framework core paketide bulunmaktadır.
         * Code first ile class larımızı kullanarak veri tabanı oluşturma veya değiştirme işlemleri için de Tools paketini projeye yüklüyoruz.
         */
        public DbSet<Exam> Exams { get; set; } // EntityFrameworkCore da entity class larımızı kullanarak veritabanı ile iş yapan nesneler db set 
        public DbSet<UserExamAssignment> UserExamAssignments { get; set; }
        public DbSet<UserExamAttempt> UserExamAttempts { get; set; }
        public DbSet<Choice> Choices { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<QuestionAnswer> QuestionAnswers { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }
        // DbSet<User> ları tanımladıktan sonra override on yazıp OnConfiguring yazanı seçiyoruz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // bu metot veritabanı ayarlarını yapılandırabildiğimiz metot
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; database=OrnekTESTDB; trusted_connection=true"); // UseSqlServer ile bu projede veritabanı olarak sql server kullanacğımızı belirttik. "" içerisindeki alana connection string yani veritabanı bilgilerini yazıyoruz
            base.OnConfiguring(optionsBuilder);
        }
        // on yazıp OnModelCreating yazanı seçiyoruz



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Admin kullanıcısını ekle
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Email = "admin@test.com",
                    IsActive = true,
                    IsAdmin = true,
                    Name = "Admin",
                    Password = "123"
                },
                new User
                {
                    Id = 2,
                    Email = "hakki@test.com",
                    IsActive = true,
                    IsAdmin = false,
                    Name = "Hakki",
                    Password = "123"
                },

    new User
    {
        Id = 3,
        Email = "user1@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User1",
        Password = "123"
    },
    new User
    {
        Id = 4,
        Email = "user2@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User2",
        Password = "123"
    },
    new User
    {
        Id = 5,
        Email = "user3@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User3",
        Password = "123"
    },
    new User
    {
        Id = 6,
        Email = "user4@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User4",
        Password = "123"
    },
    new User
    {
        Id = 7,
        Email = "user5@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User5",
        Password = "123"
    },
    new User
    {
        Id = 8,
        Email = "user6@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User6",
        Password = "123"
    },
    new User
    {
        Id = 9,
        Email = "user7@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User7",
        Password = "123"
    },
    new User
    {
        Id = 10,
        Email = "user8@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User8",
        Password = "123"
    },
    new User
    {
        Id = 11,
        Email = "user9@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User9",
        Password = "123"
    },
    new User
    {
        Id = 12,
        Email = "user10@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User10",
        Password = "123"
    },
    new User
    {
        Id = 13,
        Email = "user11@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User11",
        Password = "123"
    },
    new User
    {
        Id = 14,
        Email = "user12@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User12",
        Password = "123"
    },
    new User
    {
        Id = 15,
        Email = "user13@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User13",
        Password = "123"
    },
    new User
    {
        Id = 16,
        Email = "user14@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User14",
        Password = "123"
    },
    new User
    {
        Id = 17,
        Email = "user15@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User15",
        Password = "123"
    },
    new User
    {
        Id = 18,
        Email = "user16@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User16",
        Password = "123"
    },
    new User
    {
        Id = 19,
        Email = "user17@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User17",
        Password = "123"
    },
    new User
    {
        Id = 20,
        Email = "user18@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User18",
        Password = "123"
    },
    new User
    {
        Id = 21,
        Email = "user19@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User19",
        Password = "123"
    },
    new User
    {
        Id = 22,
        Email = "user20@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User20",
        Password = "123"
    },
    new User
    {
        Id = 23,
        Email = "user21@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User21",
        Password = "123"
    },
    new User
    {
        Id = 24,
        Email = "user22@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User22",
        Password = "123"
    },
    new User
    {
        Id = 25,
        Email = "user23@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User23",
        Password = "123"
    },
    new User
    {
        Id = 26,
        Email = "user24@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User24",
        Password = "123"
    },
    new User
    {
        Id = 27,
        Email = "user25@test.com",
        IsActive = true,
        IsAdmin = false,
        Name = "User25",
        Password = "123"
    }

                );


            base.OnModelCreating(modelBuilder);
        }


    }
}