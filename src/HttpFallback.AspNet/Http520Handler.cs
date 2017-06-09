using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpFallback.AspNet
{
    public class Http520Handler : HttpErrorHandler
    {
        public Http520Handler() : base(520)
        {
        }
    }
}
