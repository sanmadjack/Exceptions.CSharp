using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Exceptions {
    public abstract class AFileSystemException: ACustomException {
        public FileSystemInfo info;

        public AFileSystemException(FileSystemInfo info): this(info,null) {
        }
        public AFileSystemException(FileSystemInfo info, Exception e): base(info.FullName,e) {
            this.info = info;
        }
    }
}
