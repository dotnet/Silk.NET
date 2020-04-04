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
    public unsafe struct MultisamplePropertiesEXT
    {
        public MultisamplePropertiesEXT
        (
            StructureType sType = StructureType.MultisamplePropertiesExt,
            void* pNext = default,
            Extent2D maxSampleLocationGridSize = default
        )
        {
           SType = sType;
           PNext = pNext;
           MaxSampleLocationGridSize = maxSampleLocationGridSize;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Extent2D MaxSampleLocationGridSize;
    }
}
