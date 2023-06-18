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

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_gpu_multicast2")]
    public unsafe partial class NvxGpuMulticast2 : NativeExtension<GL>
    {
        public const string ExtensionName = "NVX_gpu_multicast2";
        [NativeApi(EntryPoint = "glAsyncCopyBufferSubDataNVX", Convention = CallingConvention.Winapi)]
        public unsafe partial uint AsyncCopyBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* fenceValueArray, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint writeGpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint readBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint writeBuffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint readOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint writeOffset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* signalValueArray);

        [NativeApi(EntryPoint = "glAsyncCopyImageSubDataNVX", Convention = CallingConvention.Winapi)]
        public unsafe partial uint AsyncCopyImageSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint waitSemaphoreCount, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* waitSemaphoreArray, [Count(Parameter = "waitSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* waitValueArray, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstGpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NVX srcTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NVX dstTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcHeight, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcDepth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint signalSemaphoreCount, [Count(Parameter = "signalSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] uint* signalSemaphoreArray, [Count(Parameter = "signalSemaphoreCount"), Flow(Silk.NET.Core.Native.FlowDirection.In)] ulong* signalValueArray);

        [NativeApi(EntryPoint = "glMulticastScissorArrayvNVX", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastScissorArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] int* v);

        [NativeApi(EntryPoint = "glMulticastViewportArrayvNVX", Convention = CallingConvention.Winapi)]
        public unsafe partial void MulticastViewportArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint first, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint count, [Count(Computed = "count"), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glMulticastViewportPositionWScaleNVX", Convention = CallingConvention.Winapi)]
        public partial void MulticastViewportPositionWScale([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float xcoeff, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float ycoeff);

        [NativeApi(EntryPoint = "glUploadGpuMaskNVX", Convention = CallingConvention.Winapi)]
        public partial void UploadGpuMask([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint mask);

        public NvxGpuMulticast2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

