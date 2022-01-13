using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote_Clone.Model
{
   public class Notebook
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Indexed]
        public int UserId { get; set; } //Which user does this Notebook belong to
        public string Name { get; set; }
    }
}
