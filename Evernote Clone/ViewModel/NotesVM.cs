using Evernote_Clone.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote_Clone.ViewModel
{
    public class NotesVM
    {
        public ObservableCollection<Note> Notes { get; set; }


        //Constructor
        public NotesVM()
        {

        }
        public ObservableCollection<Notebook> Notebooks { get; set; }
        private Notebook selectedNotebook;

        public Notebook SelectedNotebook
        {
            get { return selectedNotebook; }
            set 
            { 
                selectedNotebook = value;
                //TODO: get notes
            }
        }

    }
}
