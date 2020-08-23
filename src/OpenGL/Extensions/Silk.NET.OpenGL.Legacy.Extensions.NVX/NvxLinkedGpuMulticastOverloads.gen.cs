// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NVX
{
    public static class NvxLinkedGpuMulticastOverloads
    {
        public static unsafe void LgpunamedBufferSubData<T0>(this NvxLinkedGpuMulticast thisApi, [Flow(FlowDirection.In)] uint gpuMask, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] ReadOnlySpan<T0> data) where T0 : unmanaged
        {
            // SpanOverloader
            thisApi.LgpunamedBufferSubData(gpuMask, buffer, offset, size, in data.GetPinnableReference());
        }

    }
}

