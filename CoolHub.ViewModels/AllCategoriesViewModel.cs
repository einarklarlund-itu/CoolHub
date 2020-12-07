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
        public List<CategoryDetailsDTO> Categories =>
            _categoryRepository.Read().ToList();

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

            (Status status, int categoryId) response = _topicRepository.Create(topic);

            OnPropertyChanged(nameof(_topicRepository));

            IsBusy = false;

            return response.status;
        }
    }
}