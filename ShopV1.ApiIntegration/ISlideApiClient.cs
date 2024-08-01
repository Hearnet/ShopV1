using ShopV1.ViewModels.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopV1.ApiIntegration
{
    public interface ISlideApiClient
    {
        Task<List<SlideVm>> GetAll();
    }
}
