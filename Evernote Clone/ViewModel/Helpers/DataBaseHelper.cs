using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote_Clone.ViewModel.Helpers
{
    public class DataBaseHelper
    {
        private static string dbFile = Path.Combine(Environment.CurrentDirectory, "notesDb.db3");

        /*Created my own generic method called Insert. It is generic
        so it can take any type of parameter. We're passing just a placeholder
        for any corresponding class ---> T */
        public static bool Insert<T>(T item)
        {
            bool result = false; //default
                                 
            using (SQLiteConnection con = new SQLiteConnection(dbFile))
            {
                con.CreateTable<T>();
                int rows = con.Insert(item);
                if (rows > 0) //at least one row is added - insert is successful
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool Update<T>(T item)
        {
            bool result = false; //default

            using (SQLiteConnection con = new SQLiteConnection(dbFile))
            {
                con.CreateTable<T>();
                int rows = con.Update(item);
                if (rows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public static bool Delete<T>(T item)
        {
            bool result = false; //default

            using (SQLiteConnection con = new SQLiteConnection(dbFile))
            {
                con.CreateTable<T>();
                int rows = con.Delete(item);
                if (rows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

        /* Note1: This one is not a bool type, this time it is a generic List type
         * Note2: For the Table, it says 'T' must be a non-abstract type with 
         *        a public parameterless constructor. 
         *        Table method can not infer that the T Type is going to be an abstract type
         *        with a public parameter list constructor because T can be anyting.
         *        
         *        What we can do here in the definiton of the method, establish that T is going to
         *        AT LEAST have a parameterless constructor.
         *        
         */
        public static List<T> Read<T>() where T : new() //we do not know the type (T) but we make sure it has parameterless constructor
        {
            List<T> items; //default

            using (SQLiteConnection con = new SQLiteConnection(dbFile))
            {
                con.CreateTable<T>();
                items = con.Table<T>().ToList();
            }

            return items;
        }

    }
}
