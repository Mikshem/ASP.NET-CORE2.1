using System.Collections.Generic;
using SimpleImageGallery.Data.Models;

namespace SimpleImageGallery.Models
{
    public class GalleryIndexModel
    {
        public IEnumerable<GalleryImage> Images { get; set; }

        public string SearchQuery { get; set; }
    }
}
