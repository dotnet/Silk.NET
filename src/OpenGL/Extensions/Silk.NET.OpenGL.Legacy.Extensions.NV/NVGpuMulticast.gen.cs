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
    [Extension("NV_gpu_multicast")]
    public abstract unsafe partial class NVGpuMulticast : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastBarrierNV")]
        public abstract void MulticastBarrier();

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastBlitFramebufferNV")]
        public abstract void MulticastBlitFramebuffer([Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpu, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV filter);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastBufferSubDataNV")]
        public abstract unsafe void MulticastBufferSubData([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastBufferSubDataNV")]
        public abstract void MulticastBufferSubData<T0>([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastCopyBufferSubDataNV")]
        public abstract void MulticastCopyBufferSubData([Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastCopyImageSubDataNV")]
        public abstract void MulticastCopyImageSubData([Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpuMask, [Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] NV srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] NV dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastFramebufferSampleLocationsfvNV")]
        public abstract unsafe void MulticastFramebufferSampleLocations([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastFramebufferSampleLocationsfvNV")]
        public abstract void MulticastFramebufferSampleLocations([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<float> v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectivNV")]
        public abstract unsafe void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] int* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectivNV")]
        public abstract void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] Span<int> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectuivNV")]
        public abstract unsafe void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] uint* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectuivNV")]
        public abstract void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] Span<uint> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastGetQueryObjecti64vNV")]
        public abstract unsafe void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] long* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastGetQueryObjecti64vNV")]
        public abstract void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] Span<long> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectui64vNV")]
        public abstract unsafe void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] ulong* @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectui64vNV")]
        public abstract void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] Span<ulong> @params);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastWaitSyncNV")]
        public abstract void MulticastWaitSync([Flow(FlowDirection.In)] uint signalGpu, [Flow(FlowDirection.In)] uint waitGpuMask);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glRenderGpuMaskNV")]
        public abstract void RenderGpuMask([Flow(FlowDirection.In)] uint mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpuMask">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void MulticastBufferSubData([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            MulticastBufferSubData(gpuMask, buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpuMask">
        /// To be added.
        /// </param>
        /// <param name="buffer">
        /// To be added.
        /// </param>
        /// <param name="offset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        /// <param name="data">
        /// To be added.
        /// </param>
        public unsafe void MulticastBufferSubData<T0>([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            MulticastBufferSubData(gpuMask, buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="readGpu">
        /// To be added.
        /// </param>
        /// <param name="writeGpuMask">
        /// To be added.
        /// </param>
        /// <param name="readBuffer">
        /// To be added.
        /// </param>
        /// <param name="writeBuffer">
        /// To be added.
        /// </param>
        /// <param name="readOffset">
        /// To be added.
        /// </param>
        /// <param name="writeOffset">
        /// To be added.
        /// </param>
        /// <param name="size">
        /// To be added.
        /// </param>
        public unsafe void MulticastCopyBufferSubData([Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            MulticastCopyBufferSubData(readGpu, writeGpuMask, readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        public NVGpuMulticast(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

