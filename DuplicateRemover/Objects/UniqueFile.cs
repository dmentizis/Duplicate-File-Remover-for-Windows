using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateRemover.Objects
{
    public class UniqueFile
    {
        public required string Hash {  get; set; }
        public List<string> Paths { get; set; }
        public UniqueFile() 
        {
            Paths = new List<string>();
        }
    }
}
