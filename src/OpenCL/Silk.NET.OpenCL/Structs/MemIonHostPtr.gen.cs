// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenCL
{
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
        public MemExtHostPtr ExtHostPtr;
/// <summary></summary>
        public int IonFiledesc;
/// <summary></summary>
        public void* IonHostptr;
    }
}
