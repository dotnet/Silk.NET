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
    public unsafe struct ImagePipeSurfaceCreateInfoFUCHSIA
    {
        public ImagePipeSurfaceCreateInfoFUCHSIA
        (
            StructureType sType = StructureType.ImagepipeSurfaceCreateInfoFuchsia,
            void* pNext = default,
            uint flags = default,
            IntPtr imagePipeHandle = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           ImagePipeHandle = imagePipeHandle;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public IntPtr ImagePipeHandle;
    }
}
