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
    public unsafe struct ImageFormatListCreateInfo
    {
        public ImageFormatListCreateInfo
        (
            StructureType sType = StructureType.ImageFormatListCreateInfo,
            void* pNext = default,
            uint viewFormatCount = default,
            Format* pViewFormats = default
        )
        {
           SType = sType;
           PNext = pNext;
           ViewFormatCount = viewFormatCount;
           PViewFormats = pViewFormats;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint ViewFormatCount;
/// <summary></summary>
        public Format* PViewFormats;
    }
}
