// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// The context client APIs.
    /// </summary>
    /// <seealso cref="IGlfw.WindowHint(WindowHintClientApi,ClientApi)" />
    public enum ClientApi
    {
        /// <summary>
        /// No context API is created.
        /// </summary>
        NoApi = 0,

        /// <summary>
        /// OpenGL context is created.
        /// </summary>
        OpenGL = 0x00030001,

        /// <summary>
        /// OpenGL ES context is created.
        /// </summary>
        OpenGLES = 0x00030002
    }
}