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
    public static class ExtDebugMarkerOverloads
    {
        public static unsafe void InsertEventMarker(this ExtDebugMarker thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> marker)
        {
            // SpanOverloader
            thisApi.InsertEventMarker(length, in marker.GetPinnableReference());
        }

        public static unsafe void PushGroupMarker(this ExtDebugMarker thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<byte> marker)
        {
            // SpanOverloader
            thisApi.PushGroupMarker(length, in marker.GetPinnableReference());
        }

    }
}

