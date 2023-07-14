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

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    public static class NVPresentVideoOverloads
    {
        public static unsafe void GetVideo(this NVPresentVideo thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetVideo(video_slot, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVideo(this NVPresentVideo thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetVideo(video_slot, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVideo(this NVPresentVideo thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetVideo(video_slot, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVideo(this NVPresentVideo thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetVideo(video_slot, pname, out @params.GetPinnableReference());
        }

    }
}

