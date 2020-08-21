// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVShadingRateImageOverloads
    {
        public static unsafe void GetShadingRateImagePalette(this NVShadingRateImage thisApi, [Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint entry, [Count(Count = 1), Flow(FlowDirection.Out)] Span<NV> rate)
        {
            // SpanOverloader
            thisApi.GetShadingRateImagePalette(viewport, entry, out rate.GetPinnableReference());
        }

        public static unsafe void GetShadingRateSampleLocation(this NVShadingRateImage thisApi, [Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.Out)] Span<int> location)
        {
            // SpanOverloader
            thisApi.GetShadingRateSampleLocation(rate, samples, index, out location.GetPinnableReference());
        }

        public static unsafe void ShadingRateImagePalette(this NVShadingRateImage thisApi, [Flow(FlowDirection.In)] uint viewport, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(FlowDirection.In)] ReadOnlySpan<NV> rates)
        {
            // SpanOverloader
            thisApi.ShadingRateImagePalette(viewport, first, count, in rates.GetPinnableReference());
        }

        public static unsafe void ShadingRateSampleOrderCustom(this NVShadingRateImage thisApi, [Flow(FlowDirection.In)] NV rate, [Flow(FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(FlowDirection.In)] ReadOnlySpan<int> locations)
        {
            // SpanOverloader
            thisApi.ShadingRateSampleOrderCustom(rate, samples, in locations.GetPinnableReference());
        }

    }
}

