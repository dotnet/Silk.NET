// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class LOGON
{
    [NativeTypeName("#define LOGON_WITH_PROFILE 0x00000001")]
    public const int LOGON_WITH_PROFILE = 0x00000001;
    [NativeTypeName("#define LOGON_NETCREDENTIALS_ONLY 0x00000002")]
    public const int LOGON_NETCREDENTIALS_ONLY = 0x00000002;
    [NativeTypeName("#define LOGON_ZERO_PASSWORD_BUFFER 0x80000000")]
    public const uint LOGON_ZERO_PASSWORD_BUFFER = 0x80000000;
}