using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Everest.Business.Commands;

namespace Everest.Business.Contract.Surveys.Commands
{
    public class CreateSurveyCommand : ICommand
    {
        public Survey Survey { get; }

        public CreateSurveyCommand(Survey survey)
        {
            Survey = survey;
        }
    }
}
