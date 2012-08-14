using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions {
    public class WTFException: Exception {
        public WTFException(Exception ex) : base(null,ex) { }
        public WTFException(string message, Exception ex) : base(message, ex) { }
        public WTFException(string message) : base(message) { }
    }
}
