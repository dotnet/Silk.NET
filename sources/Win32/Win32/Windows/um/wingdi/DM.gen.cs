// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class DM
{
    [NativeTypeName("#define DM_SPECVERSION 0x0401")]
    public const int DM_SPECVERSION = 0x0401;

    [NativeTypeName("#define DM_ORIENTATION 0x00000001L")]
    public const int DM_ORIENTATION = 0x00000001;

    [NativeTypeName("#define DM_PAPERSIZE 0x00000002L")]
    public const int DM_PAPERSIZE = 0x00000002;

    [NativeTypeName("#define DM_PAPERLENGTH 0x00000004L")]
    public const int DM_PAPERLENGTH = 0x00000004;

    [NativeTypeName("#define DM_PAPERWIDTH 0x00000008L")]
    public const int DM_PAPERWIDTH = 0x00000008;

    [NativeTypeName("#define DM_SCALE 0x00000010L")]
    public const int DM_SCALE = 0x00000010;

    [NativeTypeName("#define DM_POSITION 0x00000020L")]
    public const int DM_POSITION = 0x00000020;

    [NativeTypeName("#define DM_NUP 0x00000040L")]
    public const int DM_NUP = 0x00000040;

    [NativeTypeName("#define DM_DISPLAYORIENTATION 0x00000080L")]
    public const int DM_DISPLAYORIENTATION = 0x00000080;

    [NativeTypeName("#define DM_COPIES 0x00000100L")]
    public const int DM_COPIES = 0x00000100;

    [NativeTypeName("#define DM_DEFAULTSOURCE 0x00000200L")]
    public const int DM_DEFAULTSOURCE = 0x00000200;

    [NativeTypeName("#define DM_PRINTQUALITY 0x00000400L")]
    public const int DM_PRINTQUALITY = 0x00000400;

    [NativeTypeName("#define DM_COLOR 0x00000800L")]
    public const int DM_COLOR = 0x00000800;

    [NativeTypeName("#define DM_DUPLEX 0x00001000L")]
    public const int DM_DUPLEX = 0x00001000;

    [NativeTypeName("#define DM_YRESOLUTION 0x00002000L")]
    public const int DM_YRESOLUTION = 0x00002000;

    [NativeTypeName("#define DM_TTOPTION 0x00004000L")]
    public const int DM_TTOPTION = 0x00004000;

    [NativeTypeName("#define DM_COLLATE 0x00008000L")]
    public const int DM_COLLATE = 0x00008000;

    [NativeTypeName("#define DM_FORMNAME 0x00010000L")]
    public const int DM_FORMNAME = 0x00010000;

    [NativeTypeName("#define DM_LOGPIXELS 0x00020000L")]
    public const int DM_LOGPIXELS = 0x00020000;

    [NativeTypeName("#define DM_BITSPERPEL 0x00040000L")]
    public const int DM_BITSPERPEL = 0x00040000;

    [NativeTypeName("#define DM_PELSWIDTH 0x00080000L")]
    public const int DM_PELSWIDTH = 0x00080000;

    [NativeTypeName("#define DM_PELSHEIGHT 0x00100000L")]
    public const int DM_PELSHEIGHT = 0x00100000;

    [NativeTypeName("#define DM_DISPLAYFLAGS 0x00200000L")]
    public const int DM_DISPLAYFLAGS = 0x00200000;

    [NativeTypeName("#define DM_DISPLAYFREQUENCY 0x00400000L")]
    public const int DM_DISPLAYFREQUENCY = 0x00400000;

    [NativeTypeName("#define DM_ICMMETHOD 0x00800000L")]
    public const int DM_ICMMETHOD = 0x00800000;

    [NativeTypeName("#define DM_ICMINTENT 0x01000000L")]
    public const int DM_ICMINTENT = 0x01000000;

    [NativeTypeName("#define DM_MEDIATYPE 0x02000000L")]
    public const int DM_MEDIATYPE = 0x02000000;

    [NativeTypeName("#define DM_DITHERTYPE 0x04000000L")]
    public const int DM_DITHERTYPE = 0x04000000;

    [NativeTypeName("#define DM_PANNINGWIDTH 0x08000000L")]
    public const int DM_PANNINGWIDTH = 0x08000000;

    [NativeTypeName("#define DM_PANNINGHEIGHT 0x10000000L")]
    public const int DM_PANNINGHEIGHT = 0x10000000;

    [NativeTypeName("#define DM_DISPLAYFIXEDOUTPUT 0x20000000L")]
    public const int DM_DISPLAYFIXEDOUTPUT = 0x20000000;

    [NativeTypeName("#define DM_INTERLACED 0x00000002")]
    public const int DM_INTERLACED = 0x00000002;

    [NativeTypeName("#define DM_UPDATE 1")]
    public const int DM_UPDATE = 1;

    [NativeTypeName("#define DM_COPY 2")]
    public const int DM_COPY = 2;

    [NativeTypeName("#define DM_PROMPT 4")]
    public const int DM_PROMPT = 4;

    [NativeTypeName("#define DM_MODIFY 8")]
    public const int DM_MODIFY = 8;

    [NativeTypeName("#define DM_IN_BUFFER DM_MODIFY")]
    public const int DM_IN_BUFFER = 8;

    [NativeTypeName("#define DM_IN_PROMPT DM_PROMPT")]
    public const int DM_IN_PROMPT = 4;

    [NativeTypeName("#define DM_OUT_BUFFER DM_COPY")]
    public const int DM_OUT_BUFFER = 2;

    [NativeTypeName("#define DM_OUT_DEFAULT DM_UPDATE")]
    public const int DM_OUT_DEFAULT = 1;
}
