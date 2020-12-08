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
    public class AllCategoriesViewModel : BaseViewModel
    {
        private readonly ICategoryRepository _repository;
        public List<CategoryDetailsDTO> Categories =>
            _repository.Read().ToList();

        public AllCategoriesViewModel(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public int NumberOfCategories()
        {
            return _repository.NumberOfCategories();
        }

        public CategoryDetailsDTO GetCategoryById(int id)
        {
            return _repository.Read(id);
        }

        public ICollection<CategoryDetailsDTO> GetAllCategories()
        {
            return _repository.Read().ToList();
        }

        public Status CreateCategory(CategoryCreateDTO category)
        {
            Debug.WriteLine("CreateCategory called in AllCategoriesViewModel");

            IsBusy = true;

            (Status status, int categoryId) response = _repository.Create(category);

            OnPropertyChanged(nameof(_repository));

            IsBusy = false;

            return response.status;
        }
    }
}