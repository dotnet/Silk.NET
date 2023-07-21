// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class Windows
{
    [NativeTypeName("#define ROT_COMPARE_MAX 2048")]
    public const int ROT_COMPARE_MAX = 2048;

    [NativeTypeName("#define WDT_INPROC_CALL ( 0x48746457 )")]
    public const int WDT_INPROC_CALL = (0x48746457);

    [NativeTypeName("#define WDT_REMOTE_CALL ( 0x52746457 )")]
    public const int WDT_REMOTE_CALL = (0x52746457);

    [NativeTypeName("#define WDT_INPROC64_CALL ( 0x50746457 )")]
    public const int WDT_INPROC64_CALL = (0x50746457);

    [NativeTypeName("#define DECIMAL_NEG ((BYTE)0x80)")]
    public const byte DECIMAL_NEG = ((byte)(0x80));

    [NativeTypeName("#define VARIANT_TRUE ((VARIANT_BOOL)-1)")]
    public const short VARIANT_TRUE = ((short)(-1));

    [NativeTypeName("#define VARIANT_FALSE ((VARIANT_BOOL)0)")]
    public const short VARIANT_FALSE = ((short)(0));
}
