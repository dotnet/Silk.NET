// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkExportMemoryWin32HandleInfoKHR")]
    public unsafe partial struct ExportMemoryWin32HandleInfoKHR
    {
        public ExportMemoryWin32HandleInfoKHR
        (
            StructureType sType = StructureType.ExportMemoryWin32HandleInfoKhr,
            void* pNext = default,
            IntPtr* pAttributes = default,
            int dwAccess = default,
            IntPtr name = default
        )
        {
            SType = sType;
            PNext = pNext;
            PAttributes = pAttributes;
            DwAccess = dwAccess;
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
        [NativeName("Type", "SECURITY_ATTRIBUTES*")]
        [NativeName("Type.Name", "SECURITY_ATTRIBUTES")]
        [NativeName("Name", "pAttributes")]
        public IntPtr* PAttributes;
/// <summary></summary>
        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwAccess")]
        public int DwAccess;
/// <summary></summary>
        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "name")]
        public IntPtr Name;
    }
}
