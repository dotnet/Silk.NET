// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagExtentMode")]
    public enum ExtentMode : int
    {
        [Obsolete("Deprecated in favour of \"Content\"")]
        [NativeName("Name", "DVEXTENT_CONTENT")]
        DvextentContent = 0x0,
        [Obsolete("Deprecated in favour of \"Integral\"")]
        [NativeName("Name", "DVEXTENT_INTEGRAL")]
        DvextentIntegral = 0x1,
        [NativeName("Name", "DVEXTENT_CONTENT")]
        Content = 0x0,
        [NativeName("Name", "DVEXTENT_INTEGRAL")]
        Integral = 0x1,
    }
}
