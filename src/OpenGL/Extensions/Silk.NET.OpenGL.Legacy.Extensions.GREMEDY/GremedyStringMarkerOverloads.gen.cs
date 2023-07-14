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

namespace Silk.NET.OpenGL.Legacy.Extensions.GREMEDY
{
    public static class GremedyStringMarkerOverloads
    {
        public static unsafe void StringMarker<T0>(this GremedyStringMarker thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint len, [Count(Parameter = "len"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<T0> @string) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.StringMarker(len, in @string.GetPinnableReference());
        }

    }
}

