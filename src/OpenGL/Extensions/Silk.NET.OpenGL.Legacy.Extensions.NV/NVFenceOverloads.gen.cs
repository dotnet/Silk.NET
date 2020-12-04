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
    public static class NVFenceOverloads
    {
        public static unsafe void DeleteFences(this NVFence thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<uint> fences)
        {
            // SpanOverloader
            thisApi.DeleteFences(n, in fences.GetPinnableReference());
        }

        public static unsafe void GenFences(this NVFence thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> fences)
        {
            // SpanOverloader
            thisApi.GenFences(n, out fences.GetPinnableReference());
        }

        public static unsafe void GetFence(this NVFence thisApi, [Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFence(fence, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFence(this NVFence thisApi, [Flow(FlowDirection.In)] uint fence, [Flow(FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFence(fence, pname, out @params.GetPinnableReference());
        }

    }
}

