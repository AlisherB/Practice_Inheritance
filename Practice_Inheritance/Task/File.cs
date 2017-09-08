using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class File
    {
        private int fileSize;

        public int FileSize { get; set; }
        
        public File()
        {
            fileSize = 780;
        }
        public File(int fileSize)
        {
            this.fileSize = fileSize;
        }
    }
}
