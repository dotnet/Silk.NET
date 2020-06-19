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

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_gpu_multicast2")]
    public abstract unsafe partial class NvxGpuMulticast2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NVX_gpu_multicast2";
        [NativeApi(EntryPoint = "glAsyncCopyBufferSubDataNVX")]
        public abstract unsafe uint AsyncCopyBufferSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] uint* waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] ulong* fenceValueArray, [Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] uint* signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] ulong* signalValueArray);

        [NativeApi(EntryPoint = "glAsyncCopyBufferSubDataNVX")]
        public abstract uint AsyncCopyBufferSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> fenceValueArray, [Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> signalValueArray);

        [NativeApi(EntryPoint = "glAsyncCopyImageSubDataNVX")]
        public abstract unsafe uint AsyncCopyImageSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] uint* waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] ulong* waitValueArray, [Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpuMask, [Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] NVX srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] NVX dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] uint* signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] ulong* signalValueArray);

        [NativeApi(EntryPoint = "glAsyncCopyImageSubDataNVX")]
        public abstract uint AsyncCopyImageSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> waitValueArray, [Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpuMask, [Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] NVX srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] NVX dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<uint> signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] Span<ulong> signalValueArray);

        [NativeApi(EntryPoint = "glMulticastScissorArrayvNVX")]
        public abstract unsafe void MulticastScissorArray([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMulticastScissorArrayvNVX")]
        public abstract void MulticastScissorArray([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref int v);

        [NativeApi(EntryPoint = "glMulticastViewportArrayvNVX")]
        public abstract unsafe void MulticastViewportArray([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMulticastViewportArrayvNVX")]
        public abstract void MulticastViewportArray([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint first, [Flow(FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(FlowDirection.In)] ref float v);

        [NativeApi(EntryPoint = "glMulticastViewportPositionWScaleNVX")]
        public abstract void MulticastViewportPositionWScale([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] float xcoeff, [Flow(FlowDirection.In)] float ycoeff);

        [NativeApi(EntryPoint = "glUploadGpuMaskNVX")]
        public abstract void UploadGpuMask([Flow(FlowDirection.In)] uint mask);

        public unsafe uint AsyncCopyBufferSubData([Flow(FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] uint* waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(FlowDirection.In)] ulong* fenceValueArray, [Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] uint* signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(FlowDirection.In)] ulong* signalValueArray)
        {
            // IntPtrOverloader
            return AsyncCopyBufferSubData(waitSemaphoreCount, waitSemaphoreArray, fenceValueArray, readGpu, writeGpuMask, readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size), signalSemaphoreCount, signalSemaphoreArray, signalValueArray);
        }

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

