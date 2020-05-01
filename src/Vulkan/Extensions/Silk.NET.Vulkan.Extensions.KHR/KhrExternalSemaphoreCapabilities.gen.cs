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
    [Extension("VK_KHR_external_semaphore_capabilities")]
    public abstract unsafe partial class KhrExternalSemaphoreCapabilities : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_semaphore_capabilities";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
        public abstract unsafe void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR")]
        public abstract void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] ref PhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalSemaphoreProperties pExternalSemaphoreProperties);

        public KhrExternalSemaphoreCapabilities(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

