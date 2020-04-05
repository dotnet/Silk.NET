// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_video_capture")]
    public abstract unsafe partial class NVVideoCapture : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBeginVideoCaptureNV")]
        public abstract void BeginVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindVideoCaptureStreamBufferNV")]
        public abstract void BindVideoCaptureStreamBuffer([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] IntPtr offset);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glBindVideoCaptureStreamTextureNV")]
        public abstract void BindVideoCaptureStreamTexture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] NV target, [Flow(FlowDirection.In)] uint texture);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glEndVideoCaptureNV")]
        public abstract void EndVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVideoCaptureivNV")]
        public abstract unsafe void GetVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVideoCaptureivNV")]
        public abstract void GetVideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV")]
        public abstract unsafe void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamivNV")]
        public abstract void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV")]
        public abstract unsafe void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamfvNV")]
        public abstract void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV")]
        public abstract unsafe void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glGetVideoCaptureStreamdvNV")]
        public abstract void GetVideoCaptureStream([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out double @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVideoCaptureNV")]
        public abstract unsafe NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] uint* sequence_num, [Flow(FlowDirection.Out)] ulong* capture_time);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVideoCaptureNV")]
        public abstract NV VideoCapture([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.Out)] Span<uint> sequence_num, [Flow(FlowDirection.Out)] Span<ulong> capture_time);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV")]
        public abstract unsafe void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterivNV")]
        public abstract void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV")]
        public abstract unsafe void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterfvNV")]
        public abstract void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV")]
        public abstract unsafe void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] double* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glVideoCaptureStreamParameterdvNV")]
        public abstract void VideoCaptureStreamParameter([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref double @params);

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
        public unsafe void BindVideoCaptureStreamBuffer([Flow(FlowDirection.In)] uint video_capture_slot, [Flow(FlowDirection.In)] uint stream, [Flow(FlowDirection.In)] NV frame_region, [Flow(FlowDirection.In)] int offset)
        {
            // IntPtrOverloader
            BindVideoCaptureStreamBuffer(video_capture_slot, stream, frame_region, new IntPtr(offset));
        }

        public NVVideoCapture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

