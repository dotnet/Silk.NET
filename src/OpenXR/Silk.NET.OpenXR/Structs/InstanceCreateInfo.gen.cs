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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrInstanceCreateInfo")]
    public unsafe partial struct InstanceCreateInfo
    {
        public InstanceCreateInfo
        (
            StructureType type = StructureType.TypeInstanceCreateInfo,
            void* next = default,
            InstanceCreateFlags createFlags = default,
            ApplicationInfo applicationInfo = default,
            uint enabledApiLayerCount = default,
            byte** enabledApiLayerNames = default,
            uint enabledExtensionCount = default,
            byte** enabledExtensionNames = default
        )
        {
            Type = type;
            Next = next;
            CreateFlags = createFlags;
            ApplicationInfo = applicationInfo;
            EnabledApiLayerCount = enabledApiLayerCount;
            EnabledApiLayerNames = enabledApiLayerNames;
            EnabledExtensionCount = enabledExtensionCount;
            EnabledExtensionNames = enabledExtensionNames;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrInstanceCreateFlags")]
        [NativeName("Type.Name", "XrInstanceCreateFlags")]
        [NativeName("Name", "createFlags")]
        public InstanceCreateFlags CreateFlags;
/// <summary></summary>
        [NativeName("Type", "XrApplicationInfo")]
        [NativeName("Type.Name", "XrApplicationInfo")]
        [NativeName("Name", "applicationInfo")]
        public ApplicationInfo ApplicationInfo;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "enabledApiLayerCount")]
        public uint EnabledApiLayerCount;
/// <summary></summary>
        [NativeName("Type", "char**")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "enabledApiLayerNames")]
        public byte** EnabledApiLayerNames;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "enabledExtensionCount")]
        public uint EnabledExtensionCount;
/// <summary></summary>
        [NativeName("Type", "char**")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "enabledExtensionNames")]
        public byte** EnabledExtensionNames;
    }
}
