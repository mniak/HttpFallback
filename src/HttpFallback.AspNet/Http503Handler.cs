using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http503Handler : HttpErrorHandler
    {
        public Http503Handler() : base(503)
        {
        }
    }
}
