// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.BuildTools.Common.Functions;

namespace Silk.NET.BuildTools.Common
{
    /// <summary>
    /// A constant from a native library.
    /// </summary>
    public class Constant
    {
        /// <summary>
        /// The type of the constant.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// The name of the constant.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The name of the constant in the native library.
        /// </summary>
        public string NativeName { get; set; }

        /// <summary>
        /// The value of the constant.
        /// </summary>
        public string Value { get; set; }
    }
}
