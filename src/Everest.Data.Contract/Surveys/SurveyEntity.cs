using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Data.Contract.Surveys
{
    public class SurveyEntity : IEntity
    {
        public Guid Id { get; set; }

        // friendly name - or should that be localized?
        public string Name { get; set; }

        // questions of the survey
        public QuestionEntity[] Question { get; set; }
    }
}
