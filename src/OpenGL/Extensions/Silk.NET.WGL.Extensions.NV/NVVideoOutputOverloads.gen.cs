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

namespace Silk.NET.WGL.Extensions.NV
{
    public static class NVVideoOutputOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 GetVideoDevice(this NVVideoOutput thisApi, [Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] int numDevices, [Flow(FlowDirection.Out)] Span<nint> hVideoDevice)
        {
            // SpanOverloader
            return thisApi.GetVideoDevice(hDC, numDevices, out hVideoDevice.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetVideoInfo(this NVVideoOutput thisApi, [Flow(FlowDirection.In)] nint hpVideoDevice, [Flow(FlowDirection.Out)] uint* pulCounterOutputPbuffer, [Flow(FlowDirection.Out)] Span<uint> pulCounterOutputVideo)
        {
            // SpanOverloader
            return thisApi.GetVideoInfo(hpVideoDevice, pulCounterOutputPbuffer, out pulCounterOutputVideo.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 GetVideoInfo(this NVVideoOutput thisApi, [Flow(FlowDirection.In)] nint hpVideoDevice, [Flow(FlowDirection.Out)] Span<uint> pulCounterOutputPbuffer, [Flow(FlowDirection.Out)] uint* pulCounterOutputVideo)
        {
            // SpanOverloader
            return thisApi.GetVideoInfo(hpVideoDevice, out pulCounterOutputPbuffer.GetPinnableReference(), pulCounterOutputVideo);
        }

        public static unsafe Silk.NET.Core.Bool32 GetVideoInfo(this NVVideoOutput thisApi, [Flow(FlowDirection.In)] nint hpVideoDevice, [Flow(FlowDirection.Out)] Span<uint> pulCounterOutputPbuffer, [Flow(FlowDirection.Out)] Span<uint> pulCounterOutputVideo)
        {
            // SpanOverloader
            return thisApi.GetVideoInfo(hpVideoDevice, out pulCounterOutputPbuffer.GetPinnableReference(), out pulCounterOutputVideo.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 SendPbufferToVideo(this NVVideoOutput thisApi, [Flow(FlowDirection.In)] nint hPbuffer, [Flow(FlowDirection.In)] int iBufferType, [Flow(FlowDirection.Out)] Span<uint> pulCounterPbuffer, [Flow(FlowDirection.In)] Silk.NET.Core.Bool32 bBlock)
        {
            // SpanOverloader
            return thisApi.SendPbufferToVideo(hPbuffer, iBufferType, out pulCounterPbuffer.GetPinnableReference(), bBlock);
        }

    }
}

