using Shared.Utilities.Results.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Utilities.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }// ResultStatus.Success // ResultStatus.Error // ResultStatus.Warning  
        public string Message { get; }
        public Exception Exception { get; }
    }
}
