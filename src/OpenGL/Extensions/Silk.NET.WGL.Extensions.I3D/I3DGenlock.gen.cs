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
    [Extension("I3D_genlock")]
    public unsafe partial class I3DGenlock : NativeExtension<WGL>
    {
        public const string ExtensionName = "I3D_genlock";
        [NativeApi(EntryPoint = "wglDisableGenlockI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 DisableGenlockI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC);

        [NativeApi(EntryPoint = "wglEnableGenlockI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 EnableGenlockI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC);

        [NativeApi(EntryPoint = "wglGenlockSampleRateI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GenlockSampleRateI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uRate);

        [NativeApi(EntryPoint = "wglGenlockSourceDelayI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GenlockSourceDelayI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uDelay);

        [NativeApi(EntryPoint = "wglGenlockSourceEdgeI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GenlockSourceEdgeI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uEdge);

        [NativeApi(EntryPoint = "wglGenlockSourceI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GenlockSourceI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint uSource);

        [NativeApi(EntryPoint = "wglGetGenlockSampleRateI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGenlockSampleRateI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uRate);

        [NativeApi(EntryPoint = "wglGetGenlockSampleRateI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetGenlockSampleRateI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uRate);

        [NativeApi(EntryPoint = "wglGetGenlockSourceDelayI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGenlockSourceDelayI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uDelay);

        [NativeApi(EntryPoint = "wglGetGenlockSourceDelayI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetGenlockSourceDelayI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uDelay);

        [NativeApi(EntryPoint = "wglGetGenlockSourceEdgeI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGenlockSourceEdgeI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uEdge);

        [NativeApi(EntryPoint = "wglGetGenlockSourceEdgeI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetGenlockSourceEdgeI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uEdge);

        [NativeApi(EntryPoint = "wglGetGenlockSourceI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetGenlockSourceI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uSource);

        [NativeApi(EntryPoint = "wglGetGenlockSourceI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetGenlockSourceI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uSource);

        [NativeApi(EntryPoint = "wglIsEnabledGenlockI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 IsEnabledGenlockI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] Silk.NET.Core.Bool32* pFlag);

        [NativeApi(EntryPoint = "wglIsEnabledGenlockI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 IsEnabledGenlockI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out Silk.NET.Core.Bool32 pFlag);

        [NativeApi(EntryPoint = "wglQueryGenlockMaxSourceDelayI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryGenlockMaxSourceDelayI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uMaxLineDelay, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uMaxPixelDelay);

        [NativeApi(EntryPoint = "wglQueryGenlockMaxSourceDelayI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryGenlockMaxSourceDelayI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uMaxLineDelay, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uMaxPixelDelay);

        [NativeApi(EntryPoint = "wglQueryGenlockMaxSourceDelayI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryGenlockMaxSourceDelayI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uMaxLineDelay, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* uMaxPixelDelay);

        [NativeApi(EntryPoint = "wglQueryGenlockMaxSourceDelayI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 QueryGenlockMaxSourceDelayI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uMaxLineDelay, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint uMaxPixelDelay);

        public I3DGenlock(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

