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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_cooperative_matrix")]
    public unsafe partial class NVCooperativeMatrix : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_cooperative_matrix";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        public unsafe partial Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] CooperativeMatrixPropertiesNV* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        public unsafe partial Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out CooperativeMatrixPropertiesNV pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        public unsafe partial Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] CooperativeMatrixPropertiesNV* pProperties);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceCooperativeMatrixPropertiesNV")]
        public partial Result GetPhysicalDeviceCooperativeMatrixProperties([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pPropertyCount, [Count(Computed = "pPropertyCount"), Flow(FlowDirection.Out)] out CooperativeMatrixPropertiesNV pProperties);

        public NVCooperativeMatrix(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

