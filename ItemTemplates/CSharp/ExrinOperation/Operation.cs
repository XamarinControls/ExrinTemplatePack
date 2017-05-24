using Exrin.Abstraction;
using Exrin.Framework;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace $rootnamespace$
{
	public class $safeitemrootname$ : ISingleOperation
    {

        public $safeitemrootname$() // Insert parameters, such as a Model reference
        {
        
        }

        public Func<object, CancellationToken, Task<IList<IResult>>> Function
        {
            get
            {
                return async (parameter, token) =>
                {
                    Result result = null;

                    // Insert Logic Here
                
                    return new List<IResult>() { result };
                };
            }
        }

        public bool ChainedRollback { get; private set; } = false;

        public Func<Task> Rollback { get { return null; } }
    }
}
