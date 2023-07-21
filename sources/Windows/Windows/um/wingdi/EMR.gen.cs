// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public partial struct EMR
{
    /// <include file='EMR.xml' path='doc/member[@name="EMR.iType"]/*' />
    [NativeTypeName("DWORD")]
    public uint iType;

    /// <include file='EMR.xml' path='doc/member[@name="EMR.nSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint nSize;

    [NativeTypeName("#define EMR_HEADER 1")]
    public const int EMR_HEADER = 1;

    [NativeTypeName("#define EMR_POLYBEZIER 2")]
    public const int EMR_POLYBEZIER = 2;

    [NativeTypeName("#define EMR_POLYGON 3")]
    public const int EMR_POLYGON = 3;

    [NativeTypeName("#define EMR_POLYLINE 4")]
    public const int EMR_POLYLINE = 4;

    [NativeTypeName("#define EMR_POLYBEZIERTO 5")]
    public const int EMR_POLYBEZIERTO = 5;

    [NativeTypeName("#define EMR_POLYLINETO 6")]
    public const int EMR_POLYLINETO = 6;

    [NativeTypeName("#define EMR_POLYPOLYLINE 7")]
    public const int EMR_POLYPOLYLINE = 7;

    [NativeTypeName("#define EMR_POLYPOLYGON 8")]
    public const int EMR_POLYPOLYGON = 8;

    [NativeTypeName("#define EMR_SETWINDOWEXTEX 9")]
    public const int EMR_SETWINDOWEXTEX = 9;

    [NativeTypeName("#define EMR_SETWINDOWORGEX 10")]
    public const int EMR_SETWINDOWORGEX = 10;

    [NativeTypeName("#define EMR_SETVIEWPORTEXTEX 11")]
    public const int EMR_SETVIEWPORTEXTEX = 11;

    [NativeTypeName("#define EMR_SETVIEWPORTORGEX 12")]
    public const int EMR_SETVIEWPORTORGEX = 12;

    [NativeTypeName("#define EMR_SETBRUSHORGEX 13")]
    public const int EMR_SETBRUSHORGEX = 13;

    [NativeTypeName("#define EMR_EOF 14")]
    public const int EMR_EOF = 14;

    [NativeTypeName("#define EMR_SETPIXELV 15")]
    public const int EMR_SETPIXELV = 15;

    [NativeTypeName("#define EMR_SETMAPPERFLAGS 16")]
    public const int EMR_SETMAPPERFLAGS = 16;

    [NativeTypeName("#define EMR_SETMAPMODE 17")]
    public const int EMR_SETMAPMODE = 17;

    [NativeTypeName("#define EMR_SETBKMODE 18")]
    public const int EMR_SETBKMODE = 18;

    [NativeTypeName("#define EMR_SETPOLYFILLMODE 19")]
    public const int EMR_SETPOLYFILLMODE = 19;

    [NativeTypeName("#define EMR_SETROP2 20")]
    public const int EMR_SETROP2 = 20;

    [NativeTypeName("#define EMR_SETSTRETCHBLTMODE 21")]
    public const int EMR_SETSTRETCHBLTMODE = 21;

    [NativeTypeName("#define EMR_SETTEXTALIGN 22")]
    public const int EMR_SETTEXTALIGN = 22;

    [NativeTypeName("#define EMR_SETCOLORADJUSTMENT 23")]
    public const int EMR_SETCOLORADJUSTMENT = 23;

    [NativeTypeName("#define EMR_SETTEXTCOLOR 24")]
    public const int EMR_SETTEXTCOLOR = 24;

    [NativeTypeName("#define EMR_SETBKCOLOR 25")]
    public const int EMR_SETBKCOLOR = 25;

    [NativeTypeName("#define EMR_OFFSETCLIPRGN 26")]
    public const int EMR_OFFSETCLIPRGN = 26;

    [NativeTypeName("#define EMR_MOVETOEX 27")]
    public const int EMR_MOVETOEX = 27;

    [NativeTypeName("#define EMR_SETMETARGN 28")]
    public const int EMR_SETMETARGN = 28;

    [NativeTypeName("#define EMR_EXCLUDECLIPRECT 29")]
    public const int EMR_EXCLUDECLIPRECT = 29;

    [NativeTypeName("#define EMR_INTERSECTCLIPRECT 30")]
    public const int EMR_INTERSECTCLIPRECT = 30;

    [NativeTypeName("#define EMR_SCALEVIEWPORTEXTEX 31")]
    public const int EMR_SCALEVIEWPORTEXTEX = 31;

    [NativeTypeName("#define EMR_SCALEWINDOWEXTEX 32")]
    public const int EMR_SCALEWINDOWEXTEX = 32;

    [NativeTypeName("#define EMR_SAVEDC 33")]
    public const int EMR_SAVEDC = 33;

    [NativeTypeName("#define EMR_RESTOREDC 34")]
    public const int EMR_RESTOREDC = 34;

    [NativeTypeName("#define EMR_SETWORLDTRANSFORM 35")]
    public const int EMR_SETWORLDTRANSFORM = 35;

    [NativeTypeName("#define EMR_MODIFYWORLDTRANSFORM 36")]
    public const int EMR_MODIFYWORLDTRANSFORM = 36;

    [NativeTypeName("#define EMR_SELECTOBJECT 37")]
    public const int EMR_SELECTOBJECT = 37;

    [NativeTypeName("#define EMR_CREATEPEN 38")]
    public const int EMR_CREATEPEN = 38;

    [NativeTypeName("#define EMR_CREATEBRUSHINDIRECT 39")]
    public const int EMR_CREATEBRUSHINDIRECT = 39;

    [NativeTypeName("#define EMR_DELETEOBJECT 40")]
    public const int EMR_DELETEOBJECT = 40;

    [NativeTypeName("#define EMR_ANGLEARC 41")]
    public const int EMR_ANGLEARC = 41;

    [NativeTypeName("#define EMR_ELLIPSE 42")]
    public const int EMR_ELLIPSE = 42;

    [NativeTypeName("#define EMR_RECTANGLE 43")]
    public const int EMR_RECTANGLE = 43;

    [NativeTypeName("#define EMR_ROUNDRECT 44")]
    public const int EMR_ROUNDRECT = 44;

    [NativeTypeName("#define EMR_ARC 45")]
    public const int EMR_ARC = 45;

    [NativeTypeName("#define EMR_CHORD 46")]
    public const int EMR_CHORD = 46;

    [NativeTypeName("#define EMR_PIE 47")]
    public const int EMR_PIE = 47;

    [NativeTypeName("#define EMR_SELECTPALETTE 48")]
    public const int EMR_SELECTPALETTE = 48;

    [NativeTypeName("#define EMR_CREATEPALETTE 49")]
    public const int EMR_CREATEPALETTE = 49;

    [NativeTypeName("#define EMR_SETPALETTEENTRIES 50")]
    public const int EMR_SETPALETTEENTRIES = 50;

    [NativeTypeName("#define EMR_RESIZEPALETTE 51")]
    public const int EMR_RESIZEPALETTE = 51;

    [NativeTypeName("#define EMR_REALIZEPALETTE 52")]
    public const int EMR_REALIZEPALETTE = 52;

    [NativeTypeName("#define EMR_EXTFLOODFILL 53")]
    public const int EMR_EXTFLOODFILL = 53;

    [NativeTypeName("#define EMR_LINETO 54")]
    public const int EMR_LINETO = 54;

    [NativeTypeName("#define EMR_ARCTO 55")]
    public const int EMR_ARCTO = 55;

    [NativeTypeName("#define EMR_POLYDRAW 56")]
    public const int EMR_POLYDRAW = 56;

    [NativeTypeName("#define EMR_SETARCDIRECTION 57")]
    public const int EMR_SETARCDIRECTION = 57;

    [NativeTypeName("#define EMR_SETMITERLIMIT 58")]
    public const int EMR_SETMITERLIMIT = 58;

    [NativeTypeName("#define EMR_BEGINPATH 59")]
    public const int EMR_BEGINPATH = 59;

    [NativeTypeName("#define EMR_ENDPATH 60")]
    public const int EMR_ENDPATH = 60;

    [NativeTypeName("#define EMR_CLOSEFIGURE 61")]
    public const int EMR_CLOSEFIGURE = 61;

    [NativeTypeName("#define EMR_FILLPATH 62")]
    public const int EMR_FILLPATH = 62;

    [NativeTypeName("#define EMR_STROKEANDFILLPATH 63")]
    public const int EMR_STROKEANDFILLPATH = 63;

    [NativeTypeName("#define EMR_STROKEPATH 64")]
    public const int EMR_STROKEPATH = 64;

    [NativeTypeName("#define EMR_FLATTENPATH 65")]
    public const int EMR_FLATTENPATH = 65;

    [NativeTypeName("#define EMR_WIDENPATH 66")]
    public const int EMR_WIDENPATH = 66;

    [NativeTypeName("#define EMR_SELECTCLIPPATH 67")]
    public const int EMR_SELECTCLIPPATH = 67;

    [NativeTypeName("#define EMR_ABORTPATH 68")]
    public const int EMR_ABORTPATH = 68;

    [NativeTypeName("#define EMR_GDICOMMENT 70")]
    public const int EMR_GDICOMMENT = 70;

    [NativeTypeName("#define EMR_FILLRGN 71")]
    public const int EMR_FILLRGN = 71;

    [NativeTypeName("#define EMR_FRAMERGN 72")]
    public const int EMR_FRAMERGN = 72;

    [NativeTypeName("#define EMR_INVERTRGN 73")]
    public const int EMR_INVERTRGN = 73;

    [NativeTypeName("#define EMR_PAINTRGN 74")]
    public const int EMR_PAINTRGN = 74;

    [NativeTypeName("#define EMR_EXTSELECTCLIPRGN 75")]
    public const int EMR_EXTSELECTCLIPRGN = 75;

    [NativeTypeName("#define EMR_BITBLT 76")]
    public const int EMR_BITBLT = 76;

    [NativeTypeName("#define EMR_STRETCHBLT 77")]
    public const int EMR_STRETCHBLT = 77;

    [NativeTypeName("#define EMR_MASKBLT 78")]
    public const int EMR_MASKBLT = 78;

    [NativeTypeName("#define EMR_PLGBLT 79")]
    public const int EMR_PLGBLT = 79;

    [NativeTypeName("#define EMR_SETDIBITSTODEVICE 80")]
    public const int EMR_SETDIBITSTODEVICE = 80;

    [NativeTypeName("#define EMR_STRETCHDIBITS 81")]
    public const int EMR_STRETCHDIBITS = 81;

    [NativeTypeName("#define EMR_EXTCREATEFONTINDIRECTW 82")]
    public const int EMR_EXTCREATEFONTINDIRECTW = 82;

    [NativeTypeName("#define EMR_EXTTEXTOUTA 83")]
    public const int EMR_EXTTEXTOUTA = 83;

    [NativeTypeName("#define EMR_EXTTEXTOUTW 84")]
    public const int EMR_EXTTEXTOUTW = 84;

    [NativeTypeName("#define EMR_POLYBEZIER16 85")]
    public const int EMR_POLYBEZIER16 = 85;

    [NativeTypeName("#define EMR_POLYGON16 86")]
    public const int EMR_POLYGON16 = 86;

    [NativeTypeName("#define EMR_POLYLINE16 87")]
    public const int EMR_POLYLINE16 = 87;

    [NativeTypeName("#define EMR_POLYBEZIERTO16 88")]
    public const int EMR_POLYBEZIERTO16 = 88;

    [NativeTypeName("#define EMR_POLYLINETO16 89")]
    public const int EMR_POLYLINETO16 = 89;

    [NativeTypeName("#define EMR_POLYPOLYLINE16 90")]
    public const int EMR_POLYPOLYLINE16 = 90;

    [NativeTypeName("#define EMR_POLYPOLYGON16 91")]
    public const int EMR_POLYPOLYGON16 = 91;

    [NativeTypeName("#define EMR_POLYDRAW16 92")]
    public const int EMR_POLYDRAW16 = 92;

    [NativeTypeName("#define EMR_CREATEMONOBRUSH 93")]
    public const int EMR_CREATEMONOBRUSH = 93;

    [NativeTypeName("#define EMR_CREATEDIBPATTERNBRUSHPT 94")]
    public const int EMR_CREATEDIBPATTERNBRUSHPT = 94;

    [NativeTypeName("#define EMR_EXTCREATEPEN 95")]
    public const int EMR_EXTCREATEPEN = 95;

    [NativeTypeName("#define EMR_POLYTEXTOUTA 96")]
    public const int EMR_POLYTEXTOUTA = 96;

    [NativeTypeName("#define EMR_POLYTEXTOUTW 97")]
    public const int EMR_POLYTEXTOUTW = 97;

    [NativeTypeName("#define EMR_SETICMMODE 98")]
    public const int EMR_SETICMMODE = 98;

    [NativeTypeName("#define EMR_CREATECOLORSPACE 99")]
    public const int EMR_CREATECOLORSPACE = 99;

    [NativeTypeName("#define EMR_SETCOLORSPACE 100")]
    public const int EMR_SETCOLORSPACE = 100;

    [NativeTypeName("#define EMR_DELETECOLORSPACE 101")]
    public const int EMR_DELETECOLORSPACE = 101;

    [NativeTypeName("#define EMR_GLSRECORD 102")]
    public const int EMR_GLSRECORD = 102;

    [NativeTypeName("#define EMR_GLSBOUNDEDRECORD 103")]
    public const int EMR_GLSBOUNDEDRECORD = 103;

    [NativeTypeName("#define EMR_PIXELFORMAT 104")]
    public const int EMR_PIXELFORMAT = 104;

    [NativeTypeName("#define EMR_RESERVED_105 105")]
    public const int EMR_RESERVED_105 = 105;

    [NativeTypeName("#define EMR_RESERVED_106 106")]
    public const int EMR_RESERVED_106 = 106;

    [NativeTypeName("#define EMR_RESERVED_107 107")]
    public const int EMR_RESERVED_107 = 107;

    [NativeTypeName("#define EMR_RESERVED_108 108")]
    public const int EMR_RESERVED_108 = 108;

    [NativeTypeName("#define EMR_RESERVED_109 109")]
    public const int EMR_RESERVED_109 = 109;

    [NativeTypeName("#define EMR_RESERVED_110 110")]
    public const int EMR_RESERVED_110 = 110;

    [NativeTypeName("#define EMR_COLORCORRECTPALETTE 111")]
    public const int EMR_COLORCORRECTPALETTE = 111;

    [NativeTypeName("#define EMR_SETICMPROFILEA 112")]
    public const int EMR_SETICMPROFILEA = 112;

    [NativeTypeName("#define EMR_SETICMPROFILEW 113")]
    public const int EMR_SETICMPROFILEW = 113;

    [NativeTypeName("#define EMR_ALPHABLEND 114")]
    public const int EMR_ALPHABLEND = 114;

    [NativeTypeName("#define EMR_SETLAYOUT 115")]
    public const int EMR_SETLAYOUT = 115;

    [NativeTypeName("#define EMR_TRANSPARENTBLT 116")]
    public const int EMR_TRANSPARENTBLT = 116;

    [NativeTypeName("#define EMR_RESERVED_117 117")]
    public const int EMR_RESERVED_117 = 117;

    [NativeTypeName("#define EMR_GRADIENTFILL 118")]
    public const int EMR_GRADIENTFILL = 118;

    [NativeTypeName("#define EMR_RESERVED_119 119")]
    public const int EMR_RESERVED_119 = 119;

    [NativeTypeName("#define EMR_RESERVED_120 120")]
    public const int EMR_RESERVED_120 = 120;

    [NativeTypeName("#define EMR_COLORMATCHTOTARGETW 121")]
    public const int EMR_COLORMATCHTOTARGETW = 121;

    [NativeTypeName("#define EMR_CREATECOLORSPACEW 122")]
    public const int EMR_CREATECOLORSPACEW = 122;

    [NativeTypeName("#define EMR_MIN 1")]
    public const int EMR_MIN = 1;

    [NativeTypeName("#define EMR_MAX 122")]
    public const int EMR_MAX = 122;
}
