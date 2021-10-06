using System;

namespace SubtleArtOfUnitTesting.EasyToWrite
{
    public class MandateApplicationService
    {
        private readonly IMandateRepository _mandateRepository;

        public MandateApplicationService(IMandateRepository mandateRepository)
        {
            _mandateRepository = mandateRepository;
        }

        public void RemoveMandate(Guid id)
        {
            var mandate = this._mandateRepository.Get(id);

            if (mandate.IsActive())
            {
                throw new InvalidOperationException("You can not remove active mandates.");
            }

            this._mandateRepository.Remove(id);
        }
    }
}