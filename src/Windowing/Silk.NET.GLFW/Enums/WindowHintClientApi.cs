// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Context related client API attribute.
    /// </summary>
    /// <seealso cref="IGlfw.WindowHint(WindowHintClientApi,ClientApi)" />
    public enum WindowHintClientApi
    {
        /// <summary>
        /// Indicates the client API provided by the window's context;
        /// either <see cref="NET.GLFW.ClientApi.OpenGL" />,
        /// <see cref="NET.GLFW.ClientApi.OpenGLES" /> or
        /// <see cref="NET.GLFW.ClientApi.NoApi" />.
        /// </summary>
        ClientApi = 0x00022001
    }
}