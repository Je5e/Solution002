using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace DataAccesFactory.Model
{
    [Table("Categories")]
   public class Category
    {
        [PrimaryKey, AutoIncrement]
        public int CategoryID { get; set; }

       
        [MaxLength(50)]
        public string CategoryName { get; set; }

        [MaxLength(100)]
        public string Description { get; set; }
    }
}
