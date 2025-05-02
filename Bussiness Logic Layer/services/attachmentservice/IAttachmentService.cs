
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Bussiness_Logic_Layer.services.attachmentservice
{
    public interface IAttachmentService
    {
        public string? Upload(IFormFile file, string FolderName);

        bool Delete(string filepath);
    }
}
