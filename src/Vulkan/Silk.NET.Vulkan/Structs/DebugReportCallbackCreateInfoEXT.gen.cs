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
    [NativeName("Name", "VkDebugReportCallbackCreateInfoEXT")]
    public unsafe partial struct DebugReportCallbackCreateInfoEXT
    {
        public DebugReportCallbackCreateInfoEXT
        (
            StructureType sType = StructureType.DebugReportCallbackCreateInfoExt,
            void* pNext = default,
            DebugReportFlagsEXT flags = default,
            FuncPtr pfnCallback = default,
            void* pUserData = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            PfnCallback = pfnCallback;
            PUserData = pUserData;
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
        [NativeName("Type", "VkDebugReportFlagsEXT")]
        [NativeName("Type.Name", "VkDebugReportFlagsEXT")]
        [NativeName("Name", "flags")]
        public DebugReportFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "PFN_vkDebugReportCallbackEXT")]
        [NativeName("Type.Name", "PFN_vkDebugReportCallbackEXT")]
        [NativeName("Name", "pfnCallback")]
        public FuncPtr PfnCallback;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pUserData")]
        public void* PUserData;
    }
}
