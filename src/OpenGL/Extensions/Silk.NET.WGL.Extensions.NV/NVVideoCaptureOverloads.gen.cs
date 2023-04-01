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
    public static class NVVideoCaptureOverloads
    {
        public static unsafe uint EnumerateVideoCaptureDevices(this NVVideoCapture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<nint> phDeviceList)
        {
            // SpanOverloader
            return thisApi.EnumerateVideoCaptureDevices(hDc, out phDeviceList.GetPinnableReference());
        }

        public static unsafe Silk.NET.Core.Bool32 QueryVideoCaptureDevice(this NVVideoCapture thisApi, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Span<int> piValue)
        {
            // SpanOverloader
            return thisApi.QueryVideoCaptureDevice(hDc, hDevice, iAttribute, out piValue.GetPinnableReference());
        }

    }
}

