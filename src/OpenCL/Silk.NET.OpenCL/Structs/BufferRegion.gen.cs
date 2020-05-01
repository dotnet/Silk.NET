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
    public unsafe struct BufferRegion
    {
        public BufferRegion
        (
            UIntPtr origin = default,
            UIntPtr size = default
        )
        {
           Origin = origin;
           Size = size;
        }

/// <summary></summary>
        public UIntPtr Origin;
/// <summary></summary>
        public UIntPtr Size;
    }
}
