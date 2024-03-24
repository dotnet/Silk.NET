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

namespace Silk.NET.OpenCL.Extensions.IMG
{
    public static class ImgCancelCommandOverloads
    {
        public static unsafe int CancelCommands(this ImgCancelCommand thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> event_list, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint num_events_in_list)
        {
            // SpanOverloader
            return thisApi.CancelCommands(in event_list.GetPinnableReference(), num_events_in_list);
        }

    }
}

