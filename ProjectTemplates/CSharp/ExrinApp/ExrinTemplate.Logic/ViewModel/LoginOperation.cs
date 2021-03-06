﻿using Exrin.Abstraction;
using Exrin.Framework;
using ExrinMobileApp.Framework.Abstraction.Model;
using ExrinMobileApp.Framework.Locator;
using ExrinMobileApp.Framework.Locator.Views;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace $safeprojectname$.ViewModel
{
    public class LoginOperation : ISingleOperation
    {
        private readonly IAuthModel _authModel;

        public LoginOperation(IAuthModel authModel)
        {
            _authModel = authModel;
        }

        public Func<object, CancellationToken, Task<IList<IResult>>> Function
        {
            get
            {
                return async (parameter, token) =>
                {
                    Result result = null;

					if (await _authModel.Login())
						result = new NavigationResult(Stacks.Main, Main.Main);
					else
						result = new Result() { ResultAction = ResultType.Display, Arguments = new DisplayArgs() { Message = "Login was unsuccessful" } };

                    return new List<IResult>() { result };
                };
            }
        }

        public bool ChainedRollback { get; private set; } = false;

        public Func<Task> Rollback { get { return null; } }
    }
}
