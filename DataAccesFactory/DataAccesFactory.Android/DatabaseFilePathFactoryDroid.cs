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

namespace DataAccesFactory.Droid
{
    public class DatabaseFilePathFactoryDroid : IDatabaseFilePathFactory
    {
        public Func<IDatabaseFilePath> GetDatabaseFilePath()
        {
            return () => new DatabaseFilePahtDroid();
        }
    }
}