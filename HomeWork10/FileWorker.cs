using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public abstract class FileWorker
    {
     
    private int _maxFileSize;
        private string _fileExtension;

        public FileWorker(int maxFileSize, string fileExtension)
        {
            _maxFileSize = maxFileSize;
            _fileExtension = fileExtension;
        }

        public int MaxFileSize
        {
            get { return _maxFileSize; }
            set { _maxFileSize = value; }
        }

        public string FileExtension
        {
            get { return _fileExtension; }
            set { _fileExtension = value; }
        }

        public abstract void Read();
        public abstract void Write();
        public abstract void Edit();
        public abstract void Delete();
    }

}

