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
    public static class ArbCreateContextOverloads
    {
        public static unsafe nint CreateContextAttrib(this ArbCreateContext thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hShareContext, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attribList)
        {
            // SpanOverloader
            return thisApi.CreateContextAttrib(hDC, hShareContext, in attribList.GetPinnableReference());
        }

    }
}

