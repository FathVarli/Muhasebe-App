﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MuhasebeApp.Core.Utils.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
        }

        public SuccessResult() : base(true)
        {
        }
    }
}
