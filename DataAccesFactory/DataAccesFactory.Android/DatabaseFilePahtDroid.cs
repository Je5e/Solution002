using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;


namespace DataAccesFactory.Droid
{
    public class DatabaseFilePahtDroid : IDatabaseFilePath
    {
        public string GetFullFilePath(string nameFileDatabase)
        {
           var FilePath =
                Path.Combine(System.Environment.GetFolderPath
                (System.Environment.SpecialFolder.LocalApplicationData),
                nameFileDatabase);

            return FilePath;
        }
    }
}