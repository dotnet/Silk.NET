// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkProvokingVertexModeEXT")]
    public enum ProvokingVertexModeEXT : int
    {
        [Obsolete("Deprecated in favour of \"FirstVertexExt\"")]
        [NativeName("Name", "VK_PROVOKING_VERTEX_MODE_FIRST_VERTEX_EXT")]
        ProvokingVertexModeFirstVertexExt = 0,
        [Obsolete("Deprecated in favour of \"LastVertexExt\"")]
        [NativeName("Name", "VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXT")]
        ProvokingVertexModeLastVertexExt = 1,
        [NativeName("Name", "VK_PROVOKING_VERTEX_MODE_FIRST_VERTEX_EXT")]
        FirstVertexExt = 0,
        [NativeName("Name", "VK_PROVOKING_VERTEX_MODE_LAST_VERTEX_EXT")]
        LastVertexExt = 1,
    }
}
