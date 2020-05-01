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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public Semaphore Semaphore;
/// <summary></summary>
        public SemaphoreImportFlags Flags;
/// <summary></summary>
        public ExternalSemaphoreHandleTypeFlags HandleType;
/// <summary></summary>
        public int Fd;
    }
}
