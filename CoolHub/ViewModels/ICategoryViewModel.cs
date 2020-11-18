using CoolHub.Entities;
using System.Collections.Generic;
using System.ComponentModel;

namespace CoolHub.ViewModels
{
    public interface ICategoriesViewModel
    {
        bool IsBusy { get; set; }
        int TotalCategories { get; }
        Category Category { get; set; }
        List<Category> Categories { get; }

        event PropertyChangedEventHandler PropertyChanged;

        void SaveCategory(Category category);
    }    
}