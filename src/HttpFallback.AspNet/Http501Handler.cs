using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http501Handler : HttpErrorHandler
    {
        public Http501Handler() : base(501)
        {
        }
    }
}
