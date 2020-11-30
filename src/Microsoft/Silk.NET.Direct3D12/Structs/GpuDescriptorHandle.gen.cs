// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_GPU_DESCRIPTOR_HANDLE")]
    public unsafe partial struct GpuDescriptorHandle
    {
        public GpuDescriptorHandle
        (
            ulong? ptr = null
        ) : this()
        {
            if (ptr is not null)
            {
                Ptr = ptr.Value;
            }
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "ptr")]
        public ulong Ptr;
    }
}
