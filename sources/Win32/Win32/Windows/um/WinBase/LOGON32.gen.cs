// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class LOGON32
{
    [NativeTypeName("#define LOGON32_LOGON_INTERACTIVE 2")]
    public const int LOGON32_LOGON_INTERACTIVE = 2;

    [NativeTypeName("#define LOGON32_LOGON_NETWORK 3")]
    public const int LOGON32_LOGON_NETWORK = 3;

    [NativeTypeName("#define LOGON32_LOGON_BATCH 4")]
    public const int LOGON32_LOGON_BATCH = 4;

    [NativeTypeName("#define LOGON32_LOGON_SERVICE 5")]
    public const int LOGON32_LOGON_SERVICE = 5;

    [NativeTypeName("#define LOGON32_LOGON_UNLOCK 7")]
    public const int LOGON32_LOGON_UNLOCK = 7;

    [NativeTypeName("#define LOGON32_LOGON_NETWORK_CLEARTEXT 8")]
    public const int LOGON32_LOGON_NETWORK_CLEARTEXT = 8;

    [NativeTypeName("#define LOGON32_LOGON_NEW_CREDENTIALS 9")]
    public const int LOGON32_LOGON_NEW_CREDENTIALS = 9;

    [NativeTypeName("#define LOGON32_PROVIDER_DEFAULT 0")]
    public const int LOGON32_PROVIDER_DEFAULT = 0;

    [NativeTypeName("#define LOGON32_PROVIDER_WINNT35 1")]
    public const int LOGON32_PROVIDER_WINNT35 = 1;

    [NativeTypeName("#define LOGON32_PROVIDER_WINNT40 2")]
    public const int LOGON32_PROVIDER_WINNT40 = 2;

    [NativeTypeName("#define LOGON32_PROVIDER_WINNT50 3")]
    public const int LOGON32_PROVIDER_WINNT50 = 3;

    [NativeTypeName("#define LOGON32_PROVIDER_VIRTUAL 4")]
    public const int LOGON32_PROVIDER_VIRTUAL = 4;
}
