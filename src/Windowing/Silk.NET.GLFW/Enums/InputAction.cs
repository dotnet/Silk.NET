// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Defines event information for <see cref="GlfwCallbacks.KeyCallback" />
    /// or <see cref="GlfwCallbacks.MouseButtonCallback" />.
    /// </summary>
    public enum InputAction
    {
        /// <summary>
        /// The key or mouse button was pressed.
        /// </summary>
        Press = 1,

        /// <summary>
        /// The key or mouse button was released.
        /// </summary>
        Release = 0,

        /// <summary>
        /// The key was held down until it repeated.
        /// </summary>
        Repeat = 2
    }
}