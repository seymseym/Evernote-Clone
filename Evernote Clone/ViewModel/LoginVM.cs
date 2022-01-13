using Evernote_Clone.Model;
using Evernote_Clone.ViewModel.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evernote_Clone.ViewModel
{
    public class LoginVM
    {
        private User user;

        public User User
        {
            get { return user; }
            set { user = value; }
        }

        /*After creating RegisterCommand class 
         *               RegisterCommand(LoginVM vm)
         */
        public RegisterCommand RegisterCommand { get; set; }
        public LoginCommand LoginCommand { get; set; }
        public LoginVM()
        {
            RegisterCommand = new RegisterCommand(this); //Bcs the constructor of RegisterCommand class
                                                         //requires a LoginVM instance

            LoginCommand = new LoginCommand(this);
        }

    }
}