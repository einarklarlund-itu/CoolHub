using CoolHub.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace CoolHub.ViewModels
{
    public interface IResourceViewModel
    {
        Status CreateResource(ResourceCreateDTO category);
    }    
}