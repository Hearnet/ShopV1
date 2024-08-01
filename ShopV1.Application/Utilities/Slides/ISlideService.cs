using ShopV1.ViewModels.System.Roles;
using ShopV1.ViewModels.Utilities.Slides;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopV1.Application.Utilities.Slides
{
    public interface ISlideService
    {
        Task<List<SlideVm>> GetAll();
    }
}
