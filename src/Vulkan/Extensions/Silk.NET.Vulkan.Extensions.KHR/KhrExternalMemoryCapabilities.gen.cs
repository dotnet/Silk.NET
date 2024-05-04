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
    [Extension("VK_KHR_external_memory_capabilities")]
    public unsafe partial class KhrExternalMemoryCapabilities : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_external_memory_capabilities";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalBufferProperties pExternalBufferProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceExternalBufferInfo pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ExternalBufferProperties* pExternalBufferProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceExternalBufferPropertiesKHR", Convention = CallingConvention.Winapi)]
        public partial void GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceExternalBufferInfo pExternalBufferInfo, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ExternalBufferProperties pExternalBufferProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        public unsafe ExternalBufferProperties GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] PhysicalDeviceExternalBufferInfo* pExternalBufferInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceExternalBufferProperties(physicalDevice, pExternalBufferInfo, out ExternalBufferProperties silkRet);
            return silkRet;
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pExternalBufferProperties = new(StructureType.ExternalBufferProperties);")]
        public unsafe ExternalBufferProperties GetPhysicalDeviceExternalBufferProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in PhysicalDeviceExternalBufferInfo pExternalBufferInfo)
        {
            // NonKhrReturnTypeOverloader
            GetPhysicalDeviceExternalBufferProperties(physicalDevice, in pExternalBufferInfo, out ExternalBufferProperties silkRet);
            return silkRet;
        }

        public KhrExternalMemoryCapabilities(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

