// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class RIDEV
{
    [NativeTypeName("#define RIDEV_REMOVE 0x00000001")]
    public const int RIDEV_REMOVE = 0x00000001;
    [NativeTypeName("#define RIDEV_EXCLUDE 0x00000010")]
    public const int RIDEV_EXCLUDE = 0x00000010;
    [NativeTypeName("#define RIDEV_PAGEONLY 0x00000020")]
    public const int RIDEV_PAGEONLY = 0x00000020;
    [NativeTypeName("#define RIDEV_NOLEGACY 0x00000030")]
    public const int RIDEV_NOLEGACY = 0x00000030;
    [NativeTypeName("#define RIDEV_INPUTSINK 0x00000100")]
    public const int RIDEV_INPUTSINK = 0x00000100;
    [NativeTypeName("#define RIDEV_CAPTUREMOUSE 0x00000200")]
    public const int RIDEV_CAPTUREMOUSE = 0x00000200;
    [NativeTypeName("#define RIDEV_NOHOTKEYS 0x00000200")]
    public const int RIDEV_NOHOTKEYS = 0x00000200;
    [NativeTypeName("#define RIDEV_APPKEYS 0x00000400")]
    public const int RIDEV_APPKEYS = 0x00000400;
    [NativeTypeName("#define RIDEV_EXINPUTSINK 0x00001000")]
    public const int RIDEV_EXINPUTSINK = 0x00001000;
    [NativeTypeName("#define RIDEV_DEVNOTIFY 0x00002000")]
    public const int RIDEV_DEVNOTIFY = 0x00002000;
    [NativeTypeName("#define RIDEV_EXMODEMASK 0x000000F0")]
    public const int RIDEV_EXMODEMASK = 0x000000F0;
}