using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Exceptions {
    public class WriteDeniedException: AFileSystemException {
        public WriteDeniedException(FileSystemInfo info): this(info,null) {
        }
        public WriteDeniedException(FileSystemInfo info, Exception e)
            : base(info, e) {
        }

    }
}
