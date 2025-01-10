// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using static Silk.NET.Windows.VARENUM;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class VTBIT
{
    [NativeTypeName("#define VTBIT_I1 (1 << VT_I1)")]
    public const int VTBIT_I1 = (1 << (int)(VT_I1));

    [NativeTypeName("#define VTBIT_UI1 (1 << VT_UI1)")]
    public const int VTBIT_UI1 = (1 << (int)(VT_UI1));

    [NativeTypeName("#define VTBIT_I2 (1 << VT_I2)")]
    public const int VTBIT_I2 = (1 << (int)(VT_I2));

    [NativeTypeName("#define VTBIT_UI2 (1 << VT_UI2)")]
    public const int VTBIT_UI2 = (1 << (int)(VT_UI2));

    [NativeTypeName("#define VTBIT_I4 (1 << VT_I4)")]
    public const int VTBIT_I4 = (1 << (int)(VT_I4));

    [NativeTypeName("#define VTBIT_UI4 (1 << VT_UI4)")]
    public const int VTBIT_UI4 = (1 << (int)(VT_UI4));

    [NativeTypeName("#define VTBIT_I8 (1 << VT_I8)")]
    public const int VTBIT_I8 = (1 << (int)(VT_I8));

    [NativeTypeName("#define VTBIT_UI8 (1 << VT_UI8)")]
    public const int VTBIT_UI8 = (1 << (int)(VT_UI8));

    [NativeTypeName("#define VTBIT_R4 (1 << VT_R4)")]
    public const int VTBIT_R4 = (1 << (int)(VT_R4));

    [NativeTypeName("#define VTBIT_R8 (1 << VT_R8)")]
    public const int VTBIT_R8 = (1 << (int)(VT_R8));

    [NativeTypeName("#define VTBIT_CY (1 << VT_CY)")]
    public const int VTBIT_CY = (1 << (int)(VT_CY));

    [NativeTypeName("#define VTBIT_DECIMAL (1 << VT_DECIMAL)")]
    public const int VTBIT_DECIMAL = (1 << (int)(VT_DECIMAL));
}
