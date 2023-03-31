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

namespace Silk.NET.WGL.Extensions.AMD
{
    public static class AmdGpuAssociationOverloads
    {
        public static unsafe nint CreateAssociatedContextAttrib(this AmdGpuAssociation thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hShareContext, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<int> attribList)
        {
            // SpanOverloader
            return thisApi.CreateAssociatedContextAttrib(id, hShareContext, in attribList.GetPinnableReference());
        }

        public static unsafe uint GetGpuids(this AmdGpuAssociation thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint maxCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<uint> ids)
        {
            // SpanOverloader
            return thisApi.GetGpuids(maxCount, out ids.GetPinnableReference());
        }

        public static unsafe int GetGpuinfo<T0>(this AmdGpuAssociation thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int property, [Flow(Silk.NET.Core.Native.FlowDirection.In)] AMD dataType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint size, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.GetGpuinfo(id, property, dataType, size, out data.GetPinnableReference());
        }

    }
}

