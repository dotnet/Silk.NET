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
    public static class ArbRenderTextureOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 SetPbufferAttrib(this ArbRenderTexture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piAttribList)
        {
            // SpanOverloader
            return thisApi.SetPbufferAttrib(hPbuffer, in piAttribList.GetPinnableReference());
        }

    }
}

