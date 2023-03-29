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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    public static class AmdMultiDrawIndirectOverloads
    {
        public static unsafe void MultiDrawArraysIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Count(Computed = "primcount, stride"), Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawArraysIndirect(mode, indirectSpp, primcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount, stride"), Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawElementsIndirect(mode, type, indirectSpp, primcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] AMD type, [Count(Computed = "primcount, stride"), Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawElementsIndirect(mode, type, indirectSpp, primcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Count(Computed = "primcount, stride"), Flow(FlowDirection.In)] Span<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : struct
        {
            // SpanOverloader
            fixed (void* indirectSpp = indirect)
                thisApi.MultiDrawElementsIndirect(mode, type, indirectSpp, primcount, stride);
        }

    }
}

