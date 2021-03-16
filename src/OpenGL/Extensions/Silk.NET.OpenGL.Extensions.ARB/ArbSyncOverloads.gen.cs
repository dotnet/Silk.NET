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
    public static class ArbSyncOverloads
    {
        public static unsafe void GetInteger64(this ArbSync thisApi, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> data)
        {
            // SpanOverloader
            thisApi.GetInteger64(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger64(this ArbSync thisApi, [Flow(FlowDirection.In)] GetPName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> data)
        {
            // SpanOverloader
            thisApi.GetInteger64(pname, out data.GetPinnableReference());
        }

        public static unsafe void GetSync(this ArbSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, length, out values.GetPinnableReference());
        }

        public static unsafe void GetSync(this ArbSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), values);
        }

        public static unsafe void GetSync(this ArbSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] ARB pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), out values.GetPinnableReference());
        }

        public static unsafe void GetSync(this ArbSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] uint* length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, length, out values.GetPinnableReference());
        }

        public static unsafe void GetSync(this ArbSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] int* values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), values);
        }

        public static unsafe void GetSync(this ArbSync thisApi, [Flow(FlowDirection.In)] nint sync, [Flow(FlowDirection.In)] SyncParameterName pname, [Flow(FlowDirection.In)] uint count, [Count(Count = 1), Flow(FlowDirection.Out)] Span<uint> length, [Count(Parameter = "count"), Flow(FlowDirection.Out)] Span<int> values)
        {
            // SpanOverloader
            thisApi.GetSync(sync, pname, count, out length.GetPinnableReference(), out values.GetPinnableReference());
        }

    }
}

