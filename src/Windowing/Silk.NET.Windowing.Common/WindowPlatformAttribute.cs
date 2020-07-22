// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.ComponentModel;

namespace Silk.NET.Windowing
{
    /// <summary>
    /// An assembly attribute which points the registrar to a type that implements <see cref="IWindowPlatform"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class WindowPlatformAttribute : Attribute
    {
        /// <summary>
        /// Creates a <see cref="WindowPlatformAttribute"/> using the given type.
        /// </summary>
        /// <param name="type">The <see cref="IWindowPlatform"/> type.</param>
        public WindowPlatformAttribute(Type type)
        {
            Type = type;
        }

        /// <summary>
        /// The <see cref="IWindowPlatform"/> type.
        /// </summary>
        public Type Type { get; }
    }
}
