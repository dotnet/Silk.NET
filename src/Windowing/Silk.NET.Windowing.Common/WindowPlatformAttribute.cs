// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

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