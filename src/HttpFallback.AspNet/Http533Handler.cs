using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http533Handler : HttpErrorHandler
    {
        public Http533Handler() : base(533)
        {
        }
    }
}
