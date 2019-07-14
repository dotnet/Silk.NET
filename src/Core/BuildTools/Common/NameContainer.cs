// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Generator.Common
{
    /// <summary>
    /// Represents a platform name container.
    /// </summary>
    public class NameContainer
    {
        /// <summary>
        /// Gets or sets the Linux library name.
        /// </summary>
        public string Linux { get; set; }

        /// <summary>
        /// Gets or sets the Windows library name.
        /// </summary>
        public string Windows { get; set; }

        /// <summary>
        /// Gets or sets the OSX library name.
        /// </summary>
        public string MacOS { get; set; }

        /// <summary>
        /// Gets or sets the Android library name.
        /// </summary>
        public string Android { get; set; }

        /// <summary>
        /// Gets or sets the iOS library name.
        /// </summary>
        public string IOS { get; set; }

        /// <summary>
        /// Gets or sets the class name of the output name container.
        /// </summary>
        public string ClassName { get; set; }
    }
}
