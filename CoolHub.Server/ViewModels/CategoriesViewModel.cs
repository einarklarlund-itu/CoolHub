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
    public class CategoriesViewModel : BaseViewModel, ICategoriesViewModel
    {
        private readonly ICategoryRepository _repository;

        public CategoriesViewModel(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public int NumberOfCategories()
        {
            return _repository.NumberOfCategories();
        }

        public async Task<List<CategoryDetailsDTO>> GetCategoryDetails()
        {
            IQueryable<CategoryDetailsDTO> details = await _repository.Read();
            return await details.ToListAsync();
        }

        public async Task<Status> CreateCategory(CategoryCreateDTO category)
        {
            Debug.WriteLine("CreateCategory called in CategoriesViewModel");

            IsBusy = true;

            (Status status, int categoryId) response = await _repository.Create(category);

            OnPropertyChanged(nameof(_repository));

            IsBusy = false;

            return response.status;
        }
    }
}