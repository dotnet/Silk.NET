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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbSampleLocationsOverloads
    {
        public static unsafe void FramebufferSampleLocations(this ArbSampleLocations thisApi, [Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.FramebufferSampleLocations(target, start, count, in v.GetPinnableReference());
        }

        public static unsafe void FramebufferSampleLocations(this ArbSampleLocations thisApi, [Flow(FlowDirection.In)] FramebufferTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.FramebufferSampleLocations(target, start, count, in v.GetPinnableReference());
        }

        public static unsafe void NamedFramebufferSampleLocations(this ArbSampleLocations thisApi, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.NamedFramebufferSampleLocations(framebuffer, start, count, in v.GetPinnableReference());
        }

    }
}

