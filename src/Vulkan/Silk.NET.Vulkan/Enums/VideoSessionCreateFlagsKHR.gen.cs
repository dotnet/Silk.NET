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
        [Obsolete("Deprecated in favour of \"AllowEncodeParameterOptimizationsBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_PARAMETER_OPTIMIZATIONS_BIT_KHR")]
        VideoSessionCreateAllowEncodeParameterOptimizationsBitKhr = 2,
        [Obsolete("Deprecated in favour of \"InlineQueriesBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_INLINE_QUERIES_BIT_KHR")]
        VideoSessionCreateInlineQueriesBitKhr = 4,
        [Obsolete("Deprecated in favour of \"AllowEncodeQuantizationDeltaMapBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR")]
        VideoSessionCreateAllowEncodeQuantizationDeltaMapBitKhr = 8,
        [Obsolete("Deprecated in favour of \"AllowEncodeEmphasisMapBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_EMPHASIS_MAP_BIT_KHR")]
        VideoSessionCreateAllowEncodeEmphasisMapBitKhr = 16,
        [Obsolete("Deprecated in favour of \"InlineSessionParametersBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_INLINE_SESSION_PARAMETERS_BIT_KHR")]
        VideoSessionCreateInlineSessionParametersBitKhr = 32,
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_PROTECTED_CONTENT_BIT_KHR")]
        ProtectedContentBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_PARAMETER_OPTIMIZATIONS_BIT_KHR")]
        AllowEncodeParameterOptimizationsBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_INLINE_QUERIES_BIT_KHR")]
        InlineQueriesBitKhr = 4,
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_QUANTIZATION_DELTA_MAP_BIT_KHR")]
        AllowEncodeQuantizationDeltaMapBitKhr = 8,
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_ALLOW_ENCODE_EMPHASIS_MAP_BIT_KHR")]
        AllowEncodeEmphasisMapBitKhr = 16,
        [NativeName("Name", "VK_VIDEO_SESSION_CREATE_INLINE_SESSION_PARAMETERS_BIT_KHR")]
        InlineSessionParametersBitKhr = 32,
    }
}
