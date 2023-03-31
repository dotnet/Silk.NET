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

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_coverage_reduction_mode")]
    public unsafe partial class NVCoverageReductionMode : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_coverage_reduction_mode";
        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pCombinationCount, [Count(Parameter = "pCombinationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] FramebufferMixedSamplesCombinationNV* pCombinations);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCombinations = new(StructureType.FramebufferMixedSamplesCombinationNV);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pCombinationCount, [Count(Parameter = "pCombinationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out FramebufferMixedSamplesCombinationNV pCombinations);

        /// <summary>To be documented.</summary>
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pCombinationCount, [Count(Parameter = "pCombinationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] FramebufferMixedSamplesCombinationNV* pCombinations);

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCombinations = new(StructureType.FramebufferMixedSamplesCombinationNV);")]
        [NativeApi(EntryPoint = "vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV", Convention = CallingConvention.Winapi)]
        public partial Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination([Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] ref uint pCombinationCount, [Count(Parameter = "pCombinationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out FramebufferMixedSamplesCombinationNV pCombinations);

        public NVCoverageReductionMode(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

