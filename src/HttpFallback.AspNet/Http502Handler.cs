using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http502Handler : HttpErrorHandler
    {
        public Http502Handler() : base(502)
        {
        }
    }
}
