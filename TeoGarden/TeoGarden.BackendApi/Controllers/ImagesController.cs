using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using TeoGarden.ShareModel.Requests.Image;

namespace TeoGarden.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ImagesController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("{folder}")]
        public async Task<string> Post([FromForm] ImageUploadRequest fileUploaded, [FromRoute] string folder)
        {
            try
            {
                if(fileUploaded.File.Length > 0)
                {
                    string path = _webHostEnvironment.WebRootPath + "\\images\\" + folder + "\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    var originalFileName = ContentDispositionHeaderValue.Parse(fileUploaded.File.ContentDisposition).FileName.Trim('"');
                    var fileName = $"{Guid.NewGuid()}{Path.GetExtension(originalFileName)}";

                    using (FileStream fileStrem = System.IO.File.Create(path + fileName))
                    {
                        fileUploaded.File.CopyTo(fileStrem);
                        fileStrem.Flush();
                        return fileName;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        [HttpDelete("{folder}/{imageName}")]
        public async Task<string> Delete([FromRoute] string folder, [FromRoute] string imageName)
        {
            try
            {
                string path = _webHostEnvironment.WebRootPath + "\\images\\" + folder + "\\" + imageName;
                if (System.IO.File.Exists(@path))
                {
                    System.IO.File.Delete(@path);
                    return "Delete Done!";
                }
                return "Not found image path";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        [HttpGet("{FileName}")]
        public async Task<IActionResult> Get([FromRoute] string FileName)
        {
            string path = _webHostEnvironment.WebRootPath + "\\images\\";
            var filePath = path + FileName + ".jpg";
            if (System.IO.File.Exists(filePath))
            {
                byte[] b = System.IO.File.ReadAllBytes(filePath);
                return File(b, "image/jpg");
            }
            return null;
        }
    }
}
