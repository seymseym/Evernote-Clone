using DevExpress.Mvvm;
using Evernote_Clone.Model;
using Evernote_Clone.ViewModel.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Evernote_Clone.ViewModel
{
    public class NotesVM:ViewModelBase
    {
        public ICommand NewNotebookCommand { get; set; }
        public ICommand NewNoteCommand { get; set; }

        //Constructor
        public NotesVM()
        {
            NewNotebookCommand = new DelegateCommand(NewNotebook);
            NewNoteCommand = new DelegateCommand<object>(ExNewNote, CanExNewNote, null);

        }

        private bool CanExNewNote(object arg)
        {
            Notebook selectedNotebook = arg as Notebook;
            if (selectedNotebook != null)
                return true;
            return false;
        }

        private void ExNewNote(object obj)
        {
            Notebook selectedNotebook = obj as Notebook;
            CreateNote(selectedNotebook.Id);

        }

        public void CreateNoteBook()
        {
            Notebook newNotebook = new Notebook()
            {
                Name = "New Notebook"
            };

            DataBaseHelper.Insert(newNotebook);
        }
        public void CreateNote(int notebookID)
        {
            Note newNote = new Note()
            {
                NotebookId = notebookID,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                Title = "New Note"
            };

            DataBaseHelper.Insert(newNote);
        }

        private void NewNotebook()
        {
            CreateNoteBook();
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

        public ObservableCollection<Note> Notes { get; set; }

    }
}
