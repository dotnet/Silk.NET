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
    public static class ArbDrawIndirectOverloads
    {
        public static unsafe void DrawArraysIndirect<T0>(this ArbDrawIndirect thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawArraysIndirect(mode, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawArraysIndirect<T0>(this ArbDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawArraysIndirect(mode, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawElementsIndirect<T0>(this ArbDrawIndirect thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsIndirect(mode, type, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawElementsIndirect<T0>(this ArbDrawIndirect thisApi, [Flow(FlowDirection.In)] ARB mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsIndirect(mode, type, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawElementsIndirect<T0>(this ArbDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] ARB type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsIndirect(mode, type, in indirect.GetPinnableReference());
        }

        public static unsafe void DrawElementsIndirect<T0>(this ArbDrawIndirect thisApi, [Flow(FlowDirection.In)] PrimitiveType mode, [Flow(FlowDirection.In)] DrawElementsType type, [Flow(FlowDirection.In)] ReadOnlySpan<T0> indirect) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsIndirect(mode, type, in indirect.GetPinnableReference());
        }

    }
}

