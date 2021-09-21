using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            BlogManager blogManager = new BlogManager(new InMemoryBlogDal(new List<Blog> { 
                new Blog { Id=1,Title="title-1",Content="Content-1"},
            new Blog { Id=2,Title="title-2",Content="Content-2"}}));

            foreach (var item in blogManager.GetAll())
            {
                Console.WriteLine(item.Title);
            }
        }
    }
}
