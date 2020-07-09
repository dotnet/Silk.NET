// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkImportMemoryWin32HandleInfoNV")]
    public unsafe struct ImportMemoryWin32HandleInfoNV
    {
        public ImportMemoryWin32HandleInfoNV
        (
            StructureType sType = StructureType.ImportMemoryWin32HandleInfoNV,
            void* pNext = default,
            ExternalMemoryHandleTypeFlagsNV handleType = default,
            IntPtr handle = default
        )
        {
           SType = sType;
           PNext = pNext;
           HandleType = handleType;
           Handle = handle;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkExternalMemoryHandleTypeFlagsNV")]
        [NativeName("Type.Name", "VkExternalMemoryHandleTypeFlagsNV")]
        [NativeName("Name", "handleType")]
        public ExternalMemoryHandleTypeFlagsNV HandleType;
/// <summary></summary>
        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "handle")]
        public IntPtr Handle;
    }
}
