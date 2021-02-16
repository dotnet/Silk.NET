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

namespace Silk.NET.Vulkan.Extensions.KHR
{
    [Extension("VK_KHR_fragment_shading_rate")]
    public unsafe partial class KhrFragmentShadingRate : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_KHR_fragment_shading_rate";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetFragmentShadingRateKHR")]
        public unsafe partial void CmdSetFragmentShadingRate([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] Extent2D* pFragmentSize, [Count(Count = 0)] FragmentShadingRateCombinerOpKHR combinerOps);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkCmdSetFragmentShadingRateKHR")]
        public partial void CmdSetFragmentShadingRate([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0), Flow(FlowDirection.In)] in Extent2D pFragmentSize, [Count(Count = 0)] FragmentShadingRateCombinerOpKHR combinerOps);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFragmentShadingRatesKHR")]
        public unsafe partial Result GetPhysicalDeviceFragmentShadingRates([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pFragmentShadingRateCount, [Count(Computed = "pFragmentShadingRateCount"), Flow(FlowDirection.Out)] PhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFragmentShadingRatesKHR")]
        public unsafe partial Result GetPhysicalDeviceFragmentShadingRates([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pFragmentShadingRateCount, [Count(Computed = "pFragmentShadingRateCount"), Flow(FlowDirection.Out)] out PhysicalDeviceFragmentShadingRateKHR pFragmentShadingRates);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFragmentShadingRatesKHR")]
        public unsafe partial Result GetPhysicalDeviceFragmentShadingRates([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pFragmentShadingRateCount, [Count(Computed = "pFragmentShadingRateCount"), Flow(FlowDirection.Out)] PhysicalDeviceFragmentShadingRateKHR* pFragmentShadingRates);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceFragmentShadingRatesKHR")]
        public partial Result GetPhysicalDeviceFragmentShadingRates([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pFragmentShadingRateCount, [Count(Computed = "pFragmentShadingRateCount"), Flow(FlowDirection.Out)] out PhysicalDeviceFragmentShadingRateKHR pFragmentShadingRates);

        public KhrFragmentShadingRate(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

