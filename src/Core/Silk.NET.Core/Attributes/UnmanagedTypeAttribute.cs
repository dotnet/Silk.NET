// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using Silk.NET.Core.Native;

namespace Silk.NET.Core.Attributes
{
    /// <summary>
    /// Indicates the unmanaged type a return value or parameter is going to be marshalled as.
    /// </summary>
    /// <seealso cref="UnmanagedType"/>
    /// <remarks>See SilkTouch documentation.</remarks>
    [AttributeUsage(AttributeTargets.ReturnValue | AttributeTargets.Parameter)]
    public class UnmanagedTypeAttribute : Attribute
    {
        // the fields are not stored anywhere, they are to be accessed by SilkTouch via Roslyn
        /// <summary>
        /// Initializes a new instance of the <see cref="UnmanagedTypeAttribute"/> class.
        /// </summary>
        /// <param name="unmanagedType">The target <see cref="UnmanagedType"/>.</param>
        public UnmanagedTypeAttribute(UnmanagedType unmanagedType) { }
    }
}
