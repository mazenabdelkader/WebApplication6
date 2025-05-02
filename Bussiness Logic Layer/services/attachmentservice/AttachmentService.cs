using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Bussiness_Logic_Layer.services.attachmentservice
{
    public class AttachmentService : IAttachmentService
    {
        public readonly List<string> allowedExtensions = new List<string>() { ".png", ".jpg", ".jpeg" };

        //Max size =>2mb
        public const int maxsize = 2_097_152;     //1024*1024* 2


        public string? Upload(IFormFile file, string FolderName)
        {
            // 1.Check Extension

            var extension = Path.GetExtension(file.FileName);
            if (!allowedExtensions.Contains(extension)) return null;

            // 2.CheckSize

            if (file.Length == 0 || file.Length > maxsize) return null;

            // 3.Get Located Folder Path
            var FolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files", FolderName);

            // 4.Make Attachment Name Unique ==>>  Guide
            var fileName = $"{Guid.NewGuid()}_{file.FileName}";

            // 5.Get File Path
            var filePath = Path.Combine(FolderPath, fileName);  //File Location

            //6.Create File Stream To Copy File [Unmanaged]
            using FileStream fs = new FileStream(filePath, FileMode.Create);

            //7.Use Stream To Copy File
            file.CopyTo(fs);

            //8.Return File Nane Store In Dataase
            return fileName;


        }


        public bool Delete(string filepath)
        {
            if (File.Exists(filepath))
            {
                File.Delete(filepath);
                return true;

            }
            else { return false; }
        }
    }
}
