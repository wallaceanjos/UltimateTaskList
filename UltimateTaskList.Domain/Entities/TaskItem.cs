using System;
using System.Collections.Generic;
using System.Text;

namespace UltimateTaskList.Domain.Entities
{
    public class TaskItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }
}
