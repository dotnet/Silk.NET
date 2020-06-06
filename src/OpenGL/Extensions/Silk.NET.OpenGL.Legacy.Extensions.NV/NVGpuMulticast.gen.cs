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
    [Extension("NV_gpu_multicast")]
    public unsafe partial class NVGpuMulticast : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_gpu_multicast";
        /// <summary>
        /// To be added.
        /// </summary>
        [NativeApi(EntryPoint = "glMulticastBarrierNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastBarrier()
            => ImplMulticastBarrier();

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="srcGpu">
        /// To be added.
        /// </param>
        /// <param name="dstGpu">
        /// To be added.
        /// </param>
        /// <param name="srcX0">
        /// To be added.
        /// </param>
        /// <param name="srcY0">
        /// To be added.
        /// </param>
        /// <param name="srcX1">
        /// To be added.
        /// </param>
        /// <param name="srcY1">
        /// To be added.
        /// </param>
        /// <param name="dstX0">
        /// To be added.
        /// </param>
        /// <param name="dstY0">
        /// To be added.
        /// </param>
        /// <param name="dstX1">
        /// To be added.
        /// </param>
        /// <param name="dstY1">
        /// To be added.
        /// </param>
        /// <param name="mask">
        /// To be added.
        /// </param>
        /// <param name="filter">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastBlitFramebufferNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastBlitFramebuffer([Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpu, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV filter)
            => ImplMulticastBlitFramebuffer(srcGpu, dstGpu, srcX0, srcY0, srcX1, srcY1, dstX0, dstY0, dstX1, dstY1, mask, filter);

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
        [NativeApi(EntryPoint = "glMulticastBufferSubDataNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MulticastBufferSubData([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data)
            => ImplMulticastBufferSubData(gpuMask, buffer, offset, size, data);

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
        [NativeApi(EntryPoint = "glMulticastBufferSubDataNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastBufferSubData<T0>([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
            => ImplMulticastBufferSubData<T0>(gpuMask, buffer, offset, size, data);

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
        [NativeApi(EntryPoint = "glMulticastCopyBufferSubDataNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastCopyBufferSubData([Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] IntPtr readOffset, [Flow(FlowDirection.In)] IntPtr writeOffset, [Flow(FlowDirection.In)] UIntPtr size)
            => ImplMulticastCopyBufferSubData(readGpu, writeGpuMask, readBuffer, writeBuffer, readOffset, writeOffset, size);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="srcGpu">
        /// To be added.
        /// </param>
        /// <param name="dstGpuMask">
        /// To be added.
        /// </param>
        /// <param name="srcName">
        /// To be added.
        /// </param>
        /// <param name="srcTarget">
        /// To be added.
        /// </param>
        /// <param name="srcLevel">
        /// To be added.
        /// </param>
        /// <param name="srcX">
        /// To be added.
        /// </param>
        /// <param name="srcY">
        /// To be added.
        /// </param>
        /// <param name="srcZ">
        /// To be added.
        /// </param>
        /// <param name="dstName">
        /// To be added.
        /// </param>
        /// <param name="dstTarget">
        /// To be added.
        /// </param>
        /// <param name="dstLevel">
        /// To be added.
        /// </param>
        /// <param name="dstX">
        /// To be added.
        /// </param>
        /// <param name="dstY">
        /// To be added.
        /// </param>
        /// <param name="dstZ">
        /// To be added.
        /// </param>
        /// <param name="srcWidth">
        /// To be added.
        /// </param>
        /// <param name="srcHeight">
        /// To be added.
        /// </param>
        /// <param name="srcDepth">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastCopyImageSubDataNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastCopyImageSubData([Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpuMask, [Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] NV srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] NV dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth)
            => ImplMulticastCopyImageSubData(srcGpu, dstGpuMask, srcName, srcTarget, srcLevel, srcX, srcY, srcZ, dstName, dstTarget, dstLevel, dstX, dstY, dstZ, srcWidth, srcHeight, srcDepth);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastFramebufferSampleLocationsfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MulticastFramebufferSampleLocations([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v)
            => ImplMulticastFramebufferSampleLocations(gpu, framebuffer, start, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="framebuffer">
        /// To be added.
        /// </param>
        /// <param name="start">
        /// To be added.
        /// </param>
        /// <param name="count">
        /// To be added.
        /// </param>
        /// <param name="v">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastFramebufferSampleLocationsfvNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastFramebufferSampleLocations([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] Span<float> v)
            => ImplMulticastFramebufferSampleLocations(gpu, framebuffer, start, count, v);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] int* @params)
            => ImplMulticastGetQueryObject(gpu, id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] Span<int> @params)
            => ImplMulticastGetQueryObject(gpu, id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectuivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] uint* @params)
            => ImplMulticastGetQueryObject(gpu, id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectuivNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] Span<uint> @params)
            => ImplMulticastGetQueryObject(gpu, id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastGetQueryObjecti64vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] long* @params)
            => ImplMulticastGetQueryObject(gpu, id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastGetQueryObjecti64vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] Span<long> @params)
            => ImplMulticastGetQueryObject(gpu, id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectui64vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] ulong* @params)
            => ImplMulticastGetQueryObject(gpu, id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="gpu">
        /// To be added.
        /// </param>
        /// <param name="id">
        /// To be added.
        /// </param>
        /// <param name="pname">
        /// To be added.
        /// </param>
        /// <param name="@params">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastGetQueryObjectui64vNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] Span<ulong> @params)
            => ImplMulticastGetQueryObject(gpu, id, pname, @params);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="signalGpu">
        /// To be added.
        /// </param>
        /// <param name="waitGpuMask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glMulticastWaitSyncNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void MulticastWaitSync([Flow(FlowDirection.In)] uint signalGpu, [Flow(FlowDirection.In)] uint waitGpuMask)
            => ImplMulticastWaitSync(signalGpu, waitGpuMask);

        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="mask">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glRenderGpuMaskNV")]
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public void RenderGpuMask([Flow(FlowDirection.In)] uint mask)
            => ImplRenderGpuMask(mask);

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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
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
        [System.Runtime.CompilerServices.MethodImpl((System.Runtime.CompilerServices.MethodImplOptions)(512 | 256))]
        public unsafe void MulticastCopyBufferSubData([Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] int readOffset, [Flow(FlowDirection.In)] int writeOffset, [Flow(FlowDirection.In)] uint size)
        {
            // IntPtrOverloader
            MulticastCopyBufferSubData(readGpu, writeGpuMask, readBuffer, writeBuffer, new IntPtr(readOffset), new IntPtr(writeOffset), new UIntPtr(size));
        }

        public NVGpuMulticast(INativeContext ctx)
            : base(ctx)
        {
            InitializeNative();
        }
    }
}

