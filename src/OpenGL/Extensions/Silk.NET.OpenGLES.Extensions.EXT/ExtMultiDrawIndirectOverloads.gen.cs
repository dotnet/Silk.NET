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
    public static class ExtMultiDrawIndirectOverloads
    {
        public static unsafe void MultiDrawArraysIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawArraysIndirect(mode, indirectSpp, drawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] EXT mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawElementsIndirect(mode, type, indirectSpp, drawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawElementsIndirect(mode, type, indirectSpp, drawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this ExtMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "drawcount, stride"), Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint drawcount, [Flow(FlowDirection.In)] uint stride) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawElementsIndirect(mode, type, indirectSpp, drawcount, stride);
        }

    }
}

