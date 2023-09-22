// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICGifLogicalScreenDescriptorProperties")]
    public enum WICGifLogicalScreenDescriptorProperties : int
    {
        [Obsolete("Deprecated in favour of \"Signature\"")]
        [NativeName("Name", "WICGifLogicalScreenSignature")]
        WicgifLogicalScreenSignature = 0x1,
        [Obsolete("Deprecated in favour of \"DescriptorWidth\"")]
        [NativeName("Name", "WICGifLogicalScreenDescriptorWidth")]
        WicgifLogicalScreenDescriptorWidth = 0x2,
        [Obsolete("Deprecated in favour of \"DescriptorHeight\"")]
        [NativeName("Name", "WICGifLogicalScreenDescriptorHeight")]
        WicgifLogicalScreenDescriptorHeight = 0x3,
        [Obsolete("Deprecated in favour of \"DescriptorGlobalColorTableFlag\"")]
        [NativeName("Name", "WICGifLogicalScreenDescriptorGlobalColorTableFlag")]
        WicgifLogicalScreenDescriptorGlobalColorTableFlag = 0x4,
        [Obsolete("Deprecated in favour of \"DescriptorColorResolution\"")]
        [NativeName("Name", "WICGifLogicalScreenDescriptorColorResolution")]
        WicgifLogicalScreenDescriptorColorResolution = 0x5,
        [Obsolete("Deprecated in favour of \"DescriptorSortFlag\"")]
        [NativeName("Name", "WICGifLogicalScreenDescriptorSortFlag")]
        WicgifLogicalScreenDescriptorSortFlag = 0x6,
        [Obsolete("Deprecated in favour of \"DescriptorGlobalColorTableSize\"")]
        [NativeName("Name", "WICGifLogicalScreenDescriptorGlobalColorTableSize")]
        WicgifLogicalScreenDescriptorGlobalColorTableSize = 0x7,
        [Obsolete("Deprecated in favour of \"DescriptorBackgroundColorIndex\"")]
        [NativeName("Name", "WICGifLogicalScreenDescriptorBackgroundColorIndex")]
        WicgifLogicalScreenDescriptorBackgroundColorIndex = 0x8,
        [Obsolete("Deprecated in favour of \"DescriptorPixelAspectRatio\"")]
        [NativeName("Name", "WICGifLogicalScreenDescriptorPixelAspectRatio")]
        WicgifLogicalScreenDescriptorPixelAspectRatio = 0x9,
        [Obsolete("Deprecated in favour of \"DescriptorPropertiesForceDword\"")]
        [NativeName("Name", "WICGifLogicalScreenDescriptorProperties_FORCE_DWORD")]
        WicgifLogicalScreenDescriptorPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICGifLogicalScreenSignature")]
        Signature = 0x1,
        [NativeName("Name", "WICGifLogicalScreenDescriptorWidth")]
        DescriptorWidth = 0x2,
        [NativeName("Name", "WICGifLogicalScreenDescriptorHeight")]
        DescriptorHeight = 0x3,
        [NativeName("Name", "WICGifLogicalScreenDescriptorGlobalColorTableFlag")]
        DescriptorGlobalColorTableFlag = 0x4,
        [NativeName("Name", "WICGifLogicalScreenDescriptorColorResolution")]
        DescriptorColorResolution = 0x5,
        [NativeName("Name", "WICGifLogicalScreenDescriptorSortFlag")]
        DescriptorSortFlag = 0x6,
        [NativeName("Name", "WICGifLogicalScreenDescriptorGlobalColorTableSize")]
        DescriptorGlobalColorTableSize = 0x7,
        [NativeName("Name", "WICGifLogicalScreenDescriptorBackgroundColorIndex")]
        DescriptorBackgroundColorIndex = 0x8,
        [NativeName("Name", "WICGifLogicalScreenDescriptorPixelAspectRatio")]
        DescriptorPixelAspectRatio = 0x9,
        [NativeName("Name", "WICGifLogicalScreenDescriptorProperties_FORCE_DWORD")]
        DescriptorPropertiesForceDword = 0x7FFFFFFF,
    }
}
