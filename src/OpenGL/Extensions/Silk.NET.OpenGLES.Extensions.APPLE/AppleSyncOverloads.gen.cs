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

namespace Silk.NET.OpenGLES.Extensions.APPLE
{
    public static class AppleSyncOverloads
    {
        public static unsafe void GetInteger64(this AppleSync thisApi, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInteger64(pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetInteger64(this AppleSync thisApi, [Flow(FlowDirection.In)] GetPName pname, [Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetInteger64(pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetSync(this AppleSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, length, out values.GetPinnableReference());
        }

        public static unsafe void GetSync(this AppleSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), values);
        }

        public static unsafe void GetSync(this AppleSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] APPLE pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe void GetSync(this AppleSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, length, out values.GetPinnableReference());
        }

        public static unsafe void GetSync(this AppleSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), values);
        }

        public static unsafe void GetSync(this AppleSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), out values.GetPinnableReference());
        }

    }
}

