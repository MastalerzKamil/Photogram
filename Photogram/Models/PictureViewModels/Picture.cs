using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Photogram.Models.PictureViewModels
{
    public class Picture
    {
        public string PicturePath { get; set; }
        public string PictureName { get; set; }
        public string MimeType { get; set; }

        public Picture(string path)
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
    }
}
