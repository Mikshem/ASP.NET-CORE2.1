using System;
using Microsoft.EntityFrameworkCore;
using SimpleImageGallery.Data.Models;

namespace SimpleImageGallery.Data
{
    public class SimpleImageGallleryDbcontext:DbContext
    {
        public SimpleImageGallleryDbcontext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<GalleryImage> GalleryImages { get; set; }
        public DbSet<ImageTag> ImageTags { get; set; }

    }
}
