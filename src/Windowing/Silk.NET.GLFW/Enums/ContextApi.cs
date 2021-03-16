// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// The context API used to create the window context.
    /// </summary>
    public enum ContextApi
    {
        /// <summary>
        /// Uses the native context API to create the window context.
        /// </summary>
        NativeContextApi = 0x00036001,

        /// <summary>
        /// Uses Egl to create the window context.
        /// </summary>
        EglContextApi = 0x00036002
    }
}