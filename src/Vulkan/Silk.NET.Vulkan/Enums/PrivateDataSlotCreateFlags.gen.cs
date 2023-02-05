// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkPrivateDataSlotCreateFlags")]
    public enum PrivateDataSlotCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Reserved0BitNV\"")]
        [NativeName("Name", "VK_PRIVATE_DATA_SLOT_CREATE_RESERVED_0_BIT_NV")]
        PrivateDataSlotCreateReserved0BitNV = 1,
        [NativeName("Name", "VK_PRIVATE_DATA_SLOT_CREATE_RESERVED_0_BIT_NV")]
        Reserved0BitNV = 1,
    }
}
