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

namespace Silk.NET.WGL.Extensions.I3D
{
    public static class I3DDigitalVideoControlOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 GetDigitalVideoParametersI3D(this I3DDigitalVideoControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piValue)
        {
            // SpanOverloader
            return thisApi.GetDigitalVideoParametersI3D(hDC, iAttribute, out piValue.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 SetDigitalVideoParametersI3D(this I3DDigitalVideoControl thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> piValue)
        {
            // SpanOverloader
            return thisApi.SetDigitalVideoParametersI3D(hDC, iAttribute, in piValue.GetPinnableReference());
        }

    }
}

