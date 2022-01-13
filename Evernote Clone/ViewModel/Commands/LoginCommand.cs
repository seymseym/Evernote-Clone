using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

//LoginCommand for handling the Login Button Events
namespace Evernote_Clone.ViewModel.Commands
{
    public class LoginCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public LoginVM VM { get; set; } 
        public bool CanExecute(object parameter)
        {
            return true;
        }

        //Constructor, where this property receive its value
        public LoginCommand(LoginVM vm) //Receives a LoginVM 
        {
            VM = vm; //So it can get the value for our property from that parameter.
        }

        public void Execute(object parameter)
        {
            //TODO
        }
    }
}
