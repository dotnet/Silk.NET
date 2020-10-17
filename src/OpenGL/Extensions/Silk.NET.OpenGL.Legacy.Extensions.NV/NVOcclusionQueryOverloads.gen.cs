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
    public static class NVOcclusionQueryOverloads
    {
        public static unsafe void DeleteOcclusionQueries(this NVOcclusionQuery thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> ids)
        {
            // SpanOverloader
            thisApi.DeleteOcclusionQueries(n, in ids.GetPinnableReference());
        }

        public static unsafe void GenOcclusionQueries(this NVOcclusionQuery thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            thisApi.GenOcclusionQueries(n, out ids.GetPinnableReference());
        }

        public static unsafe void GetOcclusionQuery(this NVOcclusionQuery thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetOcclusionQuery(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetOcclusionQuery(this NVOcclusionQuery thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetOcclusionQuery(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetOcclusionQuery(this NVOcclusionQuery thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetOcclusionQuery(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetOcclusionQuery(this NVOcclusionQuery thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] OcclusionQueryParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<uint> @params)
        {
            // SpanOverloader
            thisApi.GetOcclusionQuery(id, pname, out @params.GetPinnableReference());
        }

    }
}

