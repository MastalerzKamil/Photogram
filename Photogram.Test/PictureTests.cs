using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Photogram.Models.PictureViewModels;

namespace Photogram.Test
{
    [TestClass]
    public class PictureTests
    {
        [TestMethod]
        public void isJPGMime_GoodMime_ReturnsImageJpeg()
        {
            string path = "~/images/uploadedPicture/coffe.jpg";
            Picture uploadedPicture = new Picture(path);

            //ACT
            string mime=uploadedPicture.extractMimePicture();

            //ASSERT
            Assert.AreEqual("image/jpeg", mime.ToString());
        }

        [TestMethod]
        public void isBadPngMime_GivenPngWhenJpeg()
        {
            string path = "~/images/uploadedPicture/coffe.png";
            Picture uploadedPicture = new Picture(path);

            string mime = uploadedPicture.extractMimePicture();

            Assert.AreNotEqual("image/png", mime.ToString());
        }

        [TestMethod]
        public void isGoodPngMime_GivenPngWhenJpeg()
        {
            string path = "~/images/uploadedPicture/coffe.png";
            Picture uploadedPicture = new Picture(path);

            string mime = uploadedPicture.extractMimePicture();

            Assert.AreEqual("image/png", mime.ToString());
        }

        [TestMethod]
        public void extractingFileName_ReturnsFileName()
        {
            string path = "~/images/uploadedPicture/cityPhoto.jpg";
            string searchedFileName = "cityPhoto.jpg";
            Picture uploadedFileName =new Picture(path);

            string fileName = uploadedFileName.PictureName;

            Assert.AreEqual("cityPhoto.jpg", fileName.ToString());
        }
    }
}
