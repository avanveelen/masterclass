using System;
using System.Collections.Generic;
using SubtleArtOfUnitTesting.Financial;

namespace TestHelpers
{
    public class RebalancingMandateBuilder
    {
        private DateTime _startDate = DateTime.Now;
        private string _mandateName = "Mandate name";

        public RebalancingMandateBuilder WithStartDate(DateTime date)
        {
            this._startDate = date;
            return this;
        }

        public RebalancingMandateBuilder WithName(string name)
        {
            this._mandateName = name;
            return this;
        }

        public RebalancingMandate Build()
        {
            return new RebalancingMandate(
                this._mandateName,
                "Mandate for the new 2022 rules.",
                new Dictionary<string, decimal>
                {
                    ["private equity"] = 0.5m,
                    ["Equity world wide"] = 0.75m,
                    ["emerging markets"] = 0.25m,
                    ["developed markets"] = 0.10m
                },
                _startDate);
        }
    }
}