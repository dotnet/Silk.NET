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
    [NativeName("Name", "VkImportFenceWin32HandleInfoKHR")]
    public unsafe partial struct ImportFenceWin32HandleInfoKHR
    {
        public ImportFenceWin32HandleInfoKHR
        (
            StructureType sType = StructureType.ImportFenceWin32HandleInfoKhr,
            void* pNext = default,
            Fence fence = default,
            FenceImportFlags flags = default,
            ExternalFenceHandleTypeFlags handleType = default,
            IntPtr handle = default,
            IntPtr name = default
        )
        {
            SType = sType;
            PNext = pNext;
            Fence = fence;
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
        [NativeName("Type", "VkFence")]
        [NativeName("Type.Name", "VkFence")]
        [NativeName("Name", "fence")]
        public Fence Fence;
/// <summary></summary>
        [NativeName("Type", "VkFenceImportFlags")]
        [NativeName("Type.Name", "VkFenceImportFlags")]
        [NativeName("Name", "flags")]
        public FenceImportFlags Flags;
/// <summary></summary>
        [NativeName("Type", "VkExternalFenceHandleTypeFlagBits")]
        [NativeName("Type.Name", "VkExternalFenceHandleTypeFlagBits")]
        [NativeName("Name", "handleType")]
        public ExternalFenceHandleTypeFlags HandleType;
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
