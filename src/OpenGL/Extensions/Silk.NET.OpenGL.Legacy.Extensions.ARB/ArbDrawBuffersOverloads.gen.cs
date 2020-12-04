// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    public static class ArbDrawBuffersOverloads
    {
        public static unsafe void DrawBuffers(this ArbDrawBuffers thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<ARB> bufs)
        {
            // SpanOverloader
            thisApi.DrawBuffers(n, in bufs.GetPinnableReference());
        }

        public static unsafe void DrawBuffers(this ArbDrawBuffers thisApi, [Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] ReadOnlySpan<DrawBufferMode> bufs)
        {
            // SpanOverloader
            thisApi.DrawBuffers(n, in bufs.GetPinnableReference());
        }

    }
}

