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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    public static class ExtColorSubtableOverloads
    {
        public static unsafe void ColorSubTable<T0>(this ExtColorSubtable thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ExtColorSubtable thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ExtColorSubtable thisApi, [Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ExtColorSubtable thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ExtColorSubtable thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ExtColorSubtable thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

        public static unsafe void ColorSubTable<T0>(this ExtColorSubtable thisApi, [Flow(FlowDirection.In)] ColorTableTarget target, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, count"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ColorSubTable(target, start, count, format, type, dataSpp);
        }

    }
}

