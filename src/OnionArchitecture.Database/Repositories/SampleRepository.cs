using OnionArchitecture.Core.Data.Models;
using OnionArchitecture.Core.Data.Repositories;
using System;
using System.Collections.Generic;

namespace OnionArchitecture.Database.Repositories
{
    public class SampleRepository : ISampleRepository
    {
        public IEnumerable<SampleDataModel> GetAll()
        {
            yield return new SampleDataModel
            {
                Id = Guid.NewGuid(),
                Description = "Test 1"
            };

            yield return new SampleDataModel
            {
                Id = Guid.NewGuid(),
                Description = "Test 2"
            };

            yield return new SampleDataModel
            {
                Id = Guid.NewGuid(),
                Description = "Test 3"
            };
        }

        public SampleDataModel GetSingle(Guid id)
        {
            return new SampleDataModel
            {
                Id = id,
                Description = "Single Sample Model"
            };
        }
    }
}
