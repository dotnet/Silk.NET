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

namespace Silk.NET.WGL.Extensions.ARB
{
    public static class ArbPbufferOverloads
    {
        public static unsafe nint CreatePbuffer(this ArbPbuffer thisApi, [Flow(FlowDirection.In)] nint hDC, [Flow(FlowDirection.In)] int iPixelFormat, [Flow(FlowDirection.In)] int iWidth, [Flow(FlowDirection.In)] int iHeight, [Flow(FlowDirection.In)] ReadOnlySpan<int> piAttribList)
        {
            // SpanOverloader
            return thisApi.CreatePbuffer(hDC, iPixelFormat, iWidth, iHeight, in piAttribList.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryPbuffer(this ArbPbuffer thisApi, [Flow(FlowDirection.In)] nint hPbuffer, [Flow(FlowDirection.In)] int iAttribute, [Flow(FlowDirection.Out)] Span<int> piValue)
        {
            // SpanOverloader
            return thisApi.QueryPbuffer(hPbuffer, iAttribute, out piValue.GetPinnableReference());
        }

    }
}

