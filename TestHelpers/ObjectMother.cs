using System;
using System.Collections.Generic;
using SubtleArtOfUnitTesting.Financial;

namespace TestHelpers
{
    public class ObjectMother
    {
        public static RebalancingMandate FutureMandate = new RebalancingMandate(
            "Client X Mandate 2022",
            "Mandate for the new 2022 rules.",
            new Dictionary<string, decimal>
            {
                ["private equity"] = 0.5m,
                ["Equity world wide"] = 0.75m,
                ["emerging markets"] = 0.25m,
                ["developed markets"] = 0.10m
            },
            new DateTime(2022, 01, 01));

        public static RebalancingMandate ActiveMandate = new RebalancingMandate(
            "Client X Mandate 2022",
            "Mandate for the new 2022 rules.",
            new Dictionary<string, decimal>
            {
                ["private equity"] = 0.5m,
                ["Equity world wide"] = 0.75m,
                ["emerging markets"] = 0.25m,
                ["developed markets"] = 0.10m
            },
            new DateTime(2021, 01, 01));

        public static RebalancingMandateBuilder Mandate = new RebalancingMandateBuilder();
    }
}