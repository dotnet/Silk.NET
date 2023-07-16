// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class MWMO
{
    [NativeTypeName("#define MWMO_WAITALL 0x0001")]
    public const int MWMO_WAITALL = 0x0001;
    [NativeTypeName("#define MWMO_ALERTABLE 0x0002")]
    public const int MWMO_ALERTABLE = 0x0002;
    [NativeTypeName("#define MWMO_INPUTAVAILABLE 0x0004")]
    public const int MWMO_INPUTAVAILABLE = 0x0004;
}