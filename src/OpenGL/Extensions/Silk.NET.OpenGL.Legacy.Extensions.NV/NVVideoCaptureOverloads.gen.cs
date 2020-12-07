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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVVideoCaptureOverloads
    {
        public static unsafe void GetVideoCapture(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVideoCapture(video_capture_slot, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVideoCaptureStream(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVideoCaptureStream(video_capture_slot, stream, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVideoCaptureStream(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetVideoCaptureStream(video_capture_slot, stream, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVideoCaptureStream(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<double> @params)
        {
            // SpanOverloader
            thisApi.GetVideoCaptureStream(video_capture_slot, stream, pname, out @params.GetPinnableReference());
        }

        public static unsafe NV VideoCapture(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] uint* sequence_num, [Flow(FlowDirection.Out)] Span<ulong> capture_time)
        {
            // SpanOverloader
            return thisApi.VideoCapture(video_capture_slot, sequence_num, out capture_time.GetPinnableReference());
        }

        public static unsafe NV VideoCapture(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] Span<uint> sequence_num, [Flow(FlowDirection.Out)] ulong* capture_time)
        {
            // SpanOverloader
            return thisApi.VideoCapture(video_capture_slot, out sequence_num.GetPinnableReference(), capture_time);
        }

        public static unsafe NV VideoCapture(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] Span<uint> sequence_num, [Flow(FlowDirection.Out)] Span<ulong> capture_time)
        {
            // SpanOverloader
            return thisApi.VideoCapture(video_capture_slot, out sequence_num.GetPinnableReference(), out capture_time.GetPinnableReference());
        }

        public static unsafe void VideoCaptureStreamParameter(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.VideoCaptureStreamParameter(video_capture_slot, stream, pname, in @params.GetPinnableReference());
        }

        public static unsafe void VideoCaptureStreamParameter(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.VideoCaptureStreamParameter(video_capture_slot, stream, pname, in @params.GetPinnableReference());
        }

        public static unsafe void VideoCaptureStreamParameter(this NVVideoCapture thisApi, [Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<double> @params)
        {
            // SpanOverloader
            thisApi.VideoCaptureStreamParameter(video_capture_slot, stream, pname, in @params.GetPinnableReference());
        }

    }
}

