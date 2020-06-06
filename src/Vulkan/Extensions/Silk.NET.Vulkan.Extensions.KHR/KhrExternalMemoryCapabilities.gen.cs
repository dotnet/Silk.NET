// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_external_memory_capabilities")]
    public unsafe partial class KhrExternalMemoryCapabilities : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_memory_capabilities";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties)
            => ImplGetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalBufferInfo pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalBufferProperties pExternalBufferProperties)
            => ImplGetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, pExternalBufferProperties);

        public KhrExternalMemoryCapabilities(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

