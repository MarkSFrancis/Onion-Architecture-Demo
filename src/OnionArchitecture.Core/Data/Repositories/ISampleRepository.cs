using OnionArchitecture.Core.Data.Models;
using System;
using System.Collections.Generic;

namespace OnionArchitecture.Core.Data.Repositories
{
    public interface ISampleRepository
    {
        IEnumerable<SampleDataModel> GetAll();

        SampleDataModel GetSingle(Guid id);
    }
}
