﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http500Handler : HttpErrorHandler
    {
        public Http500Handler() : base(500)
        {
        }
    }
}
