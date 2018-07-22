using Microsoft.EntityFrameworkCore;
using SimpleImageGallery.Data;
using SimpleImageGallery.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleImageGallery.Services
{
    public class ImageService : IImage
    {
        private readonly SimpleImageGallleryDbcontext _ctx;
        public ImageService (SimpleImageGallleryDbcontext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<GalleryImage> GetAll()
        {
            return _ctx.GalleryImages
                .Include(img => img.ImageTags);
                 
        }

        public GalleryImage GetById(int id)
        {
            return _ctx.GalleryImages.Find(id);
        }
        public IEnumerable<GalleryImage> GetWithTag(string tag)
        {
           return GetAll().Where(img 
               => img.ImageTags
                .Any(t => t.Description == tag));
        }

       

    }
}
