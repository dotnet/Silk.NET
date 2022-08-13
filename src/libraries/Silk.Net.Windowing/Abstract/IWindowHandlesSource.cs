// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
namespace Silk.NET.Core
{
    /// <summary>
    /// Represents something that has access to a window handle
    /// </summary>
    public interface IWindowHandlesSource
    {
        /// <summary>
        /// The native handles this window could possibly have, the .Net foundation reserves the right to append to this list as they see fit
        /// </summary>
        WindowHandles Native { get; }
    }
}
