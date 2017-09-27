using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.Chunks;

namespace Photogram.Models.PictureViewModels
{
    public class ValidatorPicture
    {
        public string PicturePath { get; set; }
        public string PictureName { get; set; }
        public string MimeType { get; set; }

        public ValidatorPicture(string path)
        {
            this.PicturePath = path;
            this.PictureName = Path.GetFileName(this.PicturePath);
            this.MimeType = extractMimePicture();
        }

        public string extractMimePicture()
        {
            string mime = MimeMapping.MimeUtility.GetMimeMapping(PicturePath);
            return mime;
        }

        public bool validatePicture()
        {
            if (this.MimeType == "iamge/jpeg" || this.MimeType == "image/png")
            {
                return true;
            }
            return false;
        }
    }
}
