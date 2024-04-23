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

namespace Silk.NET.OpenGL.Legacy.Extensions.IBM
{
    public static class IbmVertexArrayListsOverloads
    {
        public static unsafe void ColorPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.ColorPointerList(size, type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void ColorPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ColorPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.ColorPointerList(size, type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void EdgeFlagPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.EdgeFlagPointerList(stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void FogCoordPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.FogCoordPointerList(type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void FogCoordPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] FogPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.FogCoordPointerList(type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void IndexPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.IndexPointerList(type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void IndexPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IndexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.IndexPointerList(type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void NormalPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.NormalPointerList(type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void NormalPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NormalPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.NormalPointerList(type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void SecondaryColorPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.SecondaryColorPointerList(size, type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void SecondaryColorPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SecondaryColorPointerTypeIBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.SecondaryColorPointerList(size, type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void TexCoordPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.TexCoordPointerList(size, type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void TexCoordPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] TexCoordPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.TexCoordPointerList(size, type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void VertexPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] IBM type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.VertexPointerList(size, type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

        public static unsafe void VertexPointerList(this IbmVertexArrayLists thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexPointerType type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int stride, [Count(Computed = "size, type, stride"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pointer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int ptrstride)
        {
            // SpanOverloader
            thisApi.VertexPointerList(size, type, stride, in pointer.GetPinnableReference(), ptrstride);
        }

    }
}

