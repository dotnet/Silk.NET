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
    public static class NVPresentVideoOverloads
    {
        public static unsafe void GetVideo(this NVPresentVideo thisApi, [Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVideo(video_slot, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVideo(this NVPresentVideo thisApi, [Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetVideo(video_slot, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVideo(this NVPresentVideo thisApi, [Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetVideo(video_slot, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVideo(this NVPresentVideo thisApi, [Flow(FlowDirection.In)] uint video_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetVideo(video_slot, pname, out @params.GetPinnableReference());
        }

    }
}

