using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote_Clone.Model
{
    public class Note
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [Indexed]
        public int NotebookId { get; set; } //WhatNotebook is the owner of the particular note
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string FileLocation { get; set; }
    }
}
