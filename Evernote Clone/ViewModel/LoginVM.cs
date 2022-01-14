using DevExpress.Mvvm;
using Evernote_Clone.Model;
using Evernote_Clone.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Evernote_Clone.ViewModel
{
    public class LoginVM : ViewModelBase
    {

        public string User
        {
            get
            {
                return GetProperty(() => User);
            }

            set
            {
                SetProperty(() => User, value);
            }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand NewNotebookCommand { get; set; }
        public ICommand NewNoteCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public LoginVM()
        {
            LoginCommand = new DelegateCommand(Login);
            NewNotebookCommand = new DelegateCommand(NewNoteook);
            NewNoteCommand = new DelegateCommand(NewNote);
            RegisterCommand = new DelegateCommand(Register);
        }

        private void Register()
        {
            throw new NotImplementedException();
        }

        private void NewNote()
        {
            
        }

        private void NewNoteook()
        {
            
        }

        private void Login()
        {
            NoteWindow NW = new NoteWindow();
            NW.Show();
        }

    }
}