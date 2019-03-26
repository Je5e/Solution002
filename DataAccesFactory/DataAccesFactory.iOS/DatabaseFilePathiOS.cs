using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Foundation;
using UIKit;

namespace DataAccesFactory.iOS
{
    public class DatabaseFilePathiOS : IDatabaseFilePath
    {
        public string GetFullFilePath(string dbName)
        {
            return Path.Combine(
                System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.MyDocuments),
                "..", "Library",
                dbName);
        }
    }
}