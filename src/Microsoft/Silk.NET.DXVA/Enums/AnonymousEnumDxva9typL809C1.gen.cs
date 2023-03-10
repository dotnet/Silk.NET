// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "__AnonymousEnum_dxva9typ_L809_C1")]
    public enum AnonymousEnumDxva9typL809C1 : int
    {
        [Obsolete("Deprecated in favour of \"Unknown\"")]
        [NativeName("Name", "COPP_ProtectionType_Unknown")]
        CoppProtectionTypeUnknown = unchecked((int) 0xFFFFFFFF80000000),
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "COPP_ProtectionType_None")]
        CoppProtectionTypeNone = 0x0,
        [Obsolete("Deprecated in favour of \"Hdcp\"")]
        [NativeName("Name", "COPP_ProtectionType_HDCP")]
        CoppProtectionTypeHdcp = 0x1,
        [Obsolete("Deprecated in favour of \"Acp\"")]
        [NativeName("Name", "COPP_ProtectionType_ACP")]
        CoppProtectionTypeAcp = 0x2,
        [Obsolete("Deprecated in favour of \"Cgmsa\"")]
        [NativeName("Name", "COPP_ProtectionType_CGMSA")]
        CoppProtectionTypeCgmsa = 0x4,
        [Obsolete("Deprecated in favour of \"Mask\"")]
        [NativeName("Name", "COPP_ProtectionType_Mask")]
        CoppProtectionTypeMask = unchecked((int) 0xFFFFFFFF80000007),
        [Obsolete("Deprecated in favour of \"Reserved\"")]
        [NativeName("Name", "COPP_ProtectionType_Reserved")]
        CoppProtectionTypeReserved = 0x7FFFFFF8,
        [NativeName("Name", "COPP_ProtectionType_Unknown")]
        Unknown = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "COPP_ProtectionType_None")]
        None = 0x0,
        [NativeName("Name", "COPP_ProtectionType_HDCP")]
        Hdcp = 0x1,
        [NativeName("Name", "COPP_ProtectionType_ACP")]
        Acp = 0x2,
        [NativeName("Name", "COPP_ProtectionType_CGMSA")]
        Cgmsa = 0x4,
        [NativeName("Name", "COPP_ProtectionType_Mask")]
        Mask = unchecked((int) 0xFFFFFFFF80000007),
        [NativeName("Name", "COPP_ProtectionType_Reserved")]
        Reserved = 0x7FFFFFF8,
    }
}
