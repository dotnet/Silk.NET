// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICGifImageDescriptorProperties")]
    public enum WICGifImageDescriptorProperties : int
    {
        [Obsolete("Deprecated in favour of \"Left\"")]
        [NativeName("Name", "WICGifImageDescriptorLeft")]
        WicgifImageDescriptorLeft = 0x1,
        [Obsolete("Deprecated in favour of \"Top\"")]
        [NativeName("Name", "WICGifImageDescriptorTop")]
        WicgifImageDescriptorTop = 0x2,
        [Obsolete("Deprecated in favour of \"Width\"")]
        [NativeName("Name", "WICGifImageDescriptorWidth")]
        WicgifImageDescriptorWidth = 0x3,
        [Obsolete("Deprecated in favour of \"Height\"")]
        [NativeName("Name", "WICGifImageDescriptorHeight")]
        WicgifImageDescriptorHeight = 0x4,
        [Obsolete("Deprecated in favour of \"LocalColorTableFlag\"")]
        [NativeName("Name", "WICGifImageDescriptorLocalColorTableFlag")]
        WicgifImageDescriptorLocalColorTableFlag = 0x5,
        [Obsolete("Deprecated in favour of \"InterlaceFlag\"")]
        [NativeName("Name", "WICGifImageDescriptorInterlaceFlag")]
        WicgifImageDescriptorInterlaceFlag = 0x6,
        [Obsolete("Deprecated in favour of \"SortFlag\"")]
        [NativeName("Name", "WICGifImageDescriptorSortFlag")]
        WicgifImageDescriptorSortFlag = 0x7,
        [Obsolete("Deprecated in favour of \"LocalColorTableSize\"")]
        [NativeName("Name", "WICGifImageDescriptorLocalColorTableSize")]
        WicgifImageDescriptorLocalColorTableSize = 0x8,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICGifImageDescriptorProperties_FORCE_DWORD")]
        WicgifImageDescriptorPropertiesForceDword = 0x7FFFFFFF,
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
