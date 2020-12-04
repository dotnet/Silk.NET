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
    public static class ArbTimerQueryOverloads
    {
        public static unsafe void GetQueryObject(this ArbTimerQuery thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetQueryObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQueryObject(this ArbTimerQuery thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<long> @params)
        {
            // SpanOverloader
            thisApi.GetQueryObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQueryObject(this ArbTimerQuery thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ARB pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetQueryObject(id, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetQueryObject(this ArbTimerQuery thisApi, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] QueryObjectParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<ulong> @params)
        {
            // SpanOverloader
            thisApi.GetQueryObject(id, pname, out @params.GetPinnableReference());
        }

    }
}

