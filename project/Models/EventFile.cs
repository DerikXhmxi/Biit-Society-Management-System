using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Models
{
    public class EventFile
    {
        public int EventId { get; set; }
        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string FileType { get; set; }
    }
}
