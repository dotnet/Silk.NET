// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    /// <summary>
    ///     A handle to a Vulkan object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct VkNonDispatchableHandle
    {
        /// <summary>
        /// The actual value of the Vulkan handle.
        /// </summary>
        public ulong Handle;

        /// <summary>
        /// Initializes a new instance of the <see cref="VkNonDispatchableHandle" /> struct.
        /// </summary>
        /// <param name="handle">
        /// The native Vulkan handle.
        /// This is NOT a pointer to a field containing the handle, this is the actual handle itself.
        /// </param>
        public VkNonDispatchableHandle(ulong handle)
        {
            Handle = handle;
        }
    }
}
