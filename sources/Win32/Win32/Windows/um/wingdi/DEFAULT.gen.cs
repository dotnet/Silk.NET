// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DEFAULT
{
    [NativeTypeName("#define DEFAULT_QUALITY 0")]
    public const int DEFAULT_QUALITY = 0;

    [NativeTypeName("#define DEFAULT_PITCH 0")]
    public const int DEFAULT_PITCH = 0;

    [NativeTypeName("#define DEFAULT_CHARSET 1")]
    public const int DEFAULT_CHARSET = 1;

    [NativeTypeName("#define DEFAULT_PALETTE 15")]
    public const int DEFAULT_PALETTE = 15;

    [NativeTypeName("#define DEFAULT_GUI_FONT 17")]
    public const int DEFAULT_GUI_FONT = 17;
}
