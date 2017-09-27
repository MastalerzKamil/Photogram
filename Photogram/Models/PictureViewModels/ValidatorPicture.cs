using System;
using System.Collections.Generic;
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

        public ValidatorPicture(string path)
        {
            this.PicturePath = path;
        }

        public string isPictureJPG()
        {
            string mime = MimeMapping.MimeUtility.GetMimeMapping(PicturePath);
            return mime;
            return null;
        }
    }
}
