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
    [Extension("I3D_digital_video_control")]
    public unsafe partial class I3DDigitalVideoControl : NativeExtension<WGL>
    {
        public const string ExtensionName = "I3D_digital_video_control";
        [NativeApi(EntryPoint = "wglGetDigitalVideoParametersI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetDigitalVideoParametersI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* piValue);

        [NativeApi(EntryPoint = "wglGetDigitalVideoParametersI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetDigitalVideoParametersI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int piValue);

        [NativeApi(EntryPoint = "wglSetDigitalVideoParametersI3D", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SetDigitalVideoParametersI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int* piValue);

        [NativeApi(EntryPoint = "wglSetDigitalVideoParametersI3D", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SetDigitalVideoParametersI3D([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iAttribute, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int piValue);

        public I3DDigitalVideoControl(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

