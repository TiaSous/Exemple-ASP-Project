using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModel
{
    public class OMToDo
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsFinished { get; set; }
        public int UserId { get; set; }
    }
}
