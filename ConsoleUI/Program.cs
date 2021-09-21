using Business.Concrete;
using DataAccess.Concrete.InMemory;
using DataAccess.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            BlogManager blogManager = new BlogManager(new EfBlogDal());

            blogManager.Add(new Blog { Id = 4, Title = "title-4", Content = "Content-4" });
            foreach (var item in blogManager.GetAll().Data)
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
