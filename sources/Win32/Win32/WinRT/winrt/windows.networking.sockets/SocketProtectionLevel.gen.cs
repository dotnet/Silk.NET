// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SocketProtectionLevel
{
    SocketProtectionLevel_PlainSocket = 0,

    [Obsolete(
        "Ssl may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values."
    )]
    SocketProtectionLevel_Ssl = 1,
    SocketProtectionLevel_SslAllowNullEncryption = 2,
    SocketProtectionLevel_BluetoothEncryptionAllowNullAuthentication = 3,
    SocketProtectionLevel_BluetoothEncryptionWithAuthentication = 4,

    [Obsolete(
        "Ssl3AllowWeakEncryption may result in insecure connections and may be altered or unavailable for releases after Windows 8.1. Instead, use one of the TLS SocketProtectionLevel values."
    )]
    SocketProtectionLevel_Ssl3AllowWeakEncryption = 5,
    SocketProtectionLevel_Tls10 = 6,
    SocketProtectionLevel_Tls11 = 7,
    SocketProtectionLevel_Tls12 = 8,
    SocketProtectionLevel_Unspecified = 9,
    SocketProtectionLevel_Tls13 = 10,
}
