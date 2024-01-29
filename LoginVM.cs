using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DemoMvvm.Models;
using System.ComponentModel;
using System.Windows.Input;
using DemoMvvm.Commands;
using System.Windows;

namespace DemoMvvm.ViewModels
{
    public class LoginVM: ViewModelBase
    {
        private User user;
       private string userName;
        public ICommand LoginCommand { get; }

        public LoginVM()
        {
            user = new User();
            LoginCommand = new RelayCommands((param) => LoggedIn(param));
        }
        public string UserName
        {
            get => user.UserName;
            set
            {
                user.UserName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public string PassWord
        {
            get => user.PassWord;
            set
            {
                user.PassWord = value;
                OnPropertyChanged(nameof(PassWord));

            }
        }
        private void LoggedIn(object param)
        {
            MessageBox.Show($"Loged in Succefull as {param}");
        }



    }
}
