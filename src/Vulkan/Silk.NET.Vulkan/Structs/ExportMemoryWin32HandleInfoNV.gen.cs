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
    public unsafe struct ExportMemoryWin32HandleInfoNV
    {
        public ExportMemoryWin32HandleInfoNV
        (
            StructureType sType = StructureType.ExportMemoryWin32HandleInfoNV,
            void* pNext = default,
            IntPtr* pAttributes = default,
            int dwAccess = default
        )
        {
           SType = sType;
           PNext = pNext;
           PAttributes = pAttributes;
           DwAccess = dwAccess;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public IntPtr* PAttributes;
/// <summary></summary>
        public int DwAccess;
    }
}
