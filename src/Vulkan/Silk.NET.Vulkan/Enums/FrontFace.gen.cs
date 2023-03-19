// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkFrontFace")]
    public enum FrontFace : int
    {
        [NativeName("Name", "VK_FRONT_FACE_COUNTER_CLOCKWISE")]
        CounterClockwise = 0,
        [NativeName("Name", "VK_FRONT_FACE_CLOCKWISE")]
        Clockwise = 1,
    }
}
