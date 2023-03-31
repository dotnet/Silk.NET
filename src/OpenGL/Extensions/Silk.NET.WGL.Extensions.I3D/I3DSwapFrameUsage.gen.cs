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
    [Extension("I3D_swap_frame_usage")]
    public unsafe partial class I3DSwapFrameUsage : NativeExtension<WGL>
    {
        public const string ExtensionName = "I3D_swap_frame_usage";
        [NativeApi(EntryPoint = "wglBeginFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 BeginFrameTrackingI3D();

        [NativeApi(EntryPoint = "wglEndFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 EndFrameTrackingI3D();

        [NativeApi(EntryPoint = "wglGetFrameUsageI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetFrameUsageI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pUsage);

        [NativeApi(EntryPoint = "wglGetFrameUsageI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetFrameUsageI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float pUsage);

        [NativeApi(EntryPoint = "wglQueryFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryFrameTrackingI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pLastMissedUsage);

        [NativeApi(EntryPoint = "wglQueryFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryFrameTrackingI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float pLastMissedUsage);

        [NativeApi(EntryPoint = "wglQueryFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryFrameTrackingI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pLastMissedUsage);

        [NativeApi(EntryPoint = "wglQueryFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryFrameTrackingI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float pLastMissedUsage);

        [NativeApi(EntryPoint = "wglQueryFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryFrameTrackingI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pLastMissedUsage);

        [NativeApi(EntryPoint = "wglQueryFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryFrameTrackingI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float pLastMissedUsage);

        [NativeApi(EntryPoint = "wglQueryFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 QueryFrameTrackingI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* pLastMissedUsage);

        [NativeApi(EntryPoint = "wglQueryFrameTrackingI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 QueryFrameTrackingI3D([Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pFrameCount, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pMissedFrames, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float pLastMissedUsage);

        public I3DSwapFrameUsage(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

