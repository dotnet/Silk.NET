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

namespace Silk.NET.OpenGL.Extensions.ARB
{
    public static class ArbIndirectParametersOverloads
    {
        public static unsafe void MultiDrawArraysIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirectCount(mode, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawArraysIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirectCount(mode, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectCount(mode, type, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectCount(mode, type, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectCount(mode, type, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

        public static unsafe void MultiDrawElementsIndirectCount<T0>(this ArbIndirectParameters thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(FlowDirection.In)] IntPtr drawcount, [Flow(FlowDirection.In)] uint maxdrawcount, [Flow(FlowDirection.In)] uint stride) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectCount(mode, type, in indirect.GetPinnableReference(), drawcount, maxdrawcount, stride);
        }

    }
}

