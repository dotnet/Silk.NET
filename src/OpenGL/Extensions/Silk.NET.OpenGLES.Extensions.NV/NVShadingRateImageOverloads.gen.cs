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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    public static class NVShadingRateImageOverloads
    {
        public static unsafe void GetShadingRateImagePalette(this NVShadingRateImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint viewport, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint entry, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<NV> rate)
        {
            // SpanOverloader
            thisApi.GetShadingRateImagePalette(viewport, entry, out rate.GetPinnableReference());
        }

        public static unsafe void GetShadingRateSampleLocation(this NVShadingRateImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV rate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 3), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> location)
        {
            // SpanOverloader
            thisApi.GetShadingRateSampleLocation(rate, samples, index, out location.GetPinnableReference());
        }

        public static unsafe void ShadingRateImagePalette(this NVShadingRateImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint viewport, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<NV> rates)
        {
            // SpanOverloader
            thisApi.ShadingRateImagePalette(viewport, first, count, in rates.GetPinnableReference());
        }

        public static unsafe void ShadingRateSampleOrderCustom(this NVShadingRateImage thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV rate, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Count(Computed = "rate, samples"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> locations)
        {
            // SpanOverloader
            thisApi.ShadingRateSampleOrderCustom(rate, samples, in locations.GetPinnableReference());
        }

    }
}

