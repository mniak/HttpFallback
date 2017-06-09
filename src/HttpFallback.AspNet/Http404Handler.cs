using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http404Handler : HttpErrorHandler
    {
        public Http404Handler() : base(404)
        {
        }
    }
}
