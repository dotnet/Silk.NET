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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtFragmentShadingRateOverloads
    {
        public static unsafe void GetFragmentShadingRates(this ExtFragmentShadingRate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> shadingRates)
        {
            // SpanOverloader
            thisApi.GetFragmentShadingRates(samples, maxCount, count, out shadingRates.GetPinnableReference());
        }

        public static unsafe void GetFragmentShadingRates(this ExtFragmentShadingRate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] EXT* shadingRates)
        {
            // SpanOverloader
            thisApi.GetFragmentShadingRates(samples, maxCount, out count.GetPinnableReference(), shadingRates);
        }

        public static unsafe void GetFragmentShadingRates(this ExtFragmentShadingRate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<EXT> shadingRates)
        {
            // SpanOverloader
            thisApi.GetFragmentShadingRates(samples, maxCount, out count.GetPinnableReference(), out shadingRates.GetPinnableReference());
        }

        public static unsafe void GetFragmentShadingRates(this ExtFragmentShadingRate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShadingRate> shadingRates)
        {
            // SpanOverloader
            thisApi.GetFragmentShadingRates(samples, maxCount, count, out shadingRates.GetPinnableReference());
        }

        public static unsafe void GetFragmentShadingRates(this ExtFragmentShadingRate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] ShadingRate* shadingRates)
        {
            // SpanOverloader
            thisApi.GetFragmentShadingRates(samples, maxCount, out count.GetPinnableReference(), shadingRates);
        }

        public static unsafe void GetFragmentShadingRates(this ExtFragmentShadingRate thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint samples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> count, [Count(Parameter = "maxCount"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ShadingRate> shadingRates)
        {
            // SpanOverloader
            thisApi.GetFragmentShadingRates(samples, maxCount, out count.GetPinnableReference(), out shadingRates.GetPinnableReference());
        }

    }
}

