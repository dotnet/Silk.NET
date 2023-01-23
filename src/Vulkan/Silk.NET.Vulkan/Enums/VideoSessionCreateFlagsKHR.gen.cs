// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoSessionCreateFlagsKHR")]
    public enum VideoSessionCreateFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"ProtectedContentBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR")]
        VideoSessionCreateProtectedContentBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR")]
        ProtectedContentBitKhr = 1,
    }
}
