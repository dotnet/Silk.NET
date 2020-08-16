// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    [Extension("NVX_linked_gpu_multicast")]
    public unsafe partial class NvxLinkedGpuMulticast : NativeExtension<GL>
    {
        public const string ExtensionName = "NVX_linked_gpu_multicast";
        [NativeApi(EntryPoint = "glLGPUCopyImageSubDataNVX")]
        public partial void LgpucopyImageSubData([Flow(FlowDirection.In)] uint sourceGpu, [Flow(FlowDirection.In)] uint destinationGpuMask, [Flow(FlowDirection.In)] uint srcName, [Flow(FlowDirection.In)] NVX srcTarget, [Flow(FlowDirection.In)] int srcLevel, [Flow(FlowDirection.In)] int srcX, [Flow(FlowDirection.In)] int srxY, [Flow(FlowDirection.In)] int srcZ, [Flow(FlowDirection.In)] uint dstName, [Flow(FlowDirection.In)] NVX dstTarget, [Flow(FlowDirection.In)] int dstLevel, [Flow(FlowDirection.In)] int dstX, [Flow(FlowDirection.In)] int dstY, [Flow(FlowDirection.In)] int dstZ, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth);

        [NativeApi(EntryPoint = "glLGPUInterlockNVX")]
        public partial void Lgpuinterlock();

        [NativeApi(EntryPoint = "glLGPUNamedBufferSubDataNVX")]
        public unsafe partial void LgpunamedBufferSubData([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] void* data);

        [NativeApi(EntryPoint = "glLGPUNamedBufferSubDataNVX")]
        public partial void LgpunamedBufferSubData<T0>([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged;

        public unsafe void LgpunamedBufferSubData([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] void* data)
        {
            // IntPtrOverloader
            LgpunamedBufferSubData(gpuMask, buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public unsafe void LgpunamedBufferSubData<T0>([Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] Span<T0> data) where T0 : unmanaged
        {
            // IntPtrOverloader
            LgpunamedBufferSubData(gpuMask, buffer, new IntPtr(offset), new UIntPtr(size), data);
        }

        public NvxLinkedGpuMulticast(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

