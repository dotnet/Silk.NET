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
    [NativeName("Name", "VkApplicationInfo")]
    public unsafe partial struct ApplicationInfo
    {
        public ApplicationInfo
        (
            StructureType sType = StructureType.ApplicationInfo,
            void* pNext = default,
            byte* pApplicationName = default,
            uint applicationVersion = default,
            byte* pEngineName = default,
            uint engineVersion = default,
            uint apiVersion = default
        )
        {
            SType = sType;
            PNext = pNext;
            PApplicationName = pApplicationName;
            ApplicationVersion = applicationVersion;
            PEngineName = pEngineName;
            EngineVersion = engineVersion;
            ApiVersion = apiVersion;
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
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pApplicationName")]
        public byte* PApplicationName;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "applicationVersion")]
        public uint ApplicationVersion;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pEngineName")]
        public byte* PEngineName;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "engineVersion")]
        public uint EngineVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "apiVersion")]
        public uint ApiVersion;
    }
}
