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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbViewportArrayOverloads
    {
        public static unsafe void DepthRangeArray(this ArbViewportArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<double> v)
        {
            // SpanOverloader
            thisApi.DepthRangeArray(first, count, in v.GetPinnableReference());
        }

        public static unsafe void GetDouble(this ArbViewportArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> data)
        {
            // SpanOverloader
            thisApi.GetDouble(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetDouble(this ArbViewportArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<double> data)
        {
            // SpanOverloader
            thisApi.GetDouble(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetFloat(this ArbViewportArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloat(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetFloat(this ArbViewportArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<float> data)
        {
            // SpanOverloader
            thisApi.GetFloat(target, index, out data.GetPinnableReference());
        }

        public static unsafe void ScissorArray(this ArbViewportArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.ScissorArray(first, count, in v.GetPinnableReference());
        }

        public static unsafe void ScissorIndexed(this ArbViewportArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> v)
        {
            // SpanOverloader
            thisApi.ScissorIndexed(index, in v.GetPinnableReference());
        }

        public static unsafe void ViewportArray(this ArbViewportArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ViewportArray(first, count, in v.GetPinnableReference());
        }

        public static unsafe void ViewportIndexed(this ArbViewportArray thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<float> v)
        {
            // SpanOverloader
            thisApi.ViewportIndexed(index, in v.GetPinnableReference());
        }

    }
}

