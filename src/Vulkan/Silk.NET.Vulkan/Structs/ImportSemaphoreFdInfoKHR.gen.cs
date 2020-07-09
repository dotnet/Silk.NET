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
    [NativeName("Name", "VkImportSemaphoreFdInfoKHR")]
    public unsafe struct ImportSemaphoreFdInfoKHR
    {
        public ImportSemaphoreFdInfoKHR
        (
            StructureType sType = StructureType.ImportSemaphoreFDInfoKhr,
            void* pNext = default,
            Semaphore semaphore = default,
            SemaphoreImportFlags flags = default,
            ExternalSemaphoreHandleTypeFlags handleType = default,
            int fd = default
        )
        {
           SType = sType;
           PNext = pNext;
           Semaphore = semaphore;
           Flags = flags;
           HandleType = handleType;
           Fd = fd;
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
        [NativeName("Type", "VkSemaphore")]
        [NativeName("Type.Name", "VkSemaphore")]
        [NativeName("Name", "semaphore")]
        public Semaphore Semaphore;
/// <summary></summary>
        [NativeName("Type", "VkSemaphoreImportFlags")]
        [NativeName("Type.Name", "VkSemaphoreImportFlags")]
        [NativeName("Name", "flags")]
        public SemaphoreImportFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkExternalSemaphoreHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalSemaphoreHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalSemaphoreHandleTypeFlags HandleType;
/// <summary></summary>
        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "fd")]
        public int Fd;
    }
}
