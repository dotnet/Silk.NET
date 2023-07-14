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

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    public static class NVCoverageReductionModeOverloads
    {
        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCombinations = new(StructureType.FramebufferMixedSamplesCombinationNV);")]
        public static unsafe Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(this NVCoverageReductionMode thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] uint* pCombinationCount, [Count(Parameter = "pCombinationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<FramebufferMixedSamplesCombinationNV> pCombinations)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(physicalDevice, pCombinationCount, out pCombinations.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(this NVCoverageReductionMode thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pCombinationCount, [Count(Parameter = "pCombinationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] FramebufferMixedSamplesCombinationNV* pCombinations)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(physicalDevice, ref pCombinationCount.GetPinnableReference(), pCombinations);
        }

        /// <summary>To be documented.</summary>
        [Inject(SilkTouchStage.Begin, "pCombinations = new(StructureType.FramebufferMixedSamplesCombinationNV);")]
        public static unsafe Result GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(this NVCoverageReductionMode thisApi, [Count(Count = 0)] PhysicalDevice physicalDevice, [Count(Count = 0)] Span<uint> pCombinationCount, [Count(Parameter = "pCombinationCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<FramebufferMixedSamplesCombinationNV> pCombinations)
        {
            // SpanOverloader
            return thisApi.GetPhysicalDeviceSupportedFramebufferMixedSamplesCombination(physicalDevice, ref pCombinationCount.GetPinnableReference(), out pCombinations.GetPinnableReference());
        }

    }
}

