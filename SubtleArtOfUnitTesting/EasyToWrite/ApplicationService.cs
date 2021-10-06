using System;
using System.Data;
using SubtleArtOfUnitTesting.Financial;

namespace SubtleArtOfUnitTesting.EasyToWrite
{
    public class ApplicationService
    {
        public void RemoveMandate(Guid id)
        {
            var database = new Database("connectionString:localhost:database:username:password");
            var mandateData = database.Get($"SELECT * FROM RebalancingMandate WHERE id = {id};");
            var mandate = CreateMandate(mandateData);

            if (mandate.IsActive())
            {
                throw new InvalidOperationException("You can not remove active mandates.");
            }

            database.Execute($"DELETE FROM RebalancingMandate WHERE id = {id};");
        }

        private RebalancingMandate CreateMandate(DataTable mandateData)
        {
            return null;
        }
    }
}