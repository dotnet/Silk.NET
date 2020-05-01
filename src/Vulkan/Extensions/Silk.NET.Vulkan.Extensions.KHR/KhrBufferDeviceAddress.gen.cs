// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_buffer_device_address")]
    public abstract unsafe partial class KhrBufferDeviceAddress : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_buffer_device_address";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddressKHR")]
        public abstract unsafe ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferDeviceAddressKHR")]
        public abstract ulong GetBufferDeviceAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferDeviceAddressInfo pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR")]
        public abstract unsafe ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] BufferDeviceAddressInfo* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetBufferOpaqueCaptureAddressKHR")]
        public abstract ulong GetBufferOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref BufferDeviceAddressInfo pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
        public abstract unsafe ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] DeviceMemoryOpaqueCaptureAddressInfo* pInfo);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetDeviceMemoryOpaqueCaptureAddressKHR")]
        public abstract ulong GetDeviceMemoryOpaqueCaptureAddress([Count(Count = 0)] Device device, [Count(Count = 0), Flow(FlowDirection.In)] ref DeviceMemoryOpaqueCaptureAddressInfo pInfo);

        public KhrBufferDeviceAddress(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

