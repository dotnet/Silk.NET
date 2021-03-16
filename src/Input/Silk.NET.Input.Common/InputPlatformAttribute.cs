// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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
