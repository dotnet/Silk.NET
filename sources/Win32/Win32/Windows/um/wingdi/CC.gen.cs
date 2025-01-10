// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class CC
{
    [NativeTypeName("#define CC_NONE 0")]
    public const int CC_NONE = 0;

    [NativeTypeName("#define CC_CIRCLES 1")]
    public const int CC_CIRCLES = 1;

    [NativeTypeName("#define CC_PIE 2")]
    public const int CC_PIE = 2;

    [NativeTypeName("#define CC_CHORD 4")]
    public const int CC_CHORD = 4;

    [NativeTypeName("#define CC_ELLIPSES 8")]
    public const int CC_ELLIPSES = 8;

    [NativeTypeName("#define CC_WIDE 16")]
    public const int CC_WIDE = 16;

    [NativeTypeName("#define CC_STYLED 32")]
    public const int CC_STYLED = 32;

    [NativeTypeName("#define CC_WIDESTYLED 64")]
    public const int CC_WIDESTYLED = 64;

    [NativeTypeName("#define CC_INTERIORS 128")]
    public const int CC_INTERIORS = 128;

    [NativeTypeName("#define CC_ROUNDRECT 256")]
    public const int CC_ROUNDRECT = 256;
}
