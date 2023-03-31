// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVExternalMemoryWin32Overloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe Result GetMemoryWin32Handle(this NVExternalMemoryWin32 thisApi, [Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV handleType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> pHandle)
        {
            // SpanOverloader
            return thisApi.GetMemoryWin32Handle(device, memory, handleType, out pHandle.GetPinnableReference());
        }

    }
}

