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

namespace Silk.NET.WGL.Extensions.I3D
{
    [Extension("I3D_swap_frame_lock")]
    public unsafe partial class I3DSwapFrameLock : NativeExtension<WGL>
    {
        public const string ExtensionName = "I3D_swap_frame_lock";
        [NativeApi(EntryPoint = "wglDisableFrameLockI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DisableFrameLockI3D();

        [NativeApi(EntryPoint = "wglEnableFrameLockI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 EnableFrameLockI3D();

        [NativeApi(EntryPoint = "wglIsEnabledFrameLockI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 IsEnabledFrameLockI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] Silk.NET.Core.Bool32* pFlag);

        [NativeApi(EntryPoint = "wglIsEnabledFrameLockI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 IsEnabledFrameLockI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Silk.NET.Core.Bool32 pFlag);

        [NativeApi(EntryPoint = "wglQueryFrameLockMasterI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryFrameLockMasterI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] Silk.NET.Core.Bool32* pFlag);

        [NativeApi(EntryPoint = "wglQueryFrameLockMasterI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 QueryFrameLockMasterI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Silk.NET.Core.Bool32 pFlag);

        public I3DSwapFrameLock(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

