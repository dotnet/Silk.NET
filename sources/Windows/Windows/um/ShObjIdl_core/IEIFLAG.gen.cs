// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class IEIFLAG
{
    [NativeTypeName("#define IEIFLAG_ASYNC 0x0001")]
    public const int IEIFLAG_ASYNC = 0x0001;

    [NativeTypeName("#define IEIFLAG_CACHE 0x0002")]
    public const int IEIFLAG_CACHE = 0x0002;

    [NativeTypeName("#define IEIFLAG_ASPECT 0x0004")]
    public const int IEIFLAG_ASPECT = 0x0004;

    [NativeTypeName("#define IEIFLAG_OFFLINE 0x0008")]
    public const int IEIFLAG_OFFLINE = 0x0008;

    [NativeTypeName("#define IEIFLAG_GLEAM 0x0010")]
    public const int IEIFLAG_GLEAM = 0x0010;

    [NativeTypeName("#define IEIFLAG_SCREEN 0x0020")]
    public const int IEIFLAG_SCREEN = 0x0020;

    [NativeTypeName("#define IEIFLAG_ORIGSIZE 0x0040")]
    public const int IEIFLAG_ORIGSIZE = 0x0040;

    [NativeTypeName("#define IEIFLAG_NOSTAMP 0x0080")]
    public const int IEIFLAG_NOSTAMP = 0x0080;

    [NativeTypeName("#define IEIFLAG_NOBORDER 0x0100")]
    public const int IEIFLAG_NOBORDER = 0x0100;

    [NativeTypeName("#define IEIFLAG_QUALITY 0x0200")]
    public const int IEIFLAG_QUALITY = 0x0200;

    [NativeTypeName("#define IEIFLAG_REFRESH 0x0400")]
    public const int IEIFLAG_REFRESH = 0x0400;
}
