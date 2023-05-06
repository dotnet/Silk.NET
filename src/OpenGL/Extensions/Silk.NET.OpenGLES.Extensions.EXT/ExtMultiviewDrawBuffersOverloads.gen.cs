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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtMultiviewDrawBuffersOverloads
    {
        public static unsafe void DrawBuffersIndexed(this ExtMultiviewDrawBuffers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT* location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> indices)
        {
            // SpanOverloader
            thisApi.DrawBuffersIndexed(n, location, in indices.GetPinnableReference());
        }

        public static unsafe void DrawBuffersIndexed(this ExtMultiviewDrawBuffers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* indices)
        {
            // SpanOverloader
            thisApi.DrawBuffersIndexed(n, in location.GetPinnableReference(), indices);
        }

        public static unsafe void DrawBuffersIndexed(this ExtMultiviewDrawBuffers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<EXT> location, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> indices)
        {
            // SpanOverloader
            thisApi.DrawBuffersIndexed(n, in location.GetPinnableReference(), in indices.GetPinnableReference());
        }

        public static unsafe void GetInteger(this ExtMultiviewDrawBuffers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(target, index, out data.GetPinnableReference());
        }

        public static unsafe void GetInteger(this ExtMultiviewDrawBuffers thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> data)
        {
            // SpanOverloader
            thisApi.GetInteger(target, index, out data.GetPinnableReference());
        }

    }
}

