// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class LOGON
{
    [NativeTypeName("#define LOGON_GUEST 0x01")]
    public const int LOGON_GUEST = 0x01;

    [NativeTypeName("#define LOGON_NOENCRYPTION 0x02")]
    public const int LOGON_NOENCRYPTION = 0x02;

    [NativeTypeName("#define LOGON_CACHED_ACCOUNT 0x04")]
    public const int LOGON_CACHED_ACCOUNT = 0x04;

    [NativeTypeName("#define LOGON_USED_LM_PASSWORD 0x08")]
    public const int LOGON_USED_LM_PASSWORD = 0x08;

    [NativeTypeName("#define LOGON_EXTRA_SIDS 0x20")]
    public const int LOGON_EXTRA_SIDS = 0x20;

    [NativeTypeName("#define LOGON_SUBAUTH_SESSION_KEY 0x40")]
    public const int LOGON_SUBAUTH_SESSION_KEY = 0x40;

    [NativeTypeName("#define LOGON_SERVER_TRUST_ACCOUNT 0x80")]
    public const int LOGON_SERVER_TRUST_ACCOUNT = 0x80;

    [NativeTypeName("#define LOGON_NTLMV2_ENABLED 0x100")]
    public const int LOGON_NTLMV2_ENABLED = 0x100;

    [NativeTypeName("#define LOGON_RESOURCE_GROUPS 0x200")]
    public const int LOGON_RESOURCE_GROUPS = 0x200;

    [NativeTypeName("#define LOGON_PROFILE_PATH_RETURNED 0x400")]
    public const int LOGON_PROFILE_PATH_RETURNED = 0x400;

    [NativeTypeName("#define LOGON_NT_V2 0x800")]
    public const int LOGON_NT_V2 = 0x800;

    [NativeTypeName("#define LOGON_LM_V2 0x1000")]
    public const int LOGON_LM_V2 = 0x1000;

    [NativeTypeName("#define LOGON_NTLM_V2 0x2000")]
    public const int LOGON_NTLM_V2 = 0x2000;

    [NativeTypeName("#define LOGON_OPTIMIZED 0x4000")]
    public const int LOGON_OPTIMIZED = 0x4000;

    [NativeTypeName("#define LOGON_WINLOGON 0x8000")]
    public const int LOGON_WINLOGON = 0x8000;

    [NativeTypeName("#define LOGON_PKINIT 0x10000")]
    public const int LOGON_PKINIT = 0x10000;

    [NativeTypeName("#define LOGON_NO_OPTIMIZED 0x20000")]
    public const int LOGON_NO_OPTIMIZED = 0x20000;

    [NativeTypeName("#define LOGON_NO_ELEVATION 0x40000")]
    public const int LOGON_NO_ELEVATION = 0x40000;

    [NativeTypeName("#define LOGON_MANAGED_SERVICE 0x80000")]
    public const int LOGON_MANAGED_SERVICE = 0x80000;

    [NativeTypeName("#define LOGON_GRACE_LOGON 0x01000000")]
    public const int LOGON_GRACE_LOGON = 0x01000000;
}
