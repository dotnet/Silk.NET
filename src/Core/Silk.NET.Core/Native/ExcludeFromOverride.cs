// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Native
{
    /// <summary>
    /// An attribute indicating that the method it is applied to should be excluded from the given override.
    /// </summary>
    /// <remarks>See SilkTouch documentation.</remarks>
    [AttributeUsage(AttributeTargets.Method)]
    public sealed class ExcludeFromOverrideAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExcludeFromOverrideAttribute"/> class.
        /// </summary>
        /// <param name="id">The Id of the override the method should be excluded from.</param>
        public ExcludeFromOverrideAttribute(int id) { }
    }
}
