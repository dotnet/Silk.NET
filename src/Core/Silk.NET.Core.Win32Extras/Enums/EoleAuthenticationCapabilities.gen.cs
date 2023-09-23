// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagEOLE_AUTHENTICATION_CAPABILITIES")]
    public enum EoleAuthenticationCapabilities : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "EOAC_NONE")]
        EoacNone = 0x0,
        [Obsolete("Deprecated in favour of \"MutualAuth\"")]
        [NativeName("Name", "EOAC_MUTUAL_AUTH")]
        EoacMutualAuth = 0x1,
        [Obsolete("Deprecated in favour of \"StaticCloaking\"")]
        [NativeName("Name", "EOAC_STATIC_CLOAKING")]
        EoacStaticCloaking = 0x20,
        [Obsolete("Deprecated in favour of \"DynamicCloaking\"")]
        [NativeName("Name", "EOAC_DYNAMIC_CLOAKING")]
        EoacDynamicCloaking = 0x40,
        [Obsolete("Deprecated in favour of \"AnyAuthority\"")]
        [NativeName("Name", "EOAC_ANY_AUTHORITY")]
        EoacAnyAuthority = 0x80,
        [Obsolete("Deprecated in favour of \"MakeFullsic\"")]
        [NativeName("Name", "EOAC_MAKE_FULLSIC")]
        EoacMakeFullsic = 0x100,
        [Obsolete("Deprecated in favour of \"Default\"")]
        [NativeName("Name", "EOAC_DEFAULT")]
        EoacDefault = 0x800,
        [Obsolete("Deprecated in favour of \"SecureRefs\"")]
        [NativeName("Name", "EOAC_SECURE_REFS")]
        EoacSecureRefs = 0x2,
        [Obsolete("Deprecated in favour of \"AccessControl\"")]
        [NativeName("Name", "EOAC_ACCESS_CONTROL")]
        EoacAccessControl = 0x4,
        [Obsolete("Deprecated in favour of \"Appid\"")]
        [NativeName("Name", "EOAC_APPID")]
        EoacAppid = 0x8,
        [Obsolete("Deprecated in favour of \"Dynamic\"")]
        [NativeName("Name", "EOAC_DYNAMIC")]
        EoacDynamic = 0x10,
        [Obsolete("Deprecated in favour of \"RequireFullsic\"")]
        [NativeName("Name", "EOAC_REQUIRE_FULLSIC")]
        EoacRequireFullsic = 0x200,
        [Obsolete("Deprecated in favour of \"AutoImpersonate\"")]
        [NativeName("Name", "EOAC_AUTO_IMPERSONATE")]
        EoacAutoImpersonate = 0x400,
        [Obsolete("Deprecated in favour of \"DisableAaa\"")]
        [NativeName("Name", "EOAC_DISABLE_AAA")]
        EoacDisableAaa = 0x1000,
        [Obsolete("Deprecated in favour of \"NoCustomMarshal\"")]
        [NativeName("Name", "EOAC_NO_CUSTOM_MARSHAL")]
        EoacNoCustomMarshal = 0x2000,
        [Obsolete("Deprecated in favour of \"Reserved1\"")]
        [NativeName("Name", "EOAC_RESERVED1")]
        EoacReserved1 = 0x4000,
        [NativeName("Name", "EOAC_NONE")]
        None = 0x0,
        [NativeName("Name", "EOAC_MUTUAL_AUTH")]
        MutualAuth = 0x1,
        [NativeName("Name", "EOAC_STATIC_CLOAKING")]
        StaticCloaking = 0x20,
        [NativeName("Name", "EOAC_DYNAMIC_CLOAKING")]
        DynamicCloaking = 0x40,
        [NativeName("Name", "EOAC_ANY_AUTHORITY")]
        AnyAuthority = 0x80,
        [NativeName("Name", "EOAC_MAKE_FULLSIC")]
        MakeFullsic = 0x100,
        [NativeName("Name", "EOAC_DEFAULT")]
        Default = 0x800,
        [NativeName("Name", "EOAC_SECURE_REFS")]
        SecureRefs = 0x2,
        [NativeName("Name", "EOAC_ACCESS_CONTROL")]
        AccessControl = 0x4,
        [NativeName("Name", "EOAC_APPID")]
        Appid = 0x8,
        [NativeName("Name", "EOAC_DYNAMIC")]
        Dynamic = 0x10,
        [NativeName("Name", "EOAC_REQUIRE_FULLSIC")]
        RequireFullsic = 0x200,
        [NativeName("Name", "EOAC_AUTO_IMPERSONATE")]
        AutoImpersonate = 0x400,
        [NativeName("Name", "EOAC_DISABLE_AAA")]
        DisableAaa = 0x1000,
        [NativeName("Name", "EOAC_NO_CUSTOM_MARSHAL")]
        NoCustomMarshal = 0x2000,
        [NativeName("Name", "EOAC_RESERVED1")]
        Reserved1 = 0x4000,
    }
}
