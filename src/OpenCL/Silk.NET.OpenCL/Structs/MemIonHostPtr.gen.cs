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
    [NativeName("Name", "cl_mem_ion_host_ptr")]
    public unsafe partial struct MemIonHostPtr
    {
        public MemIonHostPtr
        (
            MemExtHostPtr? extHostPtr = null,
            int? ionFiledesc = null,
            void* ionHostptr = null
        ) : this()
        {
            if (extHostPtr is not null)
            {
                ExtHostPtr = extHostPtr.Value;
            }

            if (ionFiledesc is not null)
            {
                IonFiledesc = ionFiledesc.Value;
            }

            if (ionHostptr is not null)
            {
                IonHostptr = ionHostptr;
            }
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
