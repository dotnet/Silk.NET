// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.ComponentModel;

namespace Silk.NET.Input
{
    /// <summary>
    /// An assembly attribute which points the registrar to a type that implements <see cref="IInputPlatform"/>
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly)]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class InputPlatformAttribute : Attribute
    {
        /// <summary>
        /// Creates a <see cref="InputPlatformAttribute"/> using the given type.
        /// </summary>
        /// <param name="type">The <see cref="IInputPlatform"/> type.</param>
        public InputPlatformAttribute(Type type)
        {
            Type = type;
        }

        /// <summary>
        /// The <see cref="IInputPlatform"/> type.
        /// </summary>
        public Type Type { get; }
    }
}
