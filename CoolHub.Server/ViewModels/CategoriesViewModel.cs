using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoolHub.Entities;
using CoolHub.Models;
using System.Diagnostics;

namespace CoolHub.ViewModels
{
    public class CategoriesViewModel : BaseViewModel, ICategoriesViewModel
    {
        private readonly ICategoryRepository _repository;

        public CategoriesViewModel(ICategoryRepository repository)
        {
            _repository = repository;
        }

        private List<Category> _categories = new List<Category>(); 
        public List<Category> Categories
        {
            get => _categories; 
            private set
            {
                SetValue(ref _categories, value);
            }
        }
    
        private Category _category = new Category(); 
        public Category Category
        {
            get => _category; 
            set
            {
                SetValue(ref _category, value);
            }
        }

        public async Task<Status> CreateCategory(CategoryCreateDTO category)
        {
            IsBusy = true;

            (Status status, int categoryId) response = await _repository.Create(category);

            OnPropertyChanged(nameof(Categories));
            
            IsBusy = false;

            return response.status;
        }
    }
}