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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    public static class ExtDebugMarkerOverloads
    {
        public static unsafe void InsertEventMarker(this ExtDebugMarker thisApi, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] ReadOnlySpan<byte> marker)
        {
            // SpanOverloader
            thisApi.InsertEventMarker(length, in marker.GetPinnableReference());
        }

        public static unsafe void PushGroupMarker(this ExtDebugMarker thisApi, [Flow(FlowDirection.In)] uint length, [Flow(FlowDirection.In)] ReadOnlySpan<byte> marker)
        {
            // SpanOverloader
            thisApi.PushGroupMarker(length, in marker.GetPinnableReference());
        }

    }
}

