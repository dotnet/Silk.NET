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

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.QCOM
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
