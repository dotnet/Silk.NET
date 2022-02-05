// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkSubmitFlagsKHR")]
    public enum SubmitFlagsKHR : int
    {
        [NativeName("Name", "VK_SUBMIT_PROTECTED_BIT_KHR")]
        SubmitProtectedBitKhr = 1,
    }
}
