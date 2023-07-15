// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class BS
{
    [NativeTypeName("#define BS_SOLID 0")]
    public const int BS_SOLID = 0;
    [NativeTypeName("#define BS_NULL 1")]
    public const int BS_NULL = 1;
    [NativeTypeName("#define BS_HOLLOW BS_NULL")]
    public const int BS_HOLLOW = 1;
    [NativeTypeName("#define BS_HATCHED 2")]
    public const int BS_HATCHED = 2;
    [NativeTypeName("#define BS_PATTERN 3")]
    public const int BS_PATTERN = 3;
    [NativeTypeName("#define BS_INDEXED 4")]
    public const int BS_INDEXED = 4;
    [NativeTypeName("#define BS_DIBPATTERN 5")]
    public const int BS_DIBPATTERN = 5;
    [NativeTypeName("#define BS_DIBPATTERNPT 6")]
    public const int BS_DIBPATTERNPT = 6;
    [NativeTypeName("#define BS_PATTERN8X8 7")]
    public const int BS_PATTERN8X8 = 7;
    [NativeTypeName("#define BS_DIBPATTERN8X8 8")]
    public const int BS_DIBPATTERN8X8 = 8;
    [NativeTypeName("#define BS_MONOPATTERN 9")]
    public const int BS_MONOPATTERN = 9;
}