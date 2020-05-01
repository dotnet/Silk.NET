// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
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
        public MemExtHostPtr ExtHostPtr;
/// <summary></summary>
        public void* AnbPtr;
    }
}
