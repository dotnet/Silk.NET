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

namespace Silk.NET.Vulkan
{
    public unsafe struct SurfaceFullScreenExclusiveWin32InfoEXT
    {
        public SurfaceFullScreenExclusiveWin32InfoEXT
        (
            StructureType sType = StructureType.SurfaceFullScreenExclusiveWin32InfoExt,
            void* pNext = default,
            IntPtr hmonitor = default
        )
        {
           SType = sType;
           PNext = pNext;
           Hmonitor = hmonitor;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public IntPtr Hmonitor;
    }
}
