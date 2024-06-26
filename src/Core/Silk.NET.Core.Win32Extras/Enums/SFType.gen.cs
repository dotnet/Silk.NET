// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagSF_TYPE")]
    public enum SFType : int
    {
        [Obsolete("Deprecated in favour of \"Error\"")]
        [NativeName("Name", "SF_ERROR")]
        SFError = 0xA,
        [Obsolete("Deprecated in favour of \"I1\"")]
        [NativeName("Name", "SF_I1")]
        SFI1 = 0x10,
        [Obsolete("Deprecated in favour of \"I2\"")]
        [NativeName("Name", "SF_I2")]
        SFI2 = 0x2,
        [Obsolete("Deprecated in favour of \"I4\"")]
        [NativeName("Name", "SF_I4")]
        SFI4 = 0x3,
        [Obsolete("Deprecated in favour of \"I8\"")]
        [NativeName("Name", "SF_I8")]
        SFI8 = 0x14,
        [Obsolete("Deprecated in favour of \"Bstr\"")]
        [NativeName("Name", "SF_BSTR")]
        SFBstr = 0x8,
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "SF_UNKNOWN")]
        SFUnknown = 0xD,
        [Obsolete("Deprecated in favour of \"Dispatch\"")]
        [NativeName("Name", "SF_DISPATCH")]
        SFDispatch = 0x9,
        [Obsolete("Deprecated in favour of \"Variant\"")]
        [NativeName("Name", "SF_VARIANT")]
        SFVariant = 0xC,
        [Obsolete("Deprecated in favour of \"Record\"")]
        [NativeName("Name", "SF_RECORD")]
        SFRecord = 0x24,
        [Obsolete("Deprecated in favour of \"Haveiid\"")]
        [NativeName("Name", "SF_HAVEIID")]
        SFHaveiid = 0x800D,
        [NativeName("Name", "SF_ERROR")]
        Error = 0xA,
        [NativeName("Name", "SF_I1")]
        I1 = 0x10,
        [NativeName("Name", "SF_I2")]
        I2 = 0x2,
        [NativeName("Name", "SF_I4")]
        I4 = 0x3,
        [NativeName("Name", "SF_I8")]
        I8 = 0x14,
        [NativeName("Name", "SF_BSTR")]
        Bstr = 0x8,
        [NativeName("Name", "SF_UNKNOWN")]
        Unknown = 0xD,
        [NativeName("Name", "SF_DISPATCH")]
        Dispatch = 0x9,
        [NativeName("Name", "SF_VARIANT")]
        Variant = 0xC,
        [NativeName("Name", "SF_RECORD")]
        Record = 0x24,
        [NativeName("Name", "SF_HAVEIID")]
        Haveiid = 0x800D,
    }
}
