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
    public static class NVVertexAttribInteger64bitOverloads
    {
        public static unsafe void GetVertexAttribL(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribL(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribL(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetVertexAttribL(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] VertexAttribEnum pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetVertexAttribL(index, pname, out @params.GetPinnableReference());
        }

        public static unsafe void VertexAttribL1(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<long> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL1(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 1), Flow(FlowDirection.In)] ReadOnlySpan<ulong> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL1(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL2(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<long> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL2(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 2), Flow(FlowDirection.In)] ReadOnlySpan<ulong> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL2(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL3(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<long> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL3(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 3), Flow(FlowDirection.In)] ReadOnlySpan<ulong> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL3(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL4(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<long> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL4(index, in v.GetPinnableReference());
        }

        public static unsafe void VertexAttribL4(this NVVertexAttribInteger64bit thisApi, [Flow(FlowDirection.In)] uint index, [Count(Count = 4), Flow(FlowDirection.In)] ReadOnlySpan<ulong> v)
        {
            // SpanOverloader
            thisApi.VertexAttribL4(index, in v.GetPinnableReference());
        }

    }
}

