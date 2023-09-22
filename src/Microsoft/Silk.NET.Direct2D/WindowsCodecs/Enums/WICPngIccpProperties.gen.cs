// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICPngIccpProperties")]
    public enum WICPngIccpProperties : int
    {
        [Obsolete("Deprecated in favour of \"ProfileName\"")]
        [NativeName("Name", "WICPngIccpProfileName")]
        WicpngIccpProfileName = 0x1,
        [Obsolete("Deprecated in favour of \"ProfileData\"")]
        [NativeName("Name", "WICPngIccpProfileData")]
        WicpngIccpProfileData = 0x2,
        [Obsolete("Deprecated in favour of \"PropertiesForceDword\"")]
        [NativeName("Name", "WICPngIccpProperties_FORCE_DWORD")]
        WicpngIccpPropertiesForceDword = 0x7FFFFFFF,
        [NativeName("Name", "WICPngIccpProfileName")]
        ProfileName = 0x1,
        [NativeName("Name", "WICPngIccpProfileData")]
        ProfileData = 0x2,
        [NativeName("Name", "WICPngIccpProperties_FORCE_DWORD")]
        PropertiesForceDword = 0x7FFFFFFF,
    }
}
