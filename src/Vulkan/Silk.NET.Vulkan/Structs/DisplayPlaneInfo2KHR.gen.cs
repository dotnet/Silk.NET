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
    public unsafe struct DisplayPlaneInfo2KHR
    {
        public DisplayPlaneInfo2KHR
        (
            StructureType sType = StructureType.DisplayPlaneInfo2Khr,
            void* pNext = default,
            DisplayModeKHR mode = default,
            uint planeIndex = default
        )
        {
           SType = sType;
           PNext = pNext;
           Mode = mode;
           PlaneIndex = planeIndex;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DisplayModeKHR Mode;
/// <summary></summary>
        public uint PlaneIndex;
    }
}
