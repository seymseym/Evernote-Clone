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

        public string Us
        {
            get
            {
                return GetProperty(() => Us);
            }

            set
            {
                SetProperty(() => Us, value);
            }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public LoginVM()
        {
            LoginCommand = new DelegateCommand(Login);
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