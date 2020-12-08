using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Threading.Tasks;
using CoolHub.Entities;
using CoolHub.Models;
using System.Diagnostics;

namespace CoolHub.ViewModels
{
    public class LogInViewModel : BaseViewModel
    {
        private readonly IUserRepository _userRepository;

        public LogInViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool AttemptLogin(string username, string password)
        {
            var user = _userRepository.Read(username);
            
            if(user != null && user.Password == password)
            {
                return true;
            }

            return false;
        }

        public Status CreateUser(UserCreateDTO user)
        {
            IsBusy = true;

            (Status status, int resourceId) response = _userRepository.Create(user);

            OnPropertyChanged(nameof(_userRepository));

            IsBusy = false;

            return response.status;
        }
    }
}