// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICGifImageDescriptorProperties")]
    public enum GifImageDescriptorProperties : int
    {
        [NativeName("Name", "WICGifImageDescriptorLeft")]
        Left = 0x1,
        [NativeName("Name", "WICGifImageDescriptorTop")]
        Top = 0x2,
        [NativeName("Name", "WICGifImageDescriptorWidth")]
        Width = 0x3,
        [NativeName("Name", "WICGifImageDescriptorHeight")]
        Height = 0x4,
        [NativeName("Name", "WICGifImageDescriptorLocalColorTableFlag")]
        LocalColorTableFlag = 0x5,
        [NativeName("Name", "WICGifImageDescriptorInterlaceFlag")]
        InterlaceFlag = 0x6,
        [NativeName("Name", "WICGifImageDescriptorSortFlag")]
        SortFlag = 0x7,
        [NativeName("Name", "WICGifImageDescriptorLocalColorTableSize")]
        LocalColorTableSize = 0x8,
        [NativeName("Name", "WICGifImageDescriptorProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
