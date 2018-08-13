using OnionArchitecture.Core.UI;
using System;
using System.Collections.Generic;

namespace OnionArchitecture.Core.Services
{
    public interface ISampleService
    {
        IEnumerable<SampleUIModel> GetAll();

        SampleUIModel GetSingle(Guid id);
    }
}
