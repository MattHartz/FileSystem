using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    /// <summary>
    /// This class will be used to contain data that will be printed onto the screen.
    /// </summary>
    class Buffer
    {
        private static Buffer instance;
        private Buffer() { }

        public static Buffer Instance
        {
            get { return instance ?? (instance = new Buffer()); }
        }
    }
}
