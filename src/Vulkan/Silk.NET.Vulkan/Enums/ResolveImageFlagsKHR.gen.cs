// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkResolveImageFlagsKHR")]
    public enum ResolveImageFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"SkipTransferFunctionBitKhr\"")]
        [NativeName("Name", "VK_RESOLVE_IMAGE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
        ResolveImageSkipTransferFunctionBitKhr = 1,
        [Obsolete("Deprecated in favour of \"EnableTransferFunctionBitKhr\"")]
        [NativeName("Name", "VK_RESOLVE_IMAGE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
        ResolveImageEnableTransferFunctionBitKhr = 2,
        [NativeName("Name", "VK_RESOLVE_IMAGE_SKIP_TRANSFER_FUNCTION_BIT_KHR")]
        SkipTransferFunctionBitKhr = 1,
        [NativeName("Name", "VK_RESOLVE_IMAGE_ENABLE_TRANSFER_FUNCTION_BIT_KHR")]
        EnableTransferFunctionBitKhr = 2,
    }
}
