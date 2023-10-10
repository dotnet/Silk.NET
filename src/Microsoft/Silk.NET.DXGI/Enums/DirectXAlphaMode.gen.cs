// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DirectXAlphaMode")]
    public enum DirectXAlphaMode : int
    {
        [Obsolete("Deprecated in favour of \"Unspecified\"")]
        [NativeName("Name", "DirectXAlphaMode_Unspecified")]
        DirectXAlphaModeUnspecified = 0x0,
        [Obsolete("Deprecated in favour of \"Premultiplied\"")]
        [NativeName("Name", "DirectXAlphaMode_Premultiplied")]
        DirectXAlphaModePremultiplied = 0x1,
        [Obsolete("Deprecated in favour of \"Straight\"")]
        [NativeName("Name", "DirectXAlphaMode_Straight")]
        DirectXAlphaModeStraight = 0x2,
        [Obsolete("Deprecated in favour of \"Ignore\"")]
        [NativeName("Name", "DirectXAlphaMode_Ignore")]
        DirectXAlphaModeIgnore = 0x3,
        [NativeName("Name", "DirectXAlphaMode_Unspecified")]
        Unspecified = 0x0,
        [NativeName("Name", "DirectXAlphaMode_Premultiplied")]
        Premultiplied = 0x1,
        [NativeName("Name", "DirectXAlphaMode_Straight")]
        Straight = 0x2,
        [NativeName("Name", "DirectXAlphaMode_Ignore")]
        Ignore = 0x3,
    }
}
