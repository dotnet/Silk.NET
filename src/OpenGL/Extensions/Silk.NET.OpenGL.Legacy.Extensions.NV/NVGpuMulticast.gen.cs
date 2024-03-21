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
        public partial void MulticastBlitFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV filter);

        [NativeApi(EntryPoint = "glMulticastBlitFramebufferNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastBlitFramebuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY0, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY1, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ClearBufferMask mask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV filter);

        [NativeApi(EntryPoint = "glMulticastBufferSubDataNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glMulticastBufferSubDataNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glMulticastCopyBufferSubDataNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastCopyBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint writeGpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint writeBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size);

        [NativeApi(EntryPoint = "glMulticastCopyImageSubDataNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastCopyImageSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstGpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV srcTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV dstTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcDepth);

        [NativeApi(EntryPoint = "glMulticastFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastFramebufferSampleLocations([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMulticastFramebufferSampleLocationsfvNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastFramebufferSampleLocations([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint framebuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint start, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float v);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastGetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectivNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastGetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectuivNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastGetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] uint* @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectuivNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastGetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out uint @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjecti64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastGetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] long* @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjecti64vNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastGetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out long @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectui64vNV", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastGetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] ulong* @params);

        [NativeApi(EntryPoint = "glMulticastGetQueryObjectui64vNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastGetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname, [Flow(Silk.NET.Core.Native.FlowDirection.Out)] out ulong @params);

        [NativeApi(EntryPoint = "glMulticastWaitSyncNV", Convention = CallingConvention.Winapi)]
        public partial void MulticastWaitSync([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint signalGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint waitGpuMask);

        [NativeApi(EntryPoint = "glRenderGpuMaskNV", Convention = CallingConvention.Winapi)]
        public partial void RenderGpuMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        public unsafe int MulticastGetQueryObject([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint id, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NV pname)
        {
            // NonKhrReturnTypeOverloader
            MulticastGetQueryObject(gpu, id, pname, out int silkRet);
            return silkRet;
        }

        public NVGpuMulticast(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

