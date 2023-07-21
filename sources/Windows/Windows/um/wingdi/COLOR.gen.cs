// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public partial struct COLOR
{
    [NativeTypeName("#define COLOR_ADJ_MIN (SHORT)-100")]
    public const short COLOR_ADJ_MIN = (short)(-100);

    [NativeTypeName("#define COLOR_ADJ_MAX (SHORT)100")]
    public const short COLOR_ADJ_MAX = (short)(100);
}
