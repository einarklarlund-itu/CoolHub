using CoolHub.Entities;
using CoolHub.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace CoolHub.ViewModels
{
    public interface ICategoriesViewModel
    {
        Status CreateCategory(CategoryCreateDTO category);
    }    
}