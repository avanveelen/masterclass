using System;
using System.Collections.Generic;

namespace SubtleArtOfUnitTesting.Financial
{
    public class RebalancingMandate
    {
        public RebalancingMandate(string name, string description, Dictionary<string, decimal> values, DateTime startDate)
        {
            Name = name;
            Description = description;
            Values = values;
            StartDate = startDate;
        }
        public string Name { get; }

        public string Description { get; }

        public Dictionary<string, decimal> Values { get; }

        public DateTime StartDate { get; }

        public bool IsActive()
        {
            return this.StartDate <= DateTime.Now;
        }
    }
}