using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace Exceptions {
    class XmlFileException: AFileSystemException {
        public XmlFileException(FileSystemInfo info): this(info,null) {
        }
        public XmlFileException(FileSystemInfo info, Exception e)
            : base(info, e) {
        }


    }
}
