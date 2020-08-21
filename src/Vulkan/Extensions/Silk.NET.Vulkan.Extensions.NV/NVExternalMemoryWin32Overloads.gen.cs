// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVExternalMemoryWin32Overloads
    {
        /// <summary>To be added.</summary>
        public static unsafe Result GetMemoryWin32Handle(this NVExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV handleType, [Count(Count = 0), Flow(FlowDirection.Out)] Span<IntPtr> pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32Handle(device, memory, handleType, out pHandle.GetPinnableReference());
        }

    }
}

