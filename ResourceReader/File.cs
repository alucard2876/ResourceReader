using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResourceReader.Buisness.ResourceReader
{
    public class File : ViewModelBase
    {
        private string fileName;
        private string fileExtention;

        public string FileName
        {
            get => GetProperty(() => fileName);
            private set => SetProperty(() => fileName, value);
        }

        public string FileExtention
        {
            get => GetProperty(() => fileExtention);
            private set => SetProperty(() => fileExtention, value);
        }

        public File() { }
        public File(string fileName, string fileExtention)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentNullException(nameof(fileName));
            if (string.IsNullOrEmpty(fileExtention))
                throw new ArgumentNullException(nameof(fileExtention));
            FileName = fileName;
            FileExtention = fileExtention;
    
        }

        public override string ToString()
        {
            return $"{FileName}.{FileExtention}";
        }

    }
}
