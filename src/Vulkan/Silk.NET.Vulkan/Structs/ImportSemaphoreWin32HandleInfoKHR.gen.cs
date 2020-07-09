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
    [NativeName("Name", "VkImportSemaphoreWin32HandleInfoKHR")]
    public unsafe struct ImportSemaphoreWin32HandleInfoKHR
    {
        public ImportSemaphoreWin32HandleInfoKHR
        (
            StructureType sType = StructureType.ImportSemaphoreWin32HandleInfoKhr,
            void* pNext = default,
            Semaphore semaphore = default,
            SemaphoreImportFlags flags = default,
            ExternalSemaphoreHandleTypeFlags handleType = default,
            IntPtr handle = default,
            IntPtr name = default
        )
        {
           SType = sType;
           PNext = pNext;
           Semaphore = semaphore;
           Flags = flags;
           HandleType = handleType;
           Handle = handle;
           Name = name;
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
        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "handle")]
        public IntPtr Handle;
/// <summary></summary>
        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "name")]
        public IntPtr Name;
    }
}
