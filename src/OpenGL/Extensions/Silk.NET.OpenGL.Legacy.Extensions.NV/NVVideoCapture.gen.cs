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
        public partial void BeginVideoCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot);

        [NativeApi(EntryPoint = "glBindVideoCaptureStreamBufferNV", Convention = CallingConvention.Winapi)]
        public partial void BindVideoCaptureStreamBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV frame_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset);

        [NativeApi(EntryPoint = "glBindVideoCaptureStreamTextureNV", Convention = CallingConvention.Winapi)]
        public partial void BindVideoCaptureStreamTexture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV frame_region, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint texture);

        [NativeApi(EntryPoint = "glEndVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public partial void EndVideoCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot);

        [NativeApi(EntryPoint = "glGetVideoCaptureivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideoCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureivNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideoCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideoCaptureStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideoCaptureStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideoCaptureStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideoCaptureStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetVideoCaptureStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] double* @params);

        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV", Convention = CallingConvention.Winapi)]
        public partial void GetVideoCaptureStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out double @params);

        [NativeApi(EntryPoint = "glVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV VideoCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sequence_num, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV VideoCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* sequence_num, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public unsafe partial NV VideoCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint sequence_num, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureNV", Convention = CallingConvention.Winapi)]
        public partial NV VideoCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint sequence_num, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong capture_time);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VideoCaptureStreamParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV", Convention = CallingConvention.Winapi)]
        public partial void VideoCaptureStreamParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in int @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VideoCaptureStreamParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV", Convention = CallingConvention.Winapi)]
        public partial void VideoCaptureStreamParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void VideoCaptureStreamParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* @params);

        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV", Convention = CallingConvention.Winapi)]
        public partial void VideoCaptureStreamParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double @params);

        public unsafe int GetVideoCapture([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetVideoCapture(video_capture_slot, pname, out int silkRet);
            return silkRet;
        }

        public unsafe int GetVideoCaptureStream([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint video_capture_slot, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint stream, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            GetVideoCaptureStream(video_capture_slot, stream, pname, out int silkRet);
            return silkRet;
        }

        public NVVideoCapture(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

