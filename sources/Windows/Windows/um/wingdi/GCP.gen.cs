// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class GCP
{
    [NativeTypeName("#define GCP_DBCS 0x0001")]
    public const int GCP_DBCS = 0x0001;

    [NativeTypeName("#define GCP_REORDER 0x0002")]
    public const int GCP_REORDER = 0x0002;

    [NativeTypeName("#define GCP_USEKERNING 0x0008")]
    public const int GCP_USEKERNING = 0x0008;

    [NativeTypeName("#define GCP_GLYPHSHAPE 0x0010")]
    public const int GCP_GLYPHSHAPE = 0x0010;

    [NativeTypeName("#define GCP_LIGATE 0x0020")]
    public const int GCP_LIGATE = 0x0020;

    [NativeTypeName("#define GCP_DIACRITIC 0x0100")]
    public const int GCP_DIACRITIC = 0x0100;

    [NativeTypeName("#define GCP_KASHIDA 0x0400")]
    public const int GCP_KASHIDA = 0x0400;

    [NativeTypeName("#define GCP_ERROR 0x8000")]
    public const int GCP_ERROR = 0x8000;

    [NativeTypeName("#define GCP_JUSTIFY 0x00010000L")]
    public const int GCP_JUSTIFY = 0x00010000;

    [NativeTypeName("#define GCP_CLASSIN 0x00080000L")]
    public const int GCP_CLASSIN = 0x00080000;

    [NativeTypeName("#define GCP_MAXEXTENT 0x00100000L")]
    public const int GCP_MAXEXTENT = 0x00100000;

    [NativeTypeName("#define GCP_JUSTIFYIN 0x00200000L")]
    public const int GCP_JUSTIFYIN = 0x00200000;

    [NativeTypeName("#define GCP_DISPLAYZWG 0x00400000L")]
    public const int GCP_DISPLAYZWG = 0x00400000;

    [NativeTypeName("#define GCP_SYMSWAPOFF 0x00800000L")]
    public const int GCP_SYMSWAPOFF = 0x00800000;

    [NativeTypeName("#define GCP_NUMERICOVERRIDE 0x01000000L")]
    public const int GCP_NUMERICOVERRIDE = 0x01000000;

    [NativeTypeName("#define GCP_NEUTRALOVERRIDE 0x02000000L")]
    public const int GCP_NEUTRALOVERRIDE = 0x02000000;

    [NativeTypeName("#define GCP_NUMERICSLATIN 0x04000000L")]
    public const int GCP_NUMERICSLATIN = 0x04000000;

    [NativeTypeName("#define GCP_NUMERICSLOCAL 0x08000000L")]
    public const int GCP_NUMERICSLOCAL = 0x08000000;
}
