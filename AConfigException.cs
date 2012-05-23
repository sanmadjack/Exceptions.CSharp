using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions {
    abstract class  AConfigException: ACustomException {
        public AConfigException(string message) : base(message) { }
    }
}
