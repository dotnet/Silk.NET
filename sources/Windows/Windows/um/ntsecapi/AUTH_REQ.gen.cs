// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class AUTH_REQ
{
    [NativeTypeName("#define AUTH_REQ_ALLOW_FORWARDABLE 0x00000001")]
    public const int AUTH_REQ_ALLOW_FORWARDABLE = 0x00000001;

    [NativeTypeName("#define AUTH_REQ_ALLOW_PROXIABLE 0x00000002")]
    public const int AUTH_REQ_ALLOW_PROXIABLE = 0x00000002;

    [NativeTypeName("#define AUTH_REQ_ALLOW_POSTDATE 0x00000004")]
    public const int AUTH_REQ_ALLOW_POSTDATE = 0x00000004;

    [NativeTypeName("#define AUTH_REQ_ALLOW_RENEWABLE 0x00000008")]
    public const int AUTH_REQ_ALLOW_RENEWABLE = 0x00000008;

    [NativeTypeName("#define AUTH_REQ_ALLOW_NOADDRESS 0x00000010")]
    public const int AUTH_REQ_ALLOW_NOADDRESS = 0x00000010;

    [NativeTypeName("#define AUTH_REQ_ALLOW_ENC_TKT_IN_SKEY 0x00000020")]
    public const int AUTH_REQ_ALLOW_ENC_TKT_IN_SKEY = 0x00000020;

    [NativeTypeName("#define AUTH_REQ_ALLOW_VALIDATE 0x00000040")]
    public const int AUTH_REQ_ALLOW_VALIDATE = 0x00000040;

    [NativeTypeName("#define AUTH_REQ_VALIDATE_CLIENT 0x00000080")]
    public const int AUTH_REQ_VALIDATE_CLIENT = 0x00000080;

    [NativeTypeName("#define AUTH_REQ_OK_AS_DELEGATE 0x00000100")]
    public const int AUTH_REQ_OK_AS_DELEGATE = 0x00000100;

    [NativeTypeName("#define AUTH_REQ_PREAUTH_REQUIRED 0x00000200")]
    public const int AUTH_REQ_PREAUTH_REQUIRED = 0x00000200;

    [NativeTypeName("#define AUTH_REQ_TRANSITIVE_TRUST 0x00000400")]
    public const int AUTH_REQ_TRANSITIVE_TRUST = 0x00000400;

    [NativeTypeName("#define AUTH_REQ_ALLOW_S4U_DELEGATE 0x00000800")]
    public const int AUTH_REQ_ALLOW_S4U_DELEGATE = 0x00000800;

    [NativeTypeName("#define AUTH_REQ_PER_USER_FLAGS (AUTH_REQ_ALLOW_FORWARDABLE | \\\r\n                                         AUTH_REQ_ALLOW_PROXIABLE | \\\r\n                                         AUTH_REQ_ALLOW_POSTDATE | \\\r\n                                         AUTH_REQ_ALLOW_RENEWABLE | \\\r\n                                         AUTH_REQ_ALLOW_VALIDATE )")]
    public const int AUTH_REQ_PER_USER_FLAGS = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000040);
}
