// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_video_capture")]
    public unsafe partial class NVVideoCapture : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_video_capture";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBeginVideoCaptureNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BeginVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot)
            => ImplBeginVideoCapture(video_capture_slot);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="frame_region">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindVideoCaptureStreamBufferNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindVideoCaptureStreamBuffer([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] IntPtr offset)
            => ImplBindVideoCaptureStreamBuffer(video_capture_slot, stream, frame_region, offset);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="frame_region">
        /// To be added.
        /// </param>
        /// <param name="target">
        /// To be added.
        /// </param>
        /// <param name="texture">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glBindVideoCaptureStreamTextureNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void BindVideoCaptureStreamTexture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint texture)
            => ImplBindVideoCaptureStreamTexture(video_capture_slot, stream, frame_region, target, texture);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glEndVideoCaptureNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void EndVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot)
            => ImplEndVideoCapture(video_capture_slot);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoCaptureivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVideoCapture(video_capture_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoCaptureivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetVideoCapture(video_capture_slot, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params)
            => ImplGetVideoCaptureStream(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params)
            => ImplGetVideoCaptureStream(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params)
            => ImplGetVideoCaptureStream(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params)
            => ImplGetVideoCaptureStream(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params)
            => ImplGetVideoCaptureStream(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params)
            => ImplGetVideoCaptureStream(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="sequence_num">
        /// To be added.
        /// </param>
        /// <param name="capture_time">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glVideoCaptureNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] uint* sequence_num, [Flow(FlowDirection.Out)] ulong* capture_time)
            => ImplVideoCapture(video_capture_slot, sequence_num, capture_time);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="sequence_num">
        /// To be added.
        /// </param>
        /// <param name="capture_time">
        /// To be added.
        /// </param>
        /// <returns>See summary.</returns>
        [NativeApi(EntryPoint = "glVideoCaptureNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] Span<uint> sequence_num, [Flow(FlowDirection.Out)] Span<ulong> capture_time)
            => ImplVideoCapture(video_capture_slot, sequence_num, capture_time);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params)
            => ImplVideoCaptureStreamParameter(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params)
            => ImplVideoCaptureStreamParameter(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params)
            => ImplVideoCaptureStreamParameter(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params)
            => ImplVideoCaptureStreamParameter(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params)
            => ImplVideoCaptureStreamParameter(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// This parameter's element count is computed from pname.
        /// </param>
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref double @params)
            => ImplVideoCaptureStreamParameter(video_capture_slot, stream, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="video_capture_slot">
        /// To be added.
        /// </param>
        /// <param name="stream">
        /// To be added.
        /// </param>
        /// <param name="frame_region">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void BindVideoCaptureStreamBuffer([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            BindVideoCaptureStreamBuffer(video_capture_slot, stream, frame_region, new IntPtr(offset));
        }

        public NVVideoCapture(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

