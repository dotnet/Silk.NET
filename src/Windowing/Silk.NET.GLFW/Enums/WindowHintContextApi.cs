// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Used to specify the context creation API.
    /// </summary>
    /// <seealso cref="IGlfw.WindowHint(WindowHintContextApi,ContextApi)" />
    public enum WindowHintContextApi
    {
        /// <summary>
        /// Indicates the context creation API used to create the window's context;
        /// either <see cref="ContextApi.NativeContextApi" /> or <see cref="ContextApi.EglContextApi" />.
        /// </summary>
        ContextCreationApi = 0x0002200B
    }
}