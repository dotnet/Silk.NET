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
    public static class ExtBaseInstanceOverloads
    {
        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT type, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

        public static unsafe void DrawElementsInstancedBaseVertexBaseInstance<T0>(this ExtBaseInstance thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] PrimitiveType mode, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawElementsType type, [Count(Parameter = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> indices, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint instancecount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int basevertex, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint baseinstance) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.DrawElementsInstancedBaseVertexBaseInstance(mode, count, type, in indices.GetPinnableReference(), instancecount, basevertex, baseinstance);
        }

    }
}

