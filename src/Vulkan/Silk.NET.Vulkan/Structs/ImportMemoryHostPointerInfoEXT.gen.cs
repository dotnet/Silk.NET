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
    public unsafe struct ImportMemoryHostPointerInfoEXT
    {
        public ImportMemoryHostPointerInfoEXT
        (
            StructureType sType = StructureType.ImportMemoryHostPointerInfoExt,
            void* pNext = default,
            ExternalMemoryHandleTypeFlags handleType = default,
            void* pHostPointer = default
        )
        {
           SType = sType;
           PNext = pNext;
           HandleType = handleType;
           PHostPointer = pHostPointer;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ExternalMemoryHandleTypeFlags HandleType;
/// <summary></summary>
        public void* PHostPointer;
    }
}
