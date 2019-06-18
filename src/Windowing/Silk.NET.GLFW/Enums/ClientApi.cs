// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// The context client APIs.
    /// </summary>
    /// <seealso cref="IGLFW.WindowHint(WindowHintClientApi,ClientApi)" />
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