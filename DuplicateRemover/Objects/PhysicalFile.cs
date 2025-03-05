using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateRemover.Objects
{
    public class PhysicalFile
    {
        public required string Path { get; set; }
        public required string Hash { get; set; }
    }
}
