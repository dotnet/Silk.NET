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
        public static unsafe void FramebufferSamplePositions(this AmdFramebufferSamplePositions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.FramebufferSamplePositions(target, numsamples, pixelindex, in values.GetPinnableReference());
        }

        public static unsafe void FramebufferSamplePositions(this AmdFramebufferSamplePositions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.FramebufferSamplePositions(target, numsamples, pixelindex, in values.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void GetFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferTarget target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FramebufferAttachmentParameterName pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetFramebufferParameter(target, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void GetNamedFramebufferParameter(this AmdFramebufferSamplePositions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD pname, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> values)
        {
            // SpanOverloader
            thisApi.GetNamedFramebufferParameter(framebuffer, pname, numsamples, pixelindex, size, out values.GetPinnableReference());
        }

        public static unsafe void NamedFramebufferSamplePositions(this AmdFramebufferSamplePositions thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint numsamples, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint pixelindex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> values)
        {
            // SpanOverloader
            thisApi.NamedFramebufferSamplePositions(framebuffer, numsamples, pixelindex, in values.GetPinnableReference());
        }

    }
}

