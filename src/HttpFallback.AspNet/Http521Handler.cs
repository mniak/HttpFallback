using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http521Handler : HttpErrorHandler
    {
        public Http521Handler() : base(521)
        {
        }
    }
}
