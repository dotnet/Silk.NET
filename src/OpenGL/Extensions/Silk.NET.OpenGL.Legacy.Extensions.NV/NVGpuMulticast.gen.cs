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
    [Extension("NV_gpu_multicast")]
    public unsafe partial class NVGpuMulticast : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_gpu_multicast";
        [NativeApi(EntryPoint = "glMulticastBarrierNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastBarrier();

        [NativeApi(EntryPoint = "glMulticastBlitFramebufferNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastBlitFramebuffer([Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpu, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] uint mask, [Flow(FlowDirection.In)] NV filter);

        [NativeApi(EntryPoint = "glMulticastBlitFramebufferNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastBlitFramebuffer([Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpu, [Flow(FlowDirection.In)] int srcX0, [Flow(FlowDirection.In)] int srcY0, [Flow(FlowDirection.In)] int srcX1, [Flow(FlowDirection.In)] int srcY1, [Flow(FlowDirection.In)] int dstX0, [Flow(FlowDirection.In)] int dstY0, [Flow(FlowDirection.In)] int dstX1, [Flow(FlowDirection.In)] int dstY1, [Flow(FlowDirection.In)] ClearBufferMask mask, [Flow(FlowDirection.In)] NV filter);

        [NativeApi(EntryPoint = "glMulticastBufferSubDataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastBufferSubData([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glMulticastBufferSubDataNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastBufferSubData<T0>([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] nint offset, [Flow(FlowDirection.In)] nuint size, [Flow(FlowDirection.In)] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMulticastCopyBufferSubDataNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastCopyBufferSubData([Flow(FlowDirection.In)] uint readGpu, [Flow(FlowDirection.In)] uint writeGpuMask, [Flow(FlowDirection.In)] uint readBuffer, [Flow(FlowDirection.In)] uint writeBuffer, [Flow(FlowDirection.In)] nint readOffset, [Flow(FlowDirection.In)] nint writeOffset, [Flow(FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glMulticastCopyImageSubDataNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastCopyImageSubData([Flow(FlowDirection.In)] uint srcGpu, [Flow(FlowDirection.In)] uint dstGpuMask, [Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] NV srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srcY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] NV dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint srcWidth, [Flow(FlowDirection.In)] uint srcHeight, [Flow(FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glMulticastFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastFramebufferSampleLocations([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMulticastFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastFramebufferSampleLocations([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint framebuffer, [Flow(FlowDirection.In)] uint start, [Flow(FlowDirection.In)] uint count, [Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectivNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectuivNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjecti64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjecti64vNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectui64vNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastGetQueryObject([Flow(FlowDirection.In)] uint gpu, [Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glMulticastWaitSyncNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastWaitSync([Flow(FlowDirection.In)] uint signalGpu, [Flow(FlowDirection.In)] uint waitGpuMask);

        [NativeApi(EntryPoint = "glRenderGpuMaskNV", Convention = CallingConvention.Winapi)]
        public partial void RenderGpuMask([Flow(FlowDirection.In)] uint mask);

        public NVGpuMulticast(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

