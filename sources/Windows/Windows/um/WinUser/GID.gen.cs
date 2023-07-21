// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class GID
{
    [NativeTypeName("#define GID_BEGIN 1")]
    public const int GID_BEGIN = 1;

    [NativeTypeName("#define GID_END 2")]
    public const int GID_END = 2;

    [NativeTypeName("#define GID_ZOOM 3")]
    public const int GID_ZOOM = 3;

    [NativeTypeName("#define GID_PAN 4")]
    public const int GID_PAN = 4;

    [NativeTypeName("#define GID_ROTATE 5")]
    public const int GID_ROTATE = 5;

    [NativeTypeName("#define GID_TWOFINGERTAP 6")]
    public const int GID_TWOFINGERTAP = 6;

    [NativeTypeName("#define GID_PRESSANDTAP 7")]
    public const int GID_PRESSANDTAP = 7;

    [NativeTypeName("#define GID_ROLLOVER GID_PRESSANDTAP")]
    public const int GID_ROLLOVER = 7;
}
