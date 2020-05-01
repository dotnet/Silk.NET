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
    public unsafe struct ImportMemoryWin32HandleInfoKHR
    {
        public ImportMemoryWin32HandleInfoKHR
        (
            StructureType sType = StructureType.ImportMemoryWin32HandleInfoKhr,
            void* pNext = default,
            ExternalMemoryHandleTypeFlags handleType = default,
            IntPtr handle = default,
            IntPtr name = default
        )
        {
           SType = sType;
           PNext = pNext;
           HandleType = handleType;
           Handle = handle;
           Name = name;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public ExternalMemoryHandleTypeFlags HandleType;
/// <summary></summary>
        public IntPtr Handle;
/// <summary></summary>
        public IntPtr Name;
    }
}
