// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICGifLogicalScreenDescriptorProperties")]
    public enum GifLogicalScreenDescriptorProperties : int
    {
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
