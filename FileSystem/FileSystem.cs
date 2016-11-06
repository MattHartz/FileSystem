using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    /// <summary>
    /// The FileSystem Singleton is the meat and potatoes of this project.
    /// It will call the file system actions on the ldisk and memcache when called by the driver class.
    /// </summary>
    class FileSystem
    {
        private static FileSystem instance;

        private FileSystem() {}

        public static FileSystem Instance
        {
            get { return instance ?? (instance = new FileSystem()); }
        }

        /// <summary>
        /// Creates the specified name.
        /// </summary>
        /// <param name="name">The name of the file.</param>
        public void Create(string name) {}

        /// <summary>
        /// Destroys the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        public void Destroy(string name) {}

        /// <summary>
        /// Opens the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public int Open(string name)
        {
            return 0;
        }
        /// <summary>
        /// Closes the specified file.
        /// </summary>
        /// <param name="file">The file.</param>
        public void Close(int file) { }

        /// <summary>
        /// Reads the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="buf">The buf.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        public int Read(int index, Buffer buf, int count)
        {
            return 0;
        }

        /// <summary>
        /// Writes the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="character">The character.</param>
        /// <param name="count">The count.</param>
        /// <returns></returns>
        public int Write(int index, char character, int count)
        {
            return 0;
        }
        /// <summary>
        /// Lseeks the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="pos">The position.</param>
        public void Lseek(int index, int pos) {}

        /// <summary>
        /// Directories this instance.
        /// </summary>
        /// <returns></returns>
        public List<FSfile> Directory()
        {
            return new List<FSfile>();
        }

        /// <summary>
        /// Initializes the specified filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        public void Init(string filename) {}

        /// <summary>
        /// Saves the specified filename.
        /// </summary>
        /// <param name="filename">The filename.</param>
        public void Save(string filename) {}
    }
}
