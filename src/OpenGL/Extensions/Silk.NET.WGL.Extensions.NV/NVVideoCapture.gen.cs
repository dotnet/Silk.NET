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
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.NV
{
    [Extension("NV_video_capture")]
    public unsafe partial class NVVideoCapture : NativeExtension<WGL>
    {
        public const string ExtensionName = "NV_video_capture";
        [NativeApi(EntryPoint = "wglBindVideoCaptureDeviceNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 BindVideoCaptureDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uVideoSlot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice);

        [NativeApi(EntryPoint = "wglEnumerateVideoCaptureDevicesNV", Convention = CallingConvention.Winapi)]
        public unsafe partial uint EnumerateVideoCaptureDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* phDeviceList);

        [NativeApi(EntryPoint = "wglEnumerateVideoCaptureDevicesNV", Convention = CallingConvention.Winapi)]
        public partial uint EnumerateVideoCaptureDevices([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint phDeviceList);

        [NativeApi(EntryPoint = "wglLockVideoCaptureDeviceNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 LockVideoCaptureDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice);

        [NativeApi(EntryPoint = "wglQueryVideoCaptureDeviceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryVideoCaptureDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piValue);

        [NativeApi(EntryPoint = "wglQueryVideoCaptureDeviceNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 QueryVideoCaptureDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piValue);

        [NativeApi(EntryPoint = "wglReleaseVideoCaptureDeviceNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ReleaseVideoCaptureDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDc, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice);

        public NVVideoCapture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

