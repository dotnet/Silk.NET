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
    public unsafe struct DisplayModeProperties2KHR
    {
        public DisplayModeProperties2KHR
        (
            StructureType sType = StructureType.DisplayModeProperties2Khr,
            void* pNext = default,
            DisplayModePropertiesKHR displayModeProperties = default
        )
        {
           SType = sType;
           PNext = pNext;
           DisplayModeProperties = displayModeProperties;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DisplayModePropertiesKHR DisplayModeProperties;
    }
}
