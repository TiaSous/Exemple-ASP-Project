﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }

        // Navigation property
        public ICollection<ToDoEntity> ToDos { get; set; }
    }
}
