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
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"CpuReadRarelyFuchsia\"")]
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_RARELY_FUCHSIA")]
        ImageConstraintsInfoCpuReadRarelyFuchsia = 1,
        [Obsolete("Deprecated in favour of \"CpuReadOftenFuchsia\"")]
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_OFTEN_FUCHSIA")]
        ImageConstraintsInfoCpuReadOftenFuchsia = 2,
        [Obsolete("Deprecated in favour of \"CpuWriteRarelyFuchsia\"")]
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_RARELY_FUCHSIA")]
        ImageConstraintsInfoCpuWriteRarelyFuchsia = 4,
        [Obsolete("Deprecated in favour of \"CpuWriteOftenFuchsia\"")]
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_OFTEN_FUCHSIA")]
        ImageConstraintsInfoCpuWriteOftenFuchsia = 8,
        [Obsolete("Deprecated in favour of \"ProtectedOptionalFuchsia\"")]
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_PROTECTED_OPTIONAL_FUCHSIA")]
        ImageConstraintsInfoProtectedOptionalFuchsia = 16,
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_RARELY_FUCHSIA")]
        CpuReadRarelyFuchsia = 1,
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_READ_OFTEN_FUCHSIA")]
        CpuReadOftenFuchsia = 2,
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_RARELY_FUCHSIA")]
        CpuWriteRarelyFuchsia = 4,
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_CPU_WRITE_OFTEN_FUCHSIA")]
        CpuWriteOftenFuchsia = 8,
        [NativeName("Name", "VK_IMAGE_CONSTRAINTS_INFO_PROTECTED_OPTIONAL_FUCHSIA")]
        ProtectedOptionalFuchsia = 16,
    }
}
