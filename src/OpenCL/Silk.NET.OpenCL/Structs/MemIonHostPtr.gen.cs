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
    [NativeName("Name", "cl_mem_ion_host_ptr")]
    public unsafe struct MemIonHostPtr
    {
        public MemIonHostPtr
        (
            MemExtHostPtr extHostPtr = default,
            int ionFiledesc = default,
            void* ionHostptr = default
        )
        {
           ExtHostPtr = extHostPtr;
           IonFiledesc = ionFiledesc;
           IonHostptr = ionHostptr;
        }

/// <summary></summary>
        [NativeName("Type", "cl_mem_ext_host_ptr")]
        [NativeName("Type.Name", "cl_mem_ext_host_ptr")]
        [NativeName("Name", "ext_host_ptr")]
        public MemExtHostPtr ExtHostPtr;
/// <summary></summary>
        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "ion_filedesc")]
        public int IonFiledesc;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "ion_hostptr")]
        public void* IonHostptr;
    }
}
