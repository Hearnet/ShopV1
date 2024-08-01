using ShopV1.Application.System.Roles;
using ShopV1.Data.EF;
using ShopV1.Data.Entities;
using ShopV1.ViewModels.System.Roles;
using ShopV1.ViewModels.Utilities.Slides;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopV1.Application.Utilities.Slides
{
    public class SlideService : ISlideService
    {
        private readonly ShopV1DbContext _context;

        public SlideService(ShopV1DbContext context)
        {
            _context = context;
        }

        public async Task<List<SlideVm>> GetAll()
        {
            var slides = await _context.Slides.OrderBy(x => x.SortOrder)
                .Select(x => new SlideVm()
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    Url = x.Url,
                    Image = x.Image
                }).ToListAsync();

            return slides;
        }
    }
}
