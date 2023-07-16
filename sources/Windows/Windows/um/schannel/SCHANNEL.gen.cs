// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
public static partial class SCHANNEL
{
    [NativeTypeName("#define SCHANNEL_NAME_A \"Schannel\"")]
    public static ReadOnlySpan<byte> SCHANNEL_NAME_A => "Schannel"u8;

    [NativeTypeName("#define SCHANNEL_NAME_W L\"Schannel\"")]
    public const string SCHANNEL_NAME_W = "Schannel";
    [NativeTypeName("#define SCHANNEL_NAME SCHANNEL_NAME_W")]
    public const string SCHANNEL_NAME = "Schannel";
    [NativeTypeName("#define SCHANNEL_CRED_VERSION 0x00000004")]
    public const int SCHANNEL_CRED_VERSION = 0x00000004;
    [NativeTypeName("#define SCHANNEL_RENEGOTIATE 0")]
    public const int SCHANNEL_RENEGOTIATE = 0;
    [NativeTypeName("#define SCHANNEL_SHUTDOWN 1")]
    public const int SCHANNEL_SHUTDOWN = 1;
    [NativeTypeName("#define SCHANNEL_ALERT 2")]
    public const int SCHANNEL_ALERT = 2;
    [NativeTypeName("#define SCHANNEL_SESSION 3")]
    public const int SCHANNEL_SESSION = 3;
    [NativeTypeName("#define SCHANNEL_SECRET_TYPE_CAPI 0x00000001")]
    public const int SCHANNEL_SECRET_TYPE_CAPI = 0x00000001;
    [NativeTypeName("#define SCHANNEL_SECRET_PRIVKEY 0x00000002")]
    public const int SCHANNEL_SECRET_PRIVKEY = 0x00000002;
}