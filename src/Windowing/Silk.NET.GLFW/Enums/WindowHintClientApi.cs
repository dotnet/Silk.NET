// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

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