// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_mem_android_native_buffer_host_ptr")]
    public unsafe partial struct MemAndroidNativeBufferHostPtr
    {
        public MemAndroidNativeBufferHostPtr
        (
            MemExtHostPtr? extHostPtr = null,
            void* anbPtr = null
        ) : this()
        {
            if (extHostPtr is not null)
            {
                ExtHostPtr = extHostPtr.Value;
            }

            if (anbPtr is not null)
            {
                AnbPtr = anbPtr;
            }
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
