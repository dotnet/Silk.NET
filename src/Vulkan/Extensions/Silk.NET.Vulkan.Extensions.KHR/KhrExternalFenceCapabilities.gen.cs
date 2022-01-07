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
    [Extension("VK_KHR_external_fence_capabilities")]
    public unsafe partial class KhrExternalFenceCapabilities : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_fence_capabilities";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalFenceProperties = new(StructureType.ExternalFenceProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] PhysicalDeviceExternalFenceInfo* pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalFenceProperties pExternalFenceProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceExternalFenceInfo pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] ExternalFenceProperties* pExternalFenceProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalFenceProperties = new(StructureType.ExternalFenceProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalFencePropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial void GetPhysicalDeviceExternalFenceProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(FlowDirection.In)] in PhysicalDeviceExternalFenceInfo pExternalFenceInfo, [Count(Count = 0), Flow(FlowDirection.Out)] out ExternalFenceProperties pExternalFenceProperties);

        public KhrExternalFenceCapabilities(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

