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
    [Extension("VK_KHR_external_memory_capabilities")]
    public abstract unsafe partial class KhrExternalMemoryCapabilities : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_memory_capabilities";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
        public abstract unsafe void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR")]
        public abstract void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalBufferInfo pExternalBufferInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalBufferProperties pExternalBufferProperties);

        public KhrExternalMemoryCapabilities(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

