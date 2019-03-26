using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccesFactory
{
   public interface IDatabaseFilePathFactory
    {
        Func<IDatabaseFilePath> GetDatabaseFilePath();
    }
}
