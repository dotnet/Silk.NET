// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Computed = "pToolCount"), Flow(FlowDirection.Out)] PhysicalDeviceToolPropertiesEXT* pToolProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pToolCount, [Count(Computed = "pToolCount"), Flow(FlowDirection.Out)] out PhysicalDeviceToolPropertiesEXT pToolProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        public unsafe partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pToolCount, [Count(Computed = "pToolCount"), Flow(FlowDirection.Out)] PhysicalDeviceToolPropertiesEXT* pToolProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceToolPropertiesEXT")]
        public partial Result GetPhysicalDeviceToolProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pToolCount, [Count(Computed = "pToolCount"), Flow(FlowDirection.Out)] out PhysicalDeviceToolPropertiesEXT pToolProperties);

        public ExtToolingInfo(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

