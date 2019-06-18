// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Used to specify the context creation API.
    /// </summary>
    /// <seealso cref="IGLFW.WindowHint(WindowHintContextApi,ContextApi)" />
    public enum WindowHintContextApi
    {
        /// <summary>
        /// Indicates the context creation API used to create the window's context;
        /// either <see cref="ContextApi.NativeContextApi" /> or <see cref="ContextApi.EglContextApi" />.
        /// </summary>
        ContextCreationApi = 0x0002200B
    }
}