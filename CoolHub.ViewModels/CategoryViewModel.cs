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
    public class CategoryViewModel : BaseViewModel
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITopicRepository _topicRepository;
        
        public int CategoryId { get; set; }

        public List<CategoryDetailsDTO> Categories =>_categoryRepository.Read().ToList();
        public ICollection<TopicDTO> TopicDTOs => _categoryRepository.Read(CategoryId).Topics;

        public CategoryViewModel(ICategoryRepository categoryRepository, ITopicRepository topicRepository)
        {
            _categoryRepository = categoryRepository;
            _topicRepository = topicRepository;
        }

        public CategoryDetailsDTO GetCategoryById(int id)
        {
            return _categoryRepository.Read(id);
        }

        public Status CreateTopic(TopicCreateDTO topic)
        {
            IsBusy = true;

            topic.CategoryId = CategoryId;

            (Status status, int topicId) response = _topicRepository.Create(topic);

            OnPropertyChanged(nameof(_topicRepository));
            OnPropertyChanged(nameof(_categoryRepository));

            IsBusy = false;

            return response.status;
        }
    }
}