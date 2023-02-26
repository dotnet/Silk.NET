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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkRefreshObjectKHR")]
    public unsafe partial struct RefreshObjectKHR
    {
        public RefreshObjectKHR
        (
            ObjectType? objectType = null,
            ulong? objectHandle = null,
            RefreshObjectFlagsKHR? flags = null
        ) : this()
        {
            if (objectType is not null)
            {
                ObjectType = objectType.Value;
            }

            if (objectHandle is not null)
            {
                ObjectHandle = objectHandle.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkObjectType")]
        [NativeName("Type.Name", "VkObjectType")]
        [NativeName("Name", "objectType")]
        public ObjectType ObjectType;
/// <summary></summary>
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "objectHandle")]
        public ulong ObjectHandle;
/// <summary></summary>
        [NativeName("Type", "VkRefreshObjectFlagsKHR")]
        [NativeName("Type.Name", "VkRefreshObjectFlagsKHR")]
        [NativeName("Name", "flags")]
        public RefreshObjectFlagsKHR Flags;
    }
}
