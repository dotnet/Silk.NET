// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVertexInputRate")]
    public enum VertexInputRate : int
    {
        [NativeName("Name", "")]
        None = 0,
        [NativeName("Name", "VK_VERTEX_INPUT_RATE_VERTEX")]
        Vertex = 0,
        [NativeName("Name", "VK_VERTEX_INPUT_RATE_INSTANCE")]
        Instance = 1,
    }
}
