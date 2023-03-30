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

namespace Silk.NET.Direct3D9
{
    public static class D3D9Overloads
    {
        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 315, Column 12 in d3d9.h")]
        public static unsafe int PERFBeginEvent(this D3D9 thisApi, uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wszName)
        {
            // SpanOverloader
            return thisApi.PERFBeginEvent(col, in wszName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 317, Column 13 in d3d9.h")]
        public static unsafe void PERFSetMarker(this D3D9 thisApi, uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wszName)
        {
            // SpanOverloader
            thisApi.PERFSetMarker(col, in wszName.GetPinnableReference());
        }

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 318, Column 13 in d3d9.h")]
        public static unsafe void PERFSetRegion(this D3D9 thisApi, uint col, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<char> wszName)
        {
            // SpanOverloader
            thisApi.PERFSetRegion(col, in wszName.GetPinnableReference());
        }

    }
}

