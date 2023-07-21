// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class SP
{
    [NativeTypeName("#define SP_PROT_PCT1_SERVER 0x00000001")]
    public const int SP_PROT_PCT1_SERVER = 0x00000001;

    [NativeTypeName("#define SP_PROT_PCT1_CLIENT 0x00000002")]
    public const int SP_PROT_PCT1_CLIENT = 0x00000002;

    [NativeTypeName("#define SP_PROT_PCT1 (SP_PROT_PCT1_SERVER | SP_PROT_PCT1_CLIENT)")]
    public const int SP_PROT_PCT1 = (0x00000001 | 0x00000002);

    [NativeTypeName("#define SP_PROT_SSL2_SERVER 0x00000004")]
    public const int SP_PROT_SSL2_SERVER = 0x00000004;

    [NativeTypeName("#define SP_PROT_SSL2_CLIENT 0x00000008")]
    public const int SP_PROT_SSL2_CLIENT = 0x00000008;

    [NativeTypeName("#define SP_PROT_SSL2 (SP_PROT_SSL2_SERVER | SP_PROT_SSL2_CLIENT)")]
    public const int SP_PROT_SSL2 = (0x00000004 | 0x00000008);

    [NativeTypeName("#define SP_PROT_SSL3_SERVER 0x00000010")]
    public const int SP_PROT_SSL3_SERVER = 0x00000010;

    [NativeTypeName("#define SP_PROT_SSL3_CLIENT 0x00000020")]
    public const int SP_PROT_SSL3_CLIENT = 0x00000020;

    [NativeTypeName("#define SP_PROT_SSL3 (SP_PROT_SSL3_SERVER | SP_PROT_SSL3_CLIENT)")]
    public const int SP_PROT_SSL3 = (0x00000010 | 0x00000020);

    [NativeTypeName("#define SP_PROT_TLS1_SERVER 0x00000040")]
    public const int SP_PROT_TLS1_SERVER = 0x00000040;

    [NativeTypeName("#define SP_PROT_TLS1_CLIENT 0x00000080")]
    public const int SP_PROT_TLS1_CLIENT = 0x00000080;

    [NativeTypeName("#define SP_PROT_TLS1 (SP_PROT_TLS1_SERVER | SP_PROT_TLS1_CLIENT)")]
    public const int SP_PROT_TLS1 = (0x00000040 | 0x00000080);

    [NativeTypeName("#define SP_PROT_SSL3TLS1_CLIENTS (SP_PROT_TLS1_CLIENT | SP_PROT_SSL3_CLIENT)")]
    public const int SP_PROT_SSL3TLS1_CLIENTS = (0x00000080 | 0x00000020);

    [NativeTypeName("#define SP_PROT_SSL3TLS1_SERVERS (SP_PROT_TLS1_SERVER | SP_PROT_SSL3_SERVER)")]
    public const int SP_PROT_SSL3TLS1_SERVERS = (0x00000040 | 0x00000010);

    [NativeTypeName("#define SP_PROT_SSL3TLS1 (SP_PROT_SSL3 | SP_PROT_TLS1)")]
    public const int SP_PROT_SSL3TLS1 = ((0x00000010 | 0x00000020) | (0x00000040 | 0x00000080));

    [NativeTypeName("#define SP_PROT_UNI_SERVER 0x40000000")]
    public const int SP_PROT_UNI_SERVER = 0x40000000;

    [NativeTypeName("#define SP_PROT_UNI_CLIENT 0x80000000")]
    public const uint SP_PROT_UNI_CLIENT = 0x80000000;

    [NativeTypeName("#define SP_PROT_UNI (SP_PROT_UNI_SERVER | SP_PROT_UNI_CLIENT)")]
    public const uint SP_PROT_UNI = (0x40000000 | 0x80000000);

    [NativeTypeName("#define SP_PROT_ALL 0xffffffff")]
    public const uint SP_PROT_ALL = 0xffffffff;

    [NativeTypeName("#define SP_PROT_NONE 0")]
    public const int SP_PROT_NONE = 0;

    [NativeTypeName("#define SP_PROT_CLIENTS (SP_PROT_PCT1_CLIENT | SP_PROT_SSL2_CLIENT | SP_PROT_SSL3_CLIENT | SP_PROT_UNI_CLIENT | SP_PROT_TLS1_CLIENT)")]
    public const uint SP_PROT_CLIENTS = (0x00000002 | 0x00000008 | 0x00000020 | 0x80000000 | 0x00000080);

    [NativeTypeName("#define SP_PROT_SERVERS (SP_PROT_PCT1_SERVER | SP_PROT_SSL2_SERVER | SP_PROT_SSL3_SERVER | SP_PROT_UNI_SERVER | SP_PROT_TLS1_SERVER)")]
    public const int SP_PROT_SERVERS = (0x00000001 | 0x00000004 | 0x00000010 | 0x40000000 | 0x00000040);

    [NativeTypeName("#define SP_PROT_TLS1_0_SERVER SP_PROT_TLS1_SERVER")]
    public const int SP_PROT_TLS1_0_SERVER = 0x00000040;

    [NativeTypeName("#define SP_PROT_TLS1_0_CLIENT SP_PROT_TLS1_CLIENT")]
    public const int SP_PROT_TLS1_0_CLIENT = 0x00000080;

    [NativeTypeName("#define SP_PROT_TLS1_0 (SP_PROT_TLS1_0_SERVER | \\\r\n                                         SP_PROT_TLS1_0_CLIENT)")]
    public const int SP_PROT_TLS1_0 = (0x00000040 | 0x00000080);

    [NativeTypeName("#define SP_PROT_TLS1_1_SERVER 0x00000100")]
    public const int SP_PROT_TLS1_1_SERVER = 0x00000100;

    [NativeTypeName("#define SP_PROT_TLS1_1_CLIENT 0x00000200")]
    public const int SP_PROT_TLS1_1_CLIENT = 0x00000200;

    [NativeTypeName("#define SP_PROT_TLS1_1 (SP_PROT_TLS1_1_SERVER | \\\r\n                                         SP_PROT_TLS1_1_CLIENT)")]
    public const int SP_PROT_TLS1_1 = (0x00000100 | 0x00000200);

    [NativeTypeName("#define SP_PROT_TLS1_2_SERVER 0x00000400")]
    public const int SP_PROT_TLS1_2_SERVER = 0x00000400;

    [NativeTypeName("#define SP_PROT_TLS1_2_CLIENT 0x00000800")]
    public const int SP_PROT_TLS1_2_CLIENT = 0x00000800;

    [NativeTypeName("#define SP_PROT_TLS1_2 (SP_PROT_TLS1_2_SERVER | \\\r\n                                         SP_PROT_TLS1_2_CLIENT)")]
    public const int SP_PROT_TLS1_2 = (0x00000400 | 0x00000800);

    [NativeTypeName("#define SP_PROT_TLS1_3_SERVER 0x00001000")]
    public const int SP_PROT_TLS1_3_SERVER = 0x00001000;

    [NativeTypeName("#define SP_PROT_TLS1_3_CLIENT 0x00002000")]
    public const int SP_PROT_TLS1_3_CLIENT = 0x00002000;

    [NativeTypeName("#define SP_PROT_TLS1_3 (SP_PROT_TLS1_3_SERVER | \\\r\n                                         SP_PROT_TLS1_3_CLIENT)")]
    public const int SP_PROT_TLS1_3 = (0x00001000 | 0x00002000);

    [NativeTypeName("#define SP_PROT_DTLS_SERVER 0x00010000")]
    public const int SP_PROT_DTLS_SERVER = 0x00010000;

    [NativeTypeName("#define SP_PROT_DTLS_CLIENT 0x00020000")]
    public const int SP_PROT_DTLS_CLIENT = 0x00020000;

    [NativeTypeName("#define SP_PROT_DTLS (SP_PROT_DTLS_SERVER | \\\r\n                                         SP_PROT_DTLS_CLIENT )")]
    public const int SP_PROT_DTLS = (0x00010000 | 0x00020000);

    [NativeTypeName("#define SP_PROT_DTLS1_0_SERVER SP_PROT_DTLS_SERVER")]
    public const int SP_PROT_DTLS1_0_SERVER = 0x00010000;

    [NativeTypeName("#define SP_PROT_DTLS1_0_CLIENT SP_PROT_DTLS_CLIENT")]
    public const int SP_PROT_DTLS1_0_CLIENT = 0x00020000;

    [NativeTypeName("#define SP_PROT_DTLS1_0 (SP_PROT_DTLS1_0_SERVER | SP_PROT_DTLS1_0_CLIENT)")]
    public const int SP_PROT_DTLS1_0 = (0x00010000 | 0x00020000);

    [NativeTypeName("#define SP_PROT_DTLS1_2_SERVER 0x00040000")]
    public const int SP_PROT_DTLS1_2_SERVER = 0x00040000;

    [NativeTypeName("#define SP_PROT_DTLS1_2_CLIENT 0x00080000")]
    public const int SP_PROT_DTLS1_2_CLIENT = 0x00080000;

    [NativeTypeName("#define SP_PROT_DTLS1_2 (SP_PROT_DTLS1_2_SERVER | SP_PROT_DTLS1_2_CLIENT)")]
    public const int SP_PROT_DTLS1_2 = (0x00040000 | 0x00080000);

    [NativeTypeName("#define SP_PROT_DTLS1_X_SERVER (SP_PROT_DTLS1_0_SERVER | \\\r\n                                         SP_PROT_DTLS1_2_SERVER)")]
    public const int SP_PROT_DTLS1_X_SERVER = (0x00010000 | 0x00040000);

    [NativeTypeName("#define SP_PROT_DTLS1_X_CLIENT (SP_PROT_DTLS1_0_CLIENT | \\\r\n                                         SP_PROT_DTLS1_2_CLIENT)")]
    public const int SP_PROT_DTLS1_X_CLIENT = (0x00020000 | 0x00080000);

    [NativeTypeName("#define SP_PROT_DTLS1_X (SP_PROT_DTLS1_X_SERVER | \\\r\n                                         SP_PROT_DTLS1_X_CLIENT)")]
    public const int SP_PROT_DTLS1_X = ((0x00010000 | 0x00040000) | (0x00020000 | 0x00080000));

    [NativeTypeName("#define SP_PROT_TLS1_1PLUS_SERVER (SP_PROT_TLS1_1_SERVER | \\\r\n                                         SP_PROT_TLS1_2_SERVER | \\\r\n                                         SP_PROT_TLS1_3_SERVER)")]
    public const int SP_PROT_TLS1_1PLUS_SERVER = (0x00000100 | 0x00000400 | 0x00001000);

    [NativeTypeName("#define SP_PROT_TLS1_1PLUS_CLIENT (SP_PROT_TLS1_1_CLIENT | \\\r\n                                         SP_PROT_TLS1_2_CLIENT | \\\r\n                                         SP_PROT_TLS1_3_CLIENT)")]
    public const int SP_PROT_TLS1_1PLUS_CLIENT = (0x00000200 | 0x00000800 | 0x00002000);

    [NativeTypeName("#define SP_PROT_TLS1_1PLUS (SP_PROT_TLS1_1PLUS_SERVER | \\\r\n                                         SP_PROT_TLS1_1PLUS_CLIENT)")]
    public const int SP_PROT_TLS1_1PLUS = ((0x00000100 | 0x00000400 | 0x00001000) | (0x00000200 | 0x00000800 | 0x00002000));

    [NativeTypeName("#define SP_PROT_TLS1_3PLUS_SERVER SP_PROT_TLS1_3_SERVER")]
    public const int SP_PROT_TLS1_3PLUS_SERVER = 0x00001000;

    [NativeTypeName("#define SP_PROT_TLS1_3PLUS_CLIENT SP_PROT_TLS1_3_CLIENT")]
    public const int SP_PROT_TLS1_3PLUS_CLIENT = 0x00002000;

    [NativeTypeName("#define SP_PROT_TLS1_3PLUS (SP_PROT_TLS1_3PLUS_SERVER | \\\r\n                                         SP_PROT_TLS1_3PLUS_CLIENT)")]
    public const int SP_PROT_TLS1_3PLUS = (0x00001000 | 0x00002000);

    [NativeTypeName("#define SP_PROT_TLS1_X_SERVER (SP_PROT_TLS1_0_SERVER | \\\r\n                                         SP_PROT_TLS1_1_SERVER | \\\r\n                                         SP_PROT_TLS1_2_SERVER | \\\r\n                                         SP_PROT_TLS1_3_SERVER)")]
    public const int SP_PROT_TLS1_X_SERVER = (0x00000040 | 0x00000100 | 0x00000400 | 0x00001000);

    [NativeTypeName("#define SP_PROT_TLS1_X_CLIENT (SP_PROT_TLS1_0_CLIENT | \\\r\n                                         SP_PROT_TLS1_1_CLIENT | \\\r\n                                         SP_PROT_TLS1_2_CLIENT | \\\r\n                                         SP_PROT_TLS1_3_CLIENT)")]
    public const int SP_PROT_TLS1_X_CLIENT = (0x00000080 | 0x00000200 | 0x00000800 | 0x00002000);

    [NativeTypeName("#define SP_PROT_TLS1_X (SP_PROT_TLS1_X_SERVER | \\\r\n                                         SP_PROT_TLS1_X_CLIENT)")]
    public const int SP_PROT_TLS1_X = ((0x00000040 | 0x00000100 | 0x00000400 | 0x00001000) | (0x00000080 | 0x00000200 | 0x00000800 | 0x00002000));

    [NativeTypeName("#define SP_PROT_SSL3TLS1_X_CLIENTS (SP_PROT_TLS1_X_CLIENT | \\\r\n                                         SP_PROT_SSL3_CLIENT)")]
    public const int SP_PROT_SSL3TLS1_X_CLIENTS = ((0x00000080 | 0x00000200 | 0x00000800 | 0x00002000) | 0x00000020);

    [NativeTypeName("#define SP_PROT_SSL3TLS1_X_SERVERS (SP_PROT_TLS1_X_SERVER | \\\r\n                                         SP_PROT_SSL3_SERVER)")]
    public const int SP_PROT_SSL3TLS1_X_SERVERS = ((0x00000040 | 0x00000100 | 0x00000400 | 0x00001000) | 0x00000010);

    [NativeTypeName("#define SP_PROT_SSL3TLS1_X (SP_PROT_SSL3 | SP_PROT_TLS1_X)")]
    public const int SP_PROT_SSL3TLS1_X = ((0x00000010 | 0x00000020) | ((0x00000040 | 0x00000100 | 0x00000400 | 0x00001000) | (0x00000080 | 0x00000200 | 0x00000800 | 0x00002000)));

    [NativeTypeName("#define SP_PROT_X_CLIENTS (SP_PROT_CLIENTS | \\\r\n                                         SP_PROT_TLS1_X_CLIENT | \\\r\n                                         SP_PROT_DTLS1_X_CLIENT )")]
    public const uint SP_PROT_X_CLIENTS = ((0x00000002 | 0x00000008 | 0x00000020 | 0x80000000 | 0x00000080) | (0x00000080 | 0x00000200 | 0x00000800 | 0x00002000) | (0x00020000 | 0x00080000));

    [NativeTypeName("#define SP_PROT_X_SERVERS (SP_PROT_SERVERS | \\\r\n                                         SP_PROT_TLS1_X_SERVER | \\\r\n                                         SP_PROT_DTLS1_X_SERVER )")]
    public const int SP_PROT_X_SERVERS = ((0x00000001 | 0x00000004 | 0x00000010 | 0x40000000 | 0x00000040) | (0x00000040 | 0x00000100 | 0x00000400 | 0x00001000) | (0x00010000 | 0x00040000));
}
