// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mem_android_native_buffer_host_ptr")]
    public unsafe struct MemAndroidNativeBufferHostPtr
    {
        public MemAndroidNativeBufferHostPtr
        (
            MemExtHostPtr extHostPtr = default,
            void* anbPtr = default
        )
        {
           ExtHostPtr = extHostPtr;
           AnbPtr = anbPtr;
        }

/// <summary></summary>
        [NativeName("Type", "cl_mem_ext_host_ptr")]
        [NativeName("Type.Name", "cl_mem_ext_host_ptr")]
        [NativeName("Name", "ext_host_ptr")]
        public MemExtHostPtr ExtHostPtr;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "anb_ptr")]
        public void* AnbPtr;
    }
}
