using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DataAccesFactory.Model
{
   public class Database
    {
        SQLiteConnection DbContext;

        public Database(string dbFilePath) // Factory Inyectar la ruta db.
        {
            DbContext = new SQLiteConnection(dbFilePath);

            DbContext.CreateTable<Category>();
        }

        public int InsertCategory(Category newCategory)
        {
            return DbContext.Insert(newCategory);
        }

        public List<Category> GetCategories()
        {
            return DbContext.Table<Category>().ToList();
        }
    }
}
