using System;
using SubtleArtOfUnitTesting.Financial;

namespace SubtleArtOfUnitTesting.EasyToWrite
{
    public interface IMandateRepository
    {
        RebalancingMandate Get(Guid id);

        void Remove(Guid id);
    }
}