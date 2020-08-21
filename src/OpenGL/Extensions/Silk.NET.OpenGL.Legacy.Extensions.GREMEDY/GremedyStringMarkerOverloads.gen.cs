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

namespace Silk.NET.OpenGL.Legacy.Extensions.GREMEDY
{
    public static class GremedyStringMarkerOverloads
    {
        public static unsafe void StringMarker<T0>(this GremedyStringMarker thisApi, [Flow(FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StringMarker(len, in @string.GetPinnableReference());
        }

    }
}

