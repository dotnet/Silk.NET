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
    public static class IntelMapTextureOverloads
    {
        public static unsafe void* MapTexture2D(this IntelMapTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* stride, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<INTEL> layout)
        {
            // SpanOverloader
            return thisApi.MapTexture2D(texture, level, access, stride, out layout.GetPinnableReference());
        }

        public static unsafe void* MapTexture2D(this IntelMapTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stride, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] INTEL* layout)
        {
            // SpanOverloader
            return thisApi.MapTexture2D(texture, level, access, out stride.GetPinnableReference(), layout);
        }

        public static unsafe void* MapTexture2D(this IntelMapTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int level, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint access, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> stride, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<INTEL> layout)
        {
            // SpanOverloader
            return thisApi.MapTexture2D(texture, level, access, out stride.GetPinnableReference(), out layout.GetPinnableReference());
        }

    }
}

