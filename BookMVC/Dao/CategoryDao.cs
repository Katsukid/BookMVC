using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookMVC.Entities;

namespace BookMVC.Dao
{
     public class CategoryDao
     {
          BookMVCDbContext db;
          public CategoryDao()
          {
               db = new BookMVCDbContext();
          }
          // Lay danh sach
          public List<Category> ListAll()
          {
               return db.Categories.ToList();
          }

          public List<Category> FindID(long id)
          {
               return db.Categories.Where(x => x.ID == id).ToList();
          }
          public Category ViewDetail(long id)
          {
               return db.Categories.Find(id);
          }

          public List<Category> ViewImage()
          {
               return db.Categories.Where(x => x.SeoTitle != null).ToList();
          }
     }
}