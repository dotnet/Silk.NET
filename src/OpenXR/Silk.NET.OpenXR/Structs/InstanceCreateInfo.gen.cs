// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrInstanceCreateInfo")]
    public unsafe partial struct InstanceCreateInfo
    {
        public InstanceCreateInfo
        (
            StructureType? type = StructureType.TypeInstanceCreateInfo,
            void* next = null,
            InstanceCreateFlags? createFlags = null,
            ApplicationInfo? applicationInfo = null,
            uint? enabledApiLayerCount = null,
            byte** enabledApiLayerNames = null,
            uint? enabledExtensionCount = null,
            byte** enabledExtensionNames = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (createFlags is not null)
            {
                CreateFlags = createFlags.Value;
            }

            if (applicationInfo is not null)
            {
                ApplicationInfo = applicationInfo.Value;
            }

            if (enabledApiLayerCount is not null)
            {
                EnabledApiLayerCount = enabledApiLayerCount.Value;
            }

            if (enabledApiLayerNames is not null)
            {
                EnabledApiLayerNames = enabledApiLayerNames;
            }

            if (enabledExtensionCount is not null)
            {
                EnabledExtensionCount = enabledExtensionCount.Value;
            }

            if (enabledExtensionNames is not null)
            {
                EnabledExtensionNames = enabledExtensionNames;
            }
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
