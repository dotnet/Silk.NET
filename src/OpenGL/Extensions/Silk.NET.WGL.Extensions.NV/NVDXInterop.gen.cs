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
    [Extension("NV_DX_interop")]
    public unsafe partial class NVDXInterop : NativeExtension<WGL>
    {
        public const string ExtensionName = "NV_DX_interop";
        [NativeApi(EntryPoint = "wglDXCloseDeviceNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DxcloseDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice);

        [NativeApi(EntryPoint = "wglDXLockObjectsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 DxlockObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* hObjects);

        [NativeApi(EntryPoint = "wglDXLockObjectsNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DxlockObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint hObjects);

        [NativeApi(EntryPoint = "wglDXObjectAccessNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DxobjectAccess([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "wglDXOpenDeviceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint DxopenDevice([Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dxDevice);

        [NativeApi(EntryPoint = "wglDXOpenDeviceNV", Convention = CallingConvention.Winapi)]
        public partial nint DxopenDevice<T0>([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dxDevice) where T0 : unmanaged;

        [NativeApi(EntryPoint = "wglDXRegisterObjectNV", Convention = CallingConvention.Winapi)]
        public unsafe partial nint DxregisterObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dxObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV access);

        [NativeApi(EntryPoint = "wglDXRegisterObjectNV", Convention = CallingConvention.Winapi)]
        public partial nint DxregisterObject<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dxObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV type, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV access) where T0 : unmanaged;

        [NativeApi(EntryPoint = "wglDXSetResourceShareHandleNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 DxsetResourceShareHandle([Flow(Silk.NET.Core.Native.FlowDirection.Out)] void* dxObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint shareHandle);

        [NativeApi(EntryPoint = "wglDXSetResourceShareHandleNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DxsetResourceShareHandle<T0>([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out T0 dxObject, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint shareHandle) where T0 : unmanaged;

        [NativeApi(EntryPoint = "wglDXUnlockObjectsNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 DxunlockObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* hObjects);

        [NativeApi(EntryPoint = "wglDXUnlockObjectsNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DxunlockObjects([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int count, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint hObjects);

        [NativeApi(EntryPoint = "wglDXUnregisterObjectNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DxunregisterObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hObject);

        public NVDXInterop(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

