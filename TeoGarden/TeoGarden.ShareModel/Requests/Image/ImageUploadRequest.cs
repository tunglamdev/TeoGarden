using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoGarden.ShareModel.Requests.Image
{
    public class ImageUploadRequest
    {
        public IFormFile File { set; get; }
    }
}
