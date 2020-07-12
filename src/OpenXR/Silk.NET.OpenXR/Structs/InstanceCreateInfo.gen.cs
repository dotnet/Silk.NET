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

namespace Silk.NET.OpenXR
{
    public unsafe struct InstanceCreateInfo
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public InstanceCreateFlags CreateFlags;
/// <summary></summary>
        public ApplicationInfo ApplicationInfo;
/// <summary></summary>
        public uint EnabledApiLayerCount;
/// <summary></summary>
        public byte** EnabledApiLayerNames;
/// <summary></summary>
        public uint EnabledExtensionCount;
/// <summary></summary>
        public byte** EnabledExtensionNames;
    }
}
