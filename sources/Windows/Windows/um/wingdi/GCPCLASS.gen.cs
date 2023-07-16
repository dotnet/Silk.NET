// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class GCPCLASS
{
    [NativeTypeName("#define GCPCLASS_LATIN 1")]
    public const int GCPCLASS_LATIN = 1;
    [NativeTypeName("#define GCPCLASS_HEBREW 2")]
    public const int GCPCLASS_HEBREW = 2;
    [NativeTypeName("#define GCPCLASS_ARABIC 2")]
    public const int GCPCLASS_ARABIC = 2;
    [NativeTypeName("#define GCPCLASS_NEUTRAL 3")]
    public const int GCPCLASS_NEUTRAL = 3;
    [NativeTypeName("#define GCPCLASS_LOCALNUMBER 4")]
    public const int GCPCLASS_LOCALNUMBER = 4;
    [NativeTypeName("#define GCPCLASS_LATINNUMBER 5")]
    public const int GCPCLASS_LATINNUMBER = 5;
    [NativeTypeName("#define GCPCLASS_LATINNUMERICTERMINATOR 6")]
    public const int GCPCLASS_LATINNUMERICTERMINATOR = 6;
    [NativeTypeName("#define GCPCLASS_LATINNUMERICSEPARATOR 7")]
    public const int GCPCLASS_LATINNUMERICSEPARATOR = 7;
    [NativeTypeName("#define GCPCLASS_NUMERICSEPARATOR 8")]
    public const int GCPCLASS_NUMERICSEPARATOR = 8;
    [NativeTypeName("#define GCPCLASS_PREBOUNDLTR 0x80")]
    public const int GCPCLASS_PREBOUNDLTR = 0x80;
    [NativeTypeName("#define GCPCLASS_PREBOUNDRTL 0x40")]
    public const int GCPCLASS_PREBOUNDRTL = 0x40;
    [NativeTypeName("#define GCPCLASS_POSTBOUNDLTR 0x20")]
    public const int GCPCLASS_POSTBOUNDLTR = 0x20;
    [NativeTypeName("#define GCPCLASS_POSTBOUNDRTL 0x10")]
    public const int GCPCLASS_POSTBOUNDRTL = 0x10;
}