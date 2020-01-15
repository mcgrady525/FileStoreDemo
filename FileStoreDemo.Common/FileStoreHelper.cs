using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSharing.Frameworks.Common.Extends;
using SSharing.Frameworks.FileStore;
using SSharing.Frameworks.Common;

namespace FileStoreDemo.Common
{
    public class FileStoreHelper
    {
        public static AliOSSFileStore Instance
        {
            get
            {
                return SingletonProvider<AliOSSFileStore>.Instance;
            }
        }
    }
}
