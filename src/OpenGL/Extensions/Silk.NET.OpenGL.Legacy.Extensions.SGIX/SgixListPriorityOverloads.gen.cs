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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixListPriorityOverloads
    {
        public static unsafe void GetListParameter(this SgixListPriority thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetListParameter(list, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetListParameter(this SgixListPriority thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetListParameter(list, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetListParameter(this SgixListPriority thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetListParameter(list, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetListParameter(this SgixListPriority thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetListParameter(list, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ListParameter(this SgixListPriority thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ListParameter(list, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ListParameter(this SgixListPriority thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ListParameter(list, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ListParameter(this SgixListPriority thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ListParameter(list, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ListParameter(this SgixListPriority thisApi, [Flow(FlowDirection.In)] uint list, [Flow(FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ListParameter(list, pname, in @params.GetPinnableReference());
        }

    }
}

