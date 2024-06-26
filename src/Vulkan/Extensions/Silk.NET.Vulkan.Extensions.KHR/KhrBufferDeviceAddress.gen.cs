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
    [Extension("VK_KHR_buffer_device_address")]
    public unsafe partial class KhrBufferDeviceAddress : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_buffer_device_address";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddressKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddressKHR", Convention = CallingConvention.Winapi)]
        public partial ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferDeviceAddressInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR", Convention = CallingConvention.Winapi)]
        public partial ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BufferDeviceAddressInfo pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] DeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR", Convention = CallingConvention.Winapi)]
        public partial ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DeviceMemoryOpaqueCaptureAddressInfo pInfo);

        public KhrBufferDeviceAddress(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

