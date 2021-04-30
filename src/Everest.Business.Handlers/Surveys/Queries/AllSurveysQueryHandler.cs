using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Business.Queries;

using Everest.Business.Contract.Surveys;
using Everest.Business.Contract.Surveys.Queries;

using Everest.Data;
using Everest.Data.Contract.Surveys;

namespace Everest.Business.Handlers.Surveys.Queries
{
    public class AllSurveysQueryHandler : IQueryHandler<AllSurveysQuery, Survey[]>
    {
        private readonly ITable<SurveyEntity> surveyEntities;

        public AllSurveysQueryHandler(ITable<SurveyEntity> surveyEntities)
        {
            this.surveyEntities = surveyEntities;
        }

        public Survey[] Handle(AllSurveysQuery query)
        {
            return surveyEntities.Select(Convert).ToArray();
        }

        private static Survey Convert(SurveyEntity entity) => new Survey(entity.Name);
    }
}
