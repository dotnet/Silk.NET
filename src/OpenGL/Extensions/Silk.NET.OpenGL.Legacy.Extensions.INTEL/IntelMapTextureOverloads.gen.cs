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

namespace Silk.NET.OpenGL.Legacy.Extensions.INTEL
{
    public static class IntelMapTextureOverloads
    {
        public static unsafe void* MapTexture2D(this IntelMapTexture thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint access, [Count(Count = 1), Flow(FlowDirection.Out)] int* stride, [Count(Count = 1), Flow(FlowDirection.Out)] Span<INTEL> layout)
        {
            // SpanOverloader
            return thisApi.MapTexture2D(texture, level, access, stride, out layout.GetPinnableReference());
        }

        public static unsafe void* MapTexture2D(this IntelMapTexture thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint access, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> stride, [Count(Count = 1), Flow(FlowDirection.Out)] INTEL* layout)
        {
            // SpanOverloader
            return thisApi.MapTexture2D(texture, level, access, out stride.GetPinnableReference(), layout);
        }

        public static unsafe void* MapTexture2D(this IntelMapTexture thisApi, [Flow(FlowDirection.In)] uint texture, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] uint access, [Count(Count = 1), Flow(FlowDirection.Out)] Span<int> stride, [Count(Count = 1), Flow(FlowDirection.Out)] Span<INTEL> layout)
        {
            // SpanOverloader
            return thisApi.MapTexture2D(texture, level, access, out stride.GetPinnableReference(), out layout.GetPinnableReference());
        }

    }
}

