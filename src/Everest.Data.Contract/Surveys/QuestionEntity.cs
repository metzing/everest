using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Everest.Data.Contract.Surveys
{
    public class QuestionEntity : IEntity
    {
        public Guid Id { get; set; }

        // "What is the meaning of life?"
        public string Inquiry { get; set; }

        // MultipleChoice, ShortText, Date, DateTime, etc.
        public string Type { get; set; }

        public int IndexInSurvey { get; set; }

        public Guid SurveyId { get; set; }
    }
}
