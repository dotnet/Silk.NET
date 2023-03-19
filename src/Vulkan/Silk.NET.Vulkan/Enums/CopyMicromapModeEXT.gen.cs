// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCopyMicromapModeEXT")]
    public enum CopyMicromapModeEXT : int
    {
        [Obsolete("Deprecated in favour of \"CloneExt\"")]
        [NativeName("Name", "VK_COPY_MICROMAP_MODE_CLONE_EXT")]
        CopyMicromapModeCloneExt = 0,
        [Obsolete("Deprecated in favour of \"SerializeExt\"")]
        [NativeName("Name", "VK_COPY_MICROMAP_MODE_SERIALIZE_EXT")]
        CopyMicromapModeSerializeExt = 1,
        [Obsolete("Deprecated in favour of \"DeserializeExt\"")]
        [NativeName("Name", "VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT")]
        CopyMicromapModeDeserializeExt = 2,
        [Obsolete("Deprecated in favour of \"CompactExt\"")]
        [NativeName("Name", "VK_COPY_MICROMAP_MODE_COMPACT_EXT")]
        CopyMicromapModeCompactExt = 3,
        [NativeName("Name", "VK_COPY_MICROMAP_MODE_CLONE_EXT")]
        CloneExt = 0,
        [NativeName("Name", "VK_COPY_MICROMAP_MODE_SERIALIZE_EXT")]
        SerializeExt = 1,
        [NativeName("Name", "VK_COPY_MICROMAP_MODE_DESERIALIZE_EXT")]
        DeserializeExt = 2,
        [NativeName("Name", "VK_COPY_MICROMAP_MODE_COMPACT_EXT")]
        CompactExt = 3,
    }
}
