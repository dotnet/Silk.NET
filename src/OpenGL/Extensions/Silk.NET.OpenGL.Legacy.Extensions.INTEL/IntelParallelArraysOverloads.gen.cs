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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    public static class IntelParallelArraysOverloads
    {
        public static unsafe void ColorPointer(this IntelParallelArrays thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer)
        {
            // SpanOverloader
            thisApi.ColorPointer(size, type, in pointer.GetPinnableReference());
        }

        public static unsafe void ColorPointer(this IntelParallelArrays thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer)
        {
            // SpanOverloader
            thisApi.ColorPointer(size, type, in pointer.GetPinnableReference());
        }

        public static unsafe void NormalPointer(this IntelParallelArrays thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer)
        {
            // SpanOverloader
            thisApi.NormalPointer(type, in pointer.GetPinnableReference());
        }

        public static unsafe void NormalPointer(this IntelParallelArrays thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer)
        {
            // SpanOverloader
            thisApi.NormalPointer(type, in pointer.GetPinnableReference());
        }

        public static unsafe void TexCoordPointer(this IntelParallelArrays thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer)
        {
            // SpanOverloader
            thisApi.TexCoordPointer(size, type, in pointer.GetPinnableReference());
        }

        public static unsafe void TexCoordPointer(this IntelParallelArrays thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer)
        {
            // SpanOverloader
            thisApi.TexCoordPointer(size, type, in pointer.GetPinnableReference());
        }

        public static unsafe void VertexPointer(this IntelParallelArrays thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] INTEL type, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer)
        {
            // SpanOverloader
            thisApi.VertexPointer(size, type, in pointer.GetPinnableReference());
        }

        public static unsafe void VertexPointer(this IntelParallelArrays thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Count(Count = 4), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer)
        {
            // SpanOverloader
            thisApi.VertexPointer(size, type, in pointer.GetPinnableReference());
        }

    }
}

