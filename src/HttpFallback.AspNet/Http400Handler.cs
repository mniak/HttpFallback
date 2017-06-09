using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http400Handler : HttpErrorHandler
    {
        public Http400Handler() : base(400)
        {
        }
    }
}
