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

namespace Silk.NET.WGL.Extensions.NV
{
    public static class NVDXInteropOverloads
    {
        public static unsafe Silk.NET.Core.Bool32 DxlockObjects(this NVDXInterop thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> hObjects)
        {
            // SpanOverloader
            return thisApi.DxlockObjects(hDevice, count, out hObjects.GetPinnableReference());
        }

        public static unsafe nint DxopenDevice<T0>(this NVDXInterop thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dxDevice) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DxopenDevice(out dxDevice.GetPinnableReference());
        }

        public static unsafe nint DxregisterObject<T0>(this NVDXInterop thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dxObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV access) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DxregisterObject(hDevice, out dxObject.GetPinnableReference(), name, type, access);
        }

        public static unsafe Silk.NET.Core.Bool32 DxsetResourceShareHandle<T0>(this NVDXInterop thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<T0> dxObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint shareHandle) where T0 : unmanaged
        {
            // SpanOverloader
            return thisApi.DxsetResourceShareHandle(out dxObject.GetPinnableReference(), shareHandle);
        }

        public static unsafe Silk.NET.Core.Bool32 DxunlockObjects(this NVDXInterop thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> hObjects)
        {
            // SpanOverloader
            return thisApi.DxunlockObjects(hDevice, count, out hObjects.GetPinnableReference());
        }

    }
}

