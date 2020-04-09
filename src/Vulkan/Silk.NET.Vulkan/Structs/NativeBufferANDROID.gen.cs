// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
    public unsafe struct NativeBufferANDROID
    {
        public NativeBufferANDROID
        (
            StructureType sType = StructureType.NativeBufferAndroid,
            void* pNext = default,
            void* handle = default,
            int stride = default,
            int format = default,
            int usage = default,
            NativeBufferUsage2ANDROID usage2 = default
        )
        {
           SType = sType;
           PNext = pNext;
           Handle = handle;
           Stride = stride;
           Format = format;
           Usage = usage;
           Usage2 = usage2;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public void* Handle;
/// <summary></summary>
        public int Stride;
/// <summary></summary>
        public int Format;
/// <summary></summary>
        public int Usage;
/// <summary></summary>
        public NativeBufferUsage2ANDROID Usage2;
    }
}
