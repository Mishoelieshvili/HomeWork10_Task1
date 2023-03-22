using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
   public class ChildFileWorker : FileWorker
    {
        public ChildFileWorker(int maxFileSize, string fileExtension) : base(maxFileSize, fileExtension)
        {
        }

        public override void Read()
        {
            Console.WriteLine("Reading file...");
        }

        public override void Write()
        {
            Console.WriteLine("Writing file...");
        }

        public override void Edit()
        {
            Console.WriteLine("Editing file...");
        }

        public override void Delete()
        {
            Console.WriteLine("Deleting file...");
        }
    }
}
