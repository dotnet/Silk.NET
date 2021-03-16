// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Core.Native
{
    /// <summary>
    ///     A handle to a Vulkan object.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct VkHandle
    {
        /// <summary>
        /// The actual value of the Vulkan handle.
        /// </summary>
        public nint Handle;

        /// <summary>
        /// Initializes a new instance of the <see cref="VkHandle" /> struct.
        /// </summary>
        /// <param name="handle">
        /// The native Vulkan handle.
        /// This is NOT a pointer to a field containing the handle, this is the actual handle itself.
        /// </param>
        public VkHandle(nint handle)
        {
            Handle = handle;
        }
    }
}
