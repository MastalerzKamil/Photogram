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
    public class ValidatorPicture : Picture
    {

        public ValidatorPicture(string path) : base(path)
        {

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
