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
    public class ResourceViewModel : BaseViewModel
    {
        private readonly IResourceRepository _repository;
        public List<ResourceDetailsDTO> CurrentResource;

        public ResourceViewModel(IResourceRepository repository)
        {
            _repository = repository;
        }

        public Status CreateResource(ResourceCreateDTO resource)
        {
            IsBusy = true;

            (Status status, int categoryId) response = _repository.Create(resource);

            OnPropertyChanged(nameof(_repository));

            IsBusy = false;

            return response.status;
        }
        
        public Status CreateComment(User user, string comment)
        {
            return Status.Conflict;
        }
    }
}