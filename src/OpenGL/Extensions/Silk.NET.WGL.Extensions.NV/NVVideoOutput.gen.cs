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
    [Extension("NV_video_output")]
    public unsafe partial class NVVideoOutput : NativeExtension<WGL>
    {
        public const string ExtensionName = "NV_video_output";
        [NativeApi(EntryPoint = "wglBindVideoImageNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 BindVideoImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hVideoDevice, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iVideoBuffer);

        [NativeApi(EntryPoint = "wglGetVideoDeviceNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetVideoDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numDevices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] nint* hVideoDevice);

        [NativeApi(EntryPoint = "wglGetVideoDeviceNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetVideoDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hDC, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int numDevices, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out nint hVideoDevice);

        [NativeApi(EntryPoint = "wglGetVideoInfoNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetVideoInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hpVideoDevice, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pulCounterOutputPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pulCounterOutputVideo);

        [NativeApi(EntryPoint = "wglGetVideoInfoNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetVideoInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hpVideoDevice, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pulCounterOutputPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pulCounterOutputVideo);

        [NativeApi(EntryPoint = "wglGetVideoInfoNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 GetVideoInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hpVideoDevice, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pulCounterOutputPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pulCounterOutputVideo);

        [NativeApi(EntryPoint = "wglGetVideoInfoNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 GetVideoInfo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hpVideoDevice, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pulCounterOutputPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pulCounterOutputVideo);

        [NativeApi(EntryPoint = "wglReleaseVideoDeviceNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ReleaseVideoDevice([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hVideoDevice);

        [NativeApi(EntryPoint = "wglReleaseVideoImageNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 ReleaseVideoImage([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iVideoBuffer);

        [NativeApi(EntryPoint = "wglSendPbufferToVideoNV", Convention = CallingConvention.Winapi)]
        public unsafe partial Silk.NET.Core.Bool32 SendPbufferToVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iBufferType, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* pulCounterPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Bool32 bBlock);

        [NativeApi(EntryPoint = "wglSendPbufferToVideoNV", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 SendPbufferToVideo([Flow(Silk.NET.Core.Native.FlowDirection.In)] nint hPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int iBufferType, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint pulCounterPbuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Core.Bool32 bBlock);

        public NVVideoOutput(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

