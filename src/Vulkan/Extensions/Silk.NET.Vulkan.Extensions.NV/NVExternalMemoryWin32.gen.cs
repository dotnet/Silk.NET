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
using Silk.NET.Vulkan;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_external_memory_win32")]
    public unsafe partial class NVExternalMemoryWin32 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_external_memory_win32";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV handleType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleNV", Convention = CallingConvention.Winapi)]
        public partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0)] DeviceMemory memory, [Count(Count = 0)] ExternalMemoryHandleTypeFlagsNV handleType, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint pHandle);

        public NVExternalMemoryWin32(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

