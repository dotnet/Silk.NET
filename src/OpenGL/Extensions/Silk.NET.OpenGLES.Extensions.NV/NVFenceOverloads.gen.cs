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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    public static class NVFenceOverloads
    {
        public static unsafe void DeleteFences(this NVFence thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> fences)
        {
            // SpanOverloader
            thisApi.DeleteFences(n, in fences.GetPinnableReference());
        }

        public static unsafe void GenFences(this NVFence thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> fences)
        {
            // SpanOverloader
            thisApi.GenFences(n, out fences.GetPinnableReference());
        }

        public static unsafe void GetFence(this NVFence thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFence(fence, pname, out @params.GetPinnableReference());
        }

        public static unsafe void GetFence(this NVFence thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint fence, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FenceParameterNameNV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> @params)
        {
            // SpanOverloader
            thisApi.GetFence(fence, pname, out @params.GetPinnableReference());
        }

    }
}

