using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions {
    public abstract class ACustomException: Exception {

        protected ACustomException(String message, Exception e) : base(message, e) { }
        protected ACustomException(String message) : this(message, null) { }


    }
}
