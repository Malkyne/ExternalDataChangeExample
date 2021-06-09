using System;

namespace ExternalDataChangeExample.Models
{
    public class Arrival
    {
        public string Name { get; set; }
        public DateTime? Timestamp { get; set; }

        public Arrival(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"[{Name}: {Timestamp}]";
        }
    }
}