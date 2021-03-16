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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    public static class AmdFramebufferSamplePositionsOverloads
    {
        public static unsafe void FramebufferSamplePositions(this AmdFramebufferSamplePositions thisApi, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.FramebufferSamplePositions(target, numsamples, pixelindex, in values.GetPinnableReference());
        }

        public static unsafe void FramebufferSamplePositions(this AmdFramebufferSamplePositions thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.FramebufferSamplePositions(target, numsamples, pixelindex, in values.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(FlowDirection.In)] AMD target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] AMD pname, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferParameter(framebuffer, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void NamedFramebufferSamplePositions(this AmdFramebufferSamplePositions thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint numsamples, [Flow(FlowDirection.In)] uint pixelindex, [Flow(FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.NamedFramebufferSamplePositions(framebuffer, numsamples, pixelindex, in values.GetPinnableReference());
        }

    }
}

