using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesFactory
{
   public interface IDatabaseFilePath
    {

        string GetFullFilePath(string dbName);
    }
}
