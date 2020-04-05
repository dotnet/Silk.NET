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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_gpu_multicast2")]
    public abstract unsafe partial class NvxGpuMulticast2 : NativeExtension<GL>
    {
        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAsyncCopyBufferSubDataNVX")]
        public abstract unsafe uint AsyncCopyBufferSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] uint* waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] ulong* fenceValueArray, [Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] uint* signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] ulong* signalValueArray);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAsyncCopyBufferSubDataNVX")]
        public abstract uint AsyncCopyBufferSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> fenceValueArray, [Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> signalValueArray);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAsyncCopyImageSubDataNVX")]
        public abstract unsafe uint AsyncCopyImageSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] uint* waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] ulong* waitValueArray, [Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpuMask, [Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] NVX srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] NVX dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] uint* signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] ulong* signalValueArray);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glAsyncCopyImageSubDataNVX")]
        public abstract uint AsyncCopyImageSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> waitValueArray, [Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpuMask, [Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] NVX srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] NVX dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> signalValueArray);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastScissorArrayvNVX")]
        public abstract unsafe void MulticastScissorArray([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastScissorArrayvNVX")]
        public abstract void MulticastScissorArray([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastViewportArrayvNVX")]
        public abstract unsafe void MulticastViewportArray([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] float* v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastViewportArrayvNVX")]
        public abstract void MulticastViewportArray([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref float v);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glMulticastViewportPositionWScaleNVX")]
        public abstract void MulticastViewportPositionWScale([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float xcoeff, [Flow(FlowDirection.In)] float ycoeff);

        /// <inheritdoc />
        [NativeApi(EntryPoint = "glUploadGpuMaskNVX")]
        public abstract void UploadGpuMask([Flow(FlowDirection.In)] uint mask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="waitSemaphoreCount">
        /// To be added.
        /// </param>
        /// <param name="waitSemaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from waitSemaphoreCount.
        /// </param>
        /// <param name="fenceValueArray">
        /// To be added.
        /// This parameter's element count is taken from waitSemaphoreCount.
        /// </param>
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
        /// <param name="signalSemaphoreCount">
        /// To be added.
        /// </param>
        /// <param name="signalSemaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from signalSemaphoreCount.
        /// </param>
        /// <param name="signalValueArray">
        /// To be added.
        /// This parameter's element count is taken from signalSemaphoreCount.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe uint AsyncCopyBufferSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] uint* waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] ulong* fenceValueArray, [Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] uint* signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] ulong* signalValueArray)
        {
            // IntPtrOverloader
            return AsyncCopyBufferSubData(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size), signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
        }

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="waitSemaphoreCount">
        /// To be added.
        /// </param>
        /// <param name="waitSemaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from waitSemaphoreCount.
        /// </param>
        /// <param name="fenceValueArray">
        /// To be added.
        /// This parameter's element count is taken from waitSemaphoreCount.
        /// </param>
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
        /// <param name="signalSemaphoreCount">
        /// To be added.
        /// </param>
        /// <param name="signalSemaphoreArray">
        /// To be added.
        /// This parameter's element count is taken from signalSemaphoreCount.
        /// </param>
        /// <param name="signalValueArray">
        /// To be added.
        /// This parameter's element count is taken from signalSemaphoreCount.
        /// </param>
        /// <returns>See summary.</returns>
        public unsafe uint AsyncCopyBufferSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> fenceValueArray, [Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> signalValueArray)
        {
            // IntPtrOverloader
            return AsyncCopyBufferSubData(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size), signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
        }

        public NvxGpuMulticast2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

