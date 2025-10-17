using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateRemover.Objects
{
    public class UniqueFile
    {
        public UniqueFile()
        {
            Paths = new List<string>();
        }
        public required string Hash {  get; set; }
        //public long SizeInBytes { get; set; }
        //public required string Extension { get; set; }
        public List<string> Paths { get; set; }
    }
}
