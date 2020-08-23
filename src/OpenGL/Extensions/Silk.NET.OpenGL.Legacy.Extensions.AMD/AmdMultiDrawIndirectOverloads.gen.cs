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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    public static class AmdMultiDrawIndirectOverloads
    {
        public static unsafe void MultiDrawArraysIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirect(mode, in indirect.GetPinnableReference(), primcount, stride);
        }

        public static unsafe void MultiDrawArraysIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirect(mode, in indirect.GetPinnableReference(), primcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] AMD type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirect(mode, type, in indirect.GetPinnableReference(), primcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] AMD mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirect(mode, type, in indirect.GetPinnableReference(), primcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] AMD type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirect(mode, type, in indirect.GetPinnableReference(), primcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirect<T0>(this AmdMultiDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] uint primcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirect(mode, type, in indirect.GetPinnableReference(), primcount, stride);
        }

    }
}

