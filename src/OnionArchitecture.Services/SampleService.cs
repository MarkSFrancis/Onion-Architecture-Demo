using OnionArchitecture.Core.Data.Models;
using OnionArchitecture.Core.Data.Repositories;
using OnionArchitecture.Core.Services;
using OnionArchitecture.Core.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnionArchitecture.Services
{
    public class SampleService : ISampleService
    {
        private readonly ISampleRepository sampleRepository;

        public SampleService(ISampleRepository sampleRepository)
        {
            this.sampleRepository = sampleRepository;
        }

        public IEnumerable<SampleUIModel> GetAll()
        {
            return sampleRepository.GetAll().Select(Map);
        }

        public SampleUIModel GetSingle(Guid id)
        {
            var dataModel = sampleRepository.GetSingle(id);

            return Map(dataModel);
        }

        private SampleUIModel Map(SampleDataModel dataModel)
        {
            return new SampleUIModel
            {
                Description = dataModel.Description
            };
        }
    }
}
