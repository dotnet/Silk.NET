// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SP
{
    [NativeTypeName("#define SP_NOTREPORTED 0x4000")]
    public const int SP_NOTREPORTED = 0x4000;
    [NativeTypeName("#define SP_ERROR (-1)")]
    public const int SP_ERROR = (-1);
    [NativeTypeName("#define SP_APPABORT (-2)")]
    public const int SP_APPABORT = (-2);
    [NativeTypeName("#define SP_USERABORT (-3)")]
    public const int SP_USERABORT = (-3);
    [NativeTypeName("#define SP_OUTOFDISK (-4)")]
    public const int SP_OUTOFDISK = (-4);
    [NativeTypeName("#define SP_OUTOFMEMORY (-5)")]
    public const int SP_OUTOFMEMORY = (-5);
}