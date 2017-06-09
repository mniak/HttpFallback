using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http403Handler : HttpErrorHandler
    {
        public Http403Handler() : base(403)
        {
        }
    }
}
