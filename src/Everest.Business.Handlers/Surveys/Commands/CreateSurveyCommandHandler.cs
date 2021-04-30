using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Data;

using Everest.Data.Contract.Surveys;

using Everest.Business.Commands;

using Everest.Business.Contract.Surveys;
using Everest.Business.Contract.Surveys.Commands;

namespace Everest.Business.Handlers.Surveys.Commands
{
    public class CreateSurveyCommandHandler : ICommandHandler<CreateSurveyCommand>
    {
        private readonly ITable<SurveyEntity> surveyEntities;

        public CreateSurveyCommandHandler(ITable<SurveyEntity> surveyEntities)
        {
            this.surveyEntities = surveyEntities;
        }

        public void Handle(CreateSurveyCommand command)
        {
            surveyEntities.CreateEntity(Convert(command.Survey));
        }

        private SurveyEntity Convert(Survey survey)
        {
            return new SurveyEntity
            {
                Id = Guid.NewGuid(),
                Name = survey.Name,
                // TODO convert questions
            };
        }
    }
}
