// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkLayeredDriverUnderlyingApiMSFT")]
    public enum LayeredDriverUnderlyingApiMSFT : int
    {
        [Obsolete("Deprecated in favour of \"NoneMsft\"")]
        [NativeName("Name", "VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT")]
        LayeredDriverUnderlyingApiNoneMsft = 0,
        [Obsolete("Deprecated in favour of \"D3D12Msft\"")]
        [NativeName("Name", "VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT")]
        LayeredDriverUnderlyingApiD3D12Msft = 1,
        [NativeName("Name", "VK_LAYERED_DRIVER_UNDERLYING_API_NONE_MSFT")]
        NoneMsft = 0,
        [NativeName("Name", "VK_LAYERED_DRIVER_UNDERLYING_API_D3D12_MSFT")]
        D3D12Msft = 1,
    }
}
