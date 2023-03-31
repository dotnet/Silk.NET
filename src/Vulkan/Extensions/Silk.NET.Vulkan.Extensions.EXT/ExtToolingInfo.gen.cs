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

namespace Silk.NET.Vulkan.Extensions.EXT
{
    [Extension("VK_EXT_tooling_info")]
    public unsafe partial class ExtToolingInfo : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_EXT_tooling_info";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceToolProperties* pToolProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pToolProperties = new(StructureType.PhysicalDeviceToolProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PhysicalDeviceToolProperties pToolProperties);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] PhysicalDeviceToolProperties* pToolProperties);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pToolProperties = new(StructureType.PhysicalDeviceToolProperties);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pToolCount, [Count(Parameter = "pToolCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out PhysicalDeviceToolProperties pToolProperties);

        public ExtToolingInfo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

