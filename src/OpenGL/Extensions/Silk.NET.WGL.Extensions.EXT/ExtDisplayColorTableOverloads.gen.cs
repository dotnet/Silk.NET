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

namespace Silk.NET.WGL.Extensions.EXT
{
    public static class ExtDisplayColorTableOverloads
    {
        public static unsafe bool LoadDisplayColorTable(this ExtDisplayColorTable thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<ushort> table, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint length)
        {
            // SpanOverloader
            return thisApi.LoadDisplayColorTable(in table.GetPinnableReference(), length);
        }

    }
}

