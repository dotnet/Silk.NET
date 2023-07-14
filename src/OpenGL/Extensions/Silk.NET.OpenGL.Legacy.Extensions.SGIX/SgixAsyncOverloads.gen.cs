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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    public static class SgixAsyncOverloads
    {
        public static unsafe int FinishAsync(this SgixAsync thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> markerp)
        {
            // SpanOverloader
            return thisApi.FinishAsync(out markerp.GetPinnableReference());
        }

        public static unsafe int PollAsync(this SgixAsync thisApi, [Count(Count = 1), Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> markerp)
        {
            // SpanOverloader
            return thisApi.PollAsync(out markerp.GetPinnableReference());
        }

    }
}

