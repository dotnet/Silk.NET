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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixListPriorityOverloads
    {
        public static unsafe void GetListParameter(this SgixListPriority thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetListParameter(list, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetListParameter(this SgixListPriority thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> @params)
        {
            // SpanOverloader
            thisApi.GetListParameter(list, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetListParameter(this SgixListPriority thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetListParameter(list, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetListParameter(this SgixListPriority thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetListParameter(list, pname, out @params.GetPinnableReference());
        }

        public static unsafe void ListParameter(this SgixListPriority thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ListParameter(list, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ListParameter(this SgixListPriority thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> @params)
        {
            // SpanOverloader
            thisApi.ListParameter(list, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ListParameter(this SgixListPriority thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ListParameter(list, pname, in @params.GetPinnableReference());
        }

        public static unsafe void ListParameter(this SgixListPriority thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ListParameterName pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> @params)
        {
            // SpanOverloader
            thisApi.ListParameter(list, pname, in @params.GetPinnableReference());
        }

    }
}

