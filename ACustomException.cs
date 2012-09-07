using System;

namespace Exceptions {
    public abstract class ACustomException : Exception {

        protected ACustomException(String message, Exception e) : base(message, e) { }
        protected ACustomException(String message) : this(message, null) { }


    }
}
