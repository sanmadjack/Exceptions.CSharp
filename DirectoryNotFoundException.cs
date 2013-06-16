using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exceptions {
	public class DirectoryNotFoundException: Exception {
		public DirectoryNotFoundException(string message): base(message) {
		}
	}
}
