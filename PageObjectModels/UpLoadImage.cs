using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace AutomatedTesting.PageObjectModels
{
    internal class UpLoadImage
    {
        internal string FileUploadUrl = "http://uitestpractice.com/Students/Widgets";

        string selectImage = "image_file";
        internal By ChooseFileImage { get => By.Id(selectImage); }

        string fileUpload = "//input[@type='button']";
        internal By FileUploader { get => By.XPath(fileUpload); }

        string fileUploadResponse = "upload_response";
        internal By SuccessfulUpload { get => By.Id(fileUploadResponse); }
    }
}
