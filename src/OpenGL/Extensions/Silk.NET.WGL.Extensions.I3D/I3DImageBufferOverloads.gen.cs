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
    public static class I3DImageBufferOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D(this I3DImageBuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pEvent, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pAddress, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            return thisApi.AssociateImageBufferEventsI3D(hDC, pEvent, pAddress, in pSize.GetPinnableReference(), count);
        }

        public static unsafe Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D(this I3DImageBuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pEvent, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pAddress, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            return thisApi.AssociateImageBufferEventsI3D(hDC, pEvent, in pAddress.GetPinnableReference(), pSize, count);
        }

        public static unsafe Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D(this I3DImageBuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pEvent, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pAddress, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            return thisApi.AssociateImageBufferEventsI3D(hDC, pEvent, in pAddress.GetPinnableReference(), in pSize.GetPinnableReference(), count);
        }

        public static unsafe Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D(this I3DImageBuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pEvent, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pAddress, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            return thisApi.AssociateImageBufferEventsI3D(hDC, in pEvent.GetPinnableReference(), pAddress, pSize, count);
        }

        public static unsafe Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D(this I3DImageBuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pEvent, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint* pAddress, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            return thisApi.AssociateImageBufferEventsI3D(hDC, in pEvent.GetPinnableReference(), pAddress, in pSize.GetPinnableReference(), count);
        }

        public static unsafe Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D(this I3DImageBuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pEvent, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pAddress, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* pSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            return thisApi.AssociateImageBufferEventsI3D(hDC, in pEvent.GetPinnableReference(), in pAddress.GetPinnableReference(), pSize, count);
        }

        public static unsafe Silk.NET.Core.Bool32 AssociateImageBufferEventsI3D(this I3DImageBuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pEvent, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pAddress, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<uint> pSize, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            return thisApi.AssociateImageBufferEventsI3D(hDC, in pEvent.GetPinnableReference(), in pAddress.GetPinnableReference(), in pSize.GetPinnableReference(), count);
        }

        public static unsafe Silk.NET.Core.Bool32 ReleaseImageBufferEventsI3D(this I3DImageBuffer thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<nint> pAddress, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count)
        {
            // SpanOverloader
            return thisApi.ReleaseImageBufferEventsI3D(hDC, in pAddress.GetPinnableReference(), count);
        }

    }
}

