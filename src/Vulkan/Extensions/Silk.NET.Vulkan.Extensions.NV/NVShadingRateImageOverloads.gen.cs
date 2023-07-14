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
    public static class NVShadingRateImageOverloads
    {
        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetCoarseSampleOrder(this NVShadingRateImage thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoarseSampleOrderTypeNV sampleOrderType, [Count(Count = 0)] uint customSampleOrderCount, [Count(Parameter = "customSampleOrderCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<CoarseSampleOrderCustomNV> pCustomSampleOrders)
        {
            // SpanOverloader
            thisApi.CmdSetCoarseSampleOrder(commandBuffer, sampleOrderType, customSampleOrderCount, in pCustomSampleOrders.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        public static unsafe void CmdSetViewportShadingRatePalette(this NVShadingRateImage thisApi, [Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Parameter = "viewportCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ShadingRatePaletteNV> pShadingRatePalettes)
        {
            // SpanOverloader
            thisApi.CmdSetViewportShadingRatePalette(commandBuffer, firstViewport, viewportCount, in pShadingRatePalettes.GetPinnableReference());
        }

    }
}

