// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class DC
{
    [NativeTypeName("#define DC_BRUSH 18")]
    public const int DC_BRUSH = 18;

    [NativeTypeName("#define DC_PEN 19")]
    public const int DC_PEN = 19;

    [NativeTypeName("#define DC_FIELDS 1")]
    public const int DC_FIELDS = 1;

    [NativeTypeName("#define DC_PAPERS 2")]
    public const int DC_PAPERS = 2;

    [NativeTypeName("#define DC_PAPERSIZE 3")]
    public const int DC_PAPERSIZE = 3;

    [NativeTypeName("#define DC_MINEXTENT 4")]
    public const int DC_MINEXTENT = 4;

    [NativeTypeName("#define DC_MAXEXTENT 5")]
    public const int DC_MAXEXTENT = 5;

    [NativeTypeName("#define DC_BINS 6")]
    public const int DC_BINS = 6;

    [NativeTypeName("#define DC_DUPLEX 7")]
    public const int DC_DUPLEX = 7;

    [NativeTypeName("#define DC_SIZE 8")]
    public const int DC_SIZE = 8;

    [NativeTypeName("#define DC_EXTRA 9")]
    public const int DC_EXTRA = 9;

    [NativeTypeName("#define DC_VERSION 10")]
    public const int DC_VERSION = 10;

    [NativeTypeName("#define DC_DRIVER 11")]
    public const int DC_DRIVER = 11;

    [NativeTypeName("#define DC_BINNAMES 12")]
    public const int DC_BINNAMES = 12;

    [NativeTypeName("#define DC_ENUMRESOLUTIONS 13")]
    public const int DC_ENUMRESOLUTIONS = 13;

    [NativeTypeName("#define DC_FILEDEPENDENCIES 14")]
    public const int DC_FILEDEPENDENCIES = 14;

    [NativeTypeName("#define DC_TRUETYPE 15")]
    public const int DC_TRUETYPE = 15;

    [NativeTypeName("#define DC_PAPERNAMES 16")]
    public const int DC_PAPERNAMES = 16;

    [NativeTypeName("#define DC_ORIENTATION 17")]
    public const int DC_ORIENTATION = 17;

    [NativeTypeName("#define DC_COPIES 18")]
    public const int DC_COPIES = 18;

    [NativeTypeName("#define DC_BINADJUST 19")]
    public const int DC_BINADJUST = 19;

    [NativeTypeName("#define DC_EMF_COMPLIANT 20")]
    public const int DC_EMF_COMPLIANT = 20;

    [NativeTypeName("#define DC_DATATYPE_PRODUCED 21")]
    public const int DC_DATATYPE_PRODUCED = 21;

    [NativeTypeName("#define DC_COLLATE 22")]
    public const int DC_COLLATE = 22;

    [NativeTypeName("#define DC_MANUFACTURER 23")]
    public const int DC_MANUFACTURER = 23;

    [NativeTypeName("#define DC_MODEL 24")]
    public const int DC_MODEL = 24;

    [NativeTypeName("#define DC_PERSONALITY 25")]
    public const int DC_PERSONALITY = 25;

    [NativeTypeName("#define DC_PRINTRATE 26")]
    public const int DC_PRINTRATE = 26;

    [NativeTypeName("#define DC_PRINTRATEUNIT 27")]
    public const int DC_PRINTRATEUNIT = 27;

    [NativeTypeName("#define DC_PRINTERMEM 28")]
    public const int DC_PRINTERMEM = 28;

    [NativeTypeName("#define DC_MEDIAREADY 29")]
    public const int DC_MEDIAREADY = 29;

    [NativeTypeName("#define DC_STAPLE 30")]
    public const int DC_STAPLE = 30;

    [NativeTypeName("#define DC_PRINTRATEPPM 31")]
    public const int DC_PRINTRATEPPM = 31;

    [NativeTypeName("#define DC_COLORDEVICE 32")]
    public const int DC_COLORDEVICE = 32;

    [NativeTypeName("#define DC_NUP 33")]
    public const int DC_NUP = 33;

    [NativeTypeName("#define DC_MEDIATYPENAMES 34")]
    public const int DC_MEDIATYPENAMES = 34;

    [NativeTypeName("#define DC_MEDIATYPES 35")]
    public const int DC_MEDIATYPES = 35;
}
