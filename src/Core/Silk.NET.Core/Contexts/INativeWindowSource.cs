// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Core.Contexts
{
    public interface INativeWindowSource
    {
        /// <summary>
        /// Gets the <see cref="INativeWindow"/> instance representing the underlying native window handle(s), or null
        /// if a native window has not been created (i.e. because the window has not been initialized yet)
        /// </summary>
        public INativeWindow? Native { get; }
    }
}
