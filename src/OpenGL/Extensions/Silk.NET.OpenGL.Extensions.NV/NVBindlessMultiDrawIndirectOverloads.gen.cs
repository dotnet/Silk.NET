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

namespace Silk.NET.OpenGL.Extensions.NV
{
    public static class NVBindlessMultiDrawIndirectOverloads
    {
        public static unsafe void MultiDrawArraysIndirectBindles<T0>(this NVBindlessMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirectBindles(mode, in indirect.GetPinnableReference(), drawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawArraysIndirectBindles<T0>(this NVBindlessMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawArraysIndirectBindles(mode, in indirect.GetPinnableReference(), drawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindles<T0>(this NVBindlessMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectBindles(mode, type, in indirect.GetPinnableReference(), drawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindles<T0>(this NVBindlessMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectBindles(mode, type, in indirect.GetPinnableReference(), drawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindles<T0>(this NVBindlessMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectBindles(mode, type, in indirect.GetPinnableReference(), drawCount, stride, vertexBufferCount);
        }

        public static unsafe void MultiDrawElementsIndirectBindles<T0>(this NVBindlessMultiDrawIndirect thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indirect, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint drawCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stride, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int vertexBufferCount) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.MultiDrawElementsIndirectBindles(mode, type, in indirect.GetPinnableReference(), drawCount, stride, vertexBufferCount);
        }

    }
}

