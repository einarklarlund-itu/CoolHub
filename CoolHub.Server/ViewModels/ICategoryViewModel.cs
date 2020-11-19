using CoolHub.Entities;
using CoolHub.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace CoolHub.ViewModels
{
    public interface ICategoriesViewModel
    {
        bool IsBusy { get; set; }
        Category Category { get; set; }
        List<Category> Categories { get; }

        event PropertyChangedEventHandler PropertyChanged;

        Task<Status> CreateCategory(CategoryCreateDTO category);
    }    
}