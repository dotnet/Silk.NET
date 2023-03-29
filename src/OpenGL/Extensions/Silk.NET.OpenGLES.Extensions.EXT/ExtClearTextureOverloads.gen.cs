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
    public static class ExtClearTextureOverloads
    {
        public static unsafe void ClearTexImage<T0>(this ExtClearTexture thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearTexImage(texture, level, format, type, dataSpp);
        }

        public static unsafe void ClearTexImage<T0>(this ExtClearTexture thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearTexImage(texture, level, format, type, dataSpp);
        }

        public static unsafe void ClearTexImage<T0>(this ExtClearTexture thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearTexImage(texture, level, format, type, dataSpp);
        }

        public static unsafe void ClearTexSubImage<T0>(this ExtClearTexture thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] EXT format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, dataSpp);
        }

        public static unsafe void ClearTexSubImage<T0>(this ExtClearTexture thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] EXT type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, dataSpp);
        }

        public static unsafe void ClearTexSubImage<T0>(this ExtClearTexture thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type"), Flow(FlowDirection.In)] Span<T0> data) where T0 : struct
        {
            // SpanOverloader
            fixed (void* dataSpp = data)
                thisApi.ClearTexSubImage(texture, level, xoffset, yoffset, zoffset, width, height, depth, format, type, dataSpp);
        }

    }
}

