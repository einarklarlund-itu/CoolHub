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
    public class TopicViewModel : BaseViewModel
    {
        private readonly ITopicRepository _topicRepository;
        private readonly IResourceRepository _resourceRepository;

        public int TopicId { get; set; }

        public List<TopicDetailsDTO> Topics =>_topicRepository.Read().ToList();
        public ICollection<ResourceDTO> ResourceDTOs => _topicRepository.Read(TopicId).Resources;

        public TopicViewModel(IResourceRepository resourceRepository, ITopicRepository topicRepository)
        {
            _resourceRepository = resourceRepository;
            _topicRepository = topicRepository;
        }

        public TopicDetailsDTO GetTopicById(int id)
        {
            return _topicRepository.Read(id);
        }

        public Status CreateResource(ResourceCreateDTO resource)
        {
            IsBusy = true;

            resource.TopicId = TopicId;

            (Status status, int resourceId) response = _resourceRepository.Create(resource);

            OnPropertyChanged(nameof(_resourceRepository));
            OnPropertyChanged(nameof(_topicRepository));

            IsBusy = false;

            return response.status;
        }
    }
}