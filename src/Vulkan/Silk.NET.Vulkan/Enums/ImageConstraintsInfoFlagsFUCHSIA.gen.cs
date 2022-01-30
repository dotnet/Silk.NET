// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkImageConstraintsInfoFlagsFUCHSIA")]
    public enum ImageConstraintsInfoFlagsFUCHSIA : int
    {
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_RARELY_FUCHSIA")]
        ImageConstraintsInfoCpuReadRarelyFuchsia = 1,
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_OFTEN_FUCHSIA")]
        ImageConstraintsInfoCpuReadOftenFuchsia = 2,
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_RARELY_FUCHSIA")]
        ImageConstraintsInfoCpuWriteRarelyFuchsia = 4,
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_OFTEN_FUCHSIA")]
        ImageConstraintsInfoCpuWriteOftenFuchsia = 8,
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_PROTECTED_OPTIONAL_FUCHSIA")]
        ImageConstraintsInfoProtectedOptionalFuchsia = 16,
    }
}
