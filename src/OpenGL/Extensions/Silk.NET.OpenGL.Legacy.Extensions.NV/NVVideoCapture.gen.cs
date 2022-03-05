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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_video_capture")]
    public unsafe partial class NVVideoCapture : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_video_capture";
        [NativeApi(EntryPoint = "glBeginVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public partial void BeginVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot);

        [NativeApi(EntryPoint = "glBindVideoCaptureStreamBufferNV", Convention = CallingConvention.Winapi)]
        public partial void BindVideoCaptureStreamBuffer([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindVideoCaptureStreamTextureNV", Convention = CallingConvention.Winapi)]
        public partial void BindVideoCaptureStreamTexture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glEndVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public partial void EndVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot);

        [NativeApi(EntryPoint = "glGetVideoCaptureivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureivNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] uint* sequence_num, [Flow(FlowDirection.Out)] ulong* capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] uint* sequence_num, [Flow(FlowDirection.Out)] out ulong capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] out uint sequence_num, [Flow(FlowDirection.Out)] ulong* capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public partial NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] out uint sequence_num, [Flow(FlowDirection.Out)] out ulong capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in int @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in float @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV", Convention = CallingConvention.Winapi)]
        public partial void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] in double @params);

        public NVVideoCapture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

