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
    [Extension("NVX_linked_gpu_multicast")]
    public unsafe partial class NvxLinkedGpuMulticast : NativeExtension<GL>
    {
        public const string ExtensionName = "NVX_linked_gpu_multicast";
        [NativeApi(EntryPoint = "glLGPUCopyImageSubDataNVX", Convention = CallingConvention.Winapi)]
        public partial void LgpucopyImageSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint sourceGpu, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint destinationGpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint srcName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NVX srcTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srxY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int srcZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint dstName, [Flow(Silk.NET.Core.Native.FlowDirection.In)] NVX dstTarget, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstLevel, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstX, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstY, [Flow(Silk.NET.Core.Native.FlowDirection.In)] int dstZ, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint width, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint height, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glLGPUInterlockNVX", Convention = CallingConvention.Winapi)]
        public partial void Lgpuinterlock();

        [NativeApi(EntryPoint = "glLGPUNamedBufferSubDataNVX", Convention = CallingConvention.Winapi)]
        public unsafe partial void LgpunamedBufferSubData([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glLGPUNamedBufferSubDataNVX", Convention = CallingConvention.Winapi)]
        public partial void LgpunamedBufferSubData<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint gpuMask, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint buffer, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nint offset, [Flow(Silk.NET.Core.Native.FlowDirection.In)] nuint size, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 data) where T0 : unmanaged;

        public NvxLinkedGpuMulticast(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

