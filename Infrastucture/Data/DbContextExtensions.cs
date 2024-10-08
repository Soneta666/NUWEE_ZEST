using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class DbContextExtensions
    {
        public static void SeedProduct(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new[]
            {
                new Product()
                {
                    Id = 1,
                    Name = "Печиво 'Lovita'",
                    Price = 43,
                    Description ="",
                    CategoryId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Бургер",
                    Price = 52,
                    Description ="",
                    CategoryId = 2
                },
                new Product()
                {
                    Id = 3,
                    Name = "Йогурт 'Дольче'",
                    Price = 40,
                    Description ="",
                    CategoryId = 3
                },
            });
        }
        public static void SeedBasket(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Basket>().HasData(new[]
            {
                new Basket()
                {
                    Id = 1,
                    StudentId = 1,
                },
                  new Basket()
                {
                    Id = 1,
                    StudentId = 3,
                },
                    new Basket()
                {
                    Id = 1,
                    StudentId = 4,
                },
                      new Basket()
                {
                    Id = 1,
                    StudentId = 2,
                },
            });
        }
        public static void SeedCategory(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category()
                {
                    Id = 1,
                    Name = "Напої",
                },
                new Category()
                {
                    Id = 2,
                    Name = "Гаряча їжа",
                },
            });
        }
        public static void SeedProductBasket(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductBasket>().HasData(new[]
            {
                new ProductBasket()
                {
                    Id = 1,
                    BasketId = 2,
                    ProductId = 3,
                },
                 new ProductBasket()
                {
                    Id = 2,
                    BasketId = 1,
                    ProductId = 2,
                },
                  new ProductBasket()
                {
                    Id = 3,
                    BasketId = 3,
                    ProductId = 1,
                },
            });
        }
        public static void SeedStudent(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(new[]
            {
                new Student()
                {
                    Id = 1,
                    Name = "Радисюк Вікторія",
                    Post = "radysiuk_ak22@nuwm.edu.ua",
                    Password = "vika_2022",
                    Bonus = 2,
                    BasketId = 1

                },
                new Student()
                {
                    Id = 2,
                    Name = "Степанюк Софія",
                    Post = "stepaniuk_ak22@nuwm.edu.ua",
                    Password = "sofija_2022",
                    Bonus = 0,
                    BasketId = 2

                },
                new Student()
                {
                    Id = 3,
                    Name = "Смокович Богдан",
                    Post = "smokovych_ak22@nuwm.edu.ua",
                    Password = "bohdan_2022",
                    Bonus = 1,
                    BasketId = 3

                },
                new Student()
                {
                    Id = 4,
                    Name = "Шклярський Владислав",
                    Post = "shkliarskyi_ak22@nuwm.edu.ua",
                    Password = "vlad_2022",
                    Bonus = 14,
                    BasketId = 4

                },
            });
        }
    }
}
