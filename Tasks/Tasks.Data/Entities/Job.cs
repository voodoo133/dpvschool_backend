using System;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Data
{
    public class Job
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? Date { get; set; }

        public Job ()
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
        }
    }
}