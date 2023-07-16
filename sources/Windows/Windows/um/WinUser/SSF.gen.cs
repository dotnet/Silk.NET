// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SSF
{
    [NativeTypeName("#define SSF_SOUNDSENTRYON 0x00000001")]
    public const int SSF_SOUNDSENTRYON = 0x00000001;
    [NativeTypeName("#define SSF_AVAILABLE 0x00000002")]
    public const int SSF_AVAILABLE = 0x00000002;
    [NativeTypeName("#define SSF_INDICATOR 0x00000004")]
    public const int SSF_INDICATOR = 0x00000004;
}