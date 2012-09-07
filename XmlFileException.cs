using System;
using System.IO;
namespace Exceptions {
    class XmlFileException : AFileSystemException {
        public XmlFileException(FileSystemInfo info)
            : this(info, null) {
        }
        public XmlFileException(FileSystemInfo info, Exception e)
            : base(info, e) {
        }


    }
}
