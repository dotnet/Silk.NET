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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_external_memory_win32")]
    public unsafe partial class KhrExternalMemoryWin32 : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_memory_win32";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] MemoryGetWin32HandleInfoKHR* pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandleKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetMemoryWin32Handle([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in MemoryGetWin32HandleInfoKHR pGetWin32HandleInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint pHandle);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetMemoryWin32HandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] nint handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] MemoryWin32HandlePropertiesKHR* pMemoryWin32HandleProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pMemoryWin32HandleProperties = new(StructureType.MemoryWin32HandlePropertiesKhr);")]
        [NativeApi(EntryPoint = "vkGetMemoryWin32HandlePropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial Result GetMemoryWin32HandleProperties([Count(Count = 0)] Device device, [Count(Count = 0)] ExternalMemoryHandleTypeFlags handleType, [Count(Count = 0)] nint handle, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out MemoryWin32HandlePropertiesKHR pMemoryWin32HandleProperties);

        public KhrExternalMemoryWin32(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

