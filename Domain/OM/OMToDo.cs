using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.OM
{
    public class OMToDo
    {
        public int UserId { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public bool IsFinished { get; set; }
    }
}
