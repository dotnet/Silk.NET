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
    [Extension("VK_KHR_external_semaphore_capabilities")]
    public unsafe partial class KhrExternalSemaphoreCapabilities : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_semaphore_capabilities";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalSemaphoreProperties = new(StructureType.ExternalSemaphoreProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalSemaphoreProperties pExternalSemaphoreProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalSemaphoreProperties* pExternalSemaphoreProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalSemaphoreProperties = new(StructureType.ExternalSemaphoreProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalSemaphorePropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial void GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalSemaphoreProperties pExternalSemaphoreProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalSemaphoreProperties = new(StructureType.ExternalSemaphoreProperties);")]
        public unsafe ExternalSemaphoreProperties GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalSemaphoreInfo* pExternalSemaphoreInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, pExternalSemaphoreInfo, out ExternalSemaphoreProperties silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalSemaphoreProperties = new(StructureType.ExternalSemaphoreProperties);")]
        public unsafe ExternalSemaphoreProperties GetPhysicalDeviceExternalSemaphoreProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceExternalSemaphoreInfo pExternalSemaphoreInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceExternalSemaphoreProperties(physicalDevice, in pExternalSemaphoreInfo, out ExternalSemaphoreProperties silkRet);
            return silkRet;
        }

        public KhrExternalSemaphoreCapabilities(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

