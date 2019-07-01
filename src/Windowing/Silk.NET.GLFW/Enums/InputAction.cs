// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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
        Press = 0,

        /// <summary>
        /// The key or mouse button was released.
        /// </summary>
        Release = 1,

        /// <summary>
        /// The key was held down until it repeated.
        /// </summary>
        Repeat = 2
    }
}