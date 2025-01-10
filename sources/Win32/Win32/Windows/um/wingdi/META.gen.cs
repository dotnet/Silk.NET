// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class META
{
    [NativeTypeName("#define META_SETBKCOLOR 0x0201")]
    public const int META_SETBKCOLOR = 0x0201;

    [NativeTypeName("#define META_SETBKMODE 0x0102")]
    public const int META_SETBKMODE = 0x0102;

    [NativeTypeName("#define META_SETMAPMODE 0x0103")]
    public const int META_SETMAPMODE = 0x0103;

    [NativeTypeName("#define META_SETROP2 0x0104")]
    public const int META_SETROP2 = 0x0104;

    [NativeTypeName("#define META_SETRELABS 0x0105")]
    public const int META_SETRELABS = 0x0105;

    [NativeTypeName("#define META_SETPOLYFILLMODE 0x0106")]
    public const int META_SETPOLYFILLMODE = 0x0106;

    [NativeTypeName("#define META_SETSTRETCHBLTMODE 0x0107")]
    public const int META_SETSTRETCHBLTMODE = 0x0107;

    [NativeTypeName("#define META_SETTEXTCHAREXTRA 0x0108")]
    public const int META_SETTEXTCHAREXTRA = 0x0108;

    [NativeTypeName("#define META_SETTEXTCOLOR 0x0209")]
    public const int META_SETTEXTCOLOR = 0x0209;

    [NativeTypeName("#define META_SETTEXTJUSTIFICATION 0x020A")]
    public const int META_SETTEXTJUSTIFICATION = 0x020A;

    [NativeTypeName("#define META_SETWINDOWORG 0x020B")]
    public const int META_SETWINDOWORG = 0x020B;

    [NativeTypeName("#define META_SETWINDOWEXT 0x020C")]
    public const int META_SETWINDOWEXT = 0x020C;

    [NativeTypeName("#define META_SETVIEWPORTORG 0x020D")]
    public const int META_SETVIEWPORTORG = 0x020D;

    [NativeTypeName("#define META_SETVIEWPORTEXT 0x020E")]
    public const int META_SETVIEWPORTEXT = 0x020E;

    [NativeTypeName("#define META_OFFSETWINDOWORG 0x020F")]
    public const int META_OFFSETWINDOWORG = 0x020F;

    [NativeTypeName("#define META_SCALEWINDOWEXT 0x0410")]
    public const int META_SCALEWINDOWEXT = 0x0410;

    [NativeTypeName("#define META_OFFSETVIEWPORTORG 0x0211")]
    public const int META_OFFSETVIEWPORTORG = 0x0211;

    [NativeTypeName("#define META_SCALEVIEWPORTEXT 0x0412")]
    public const int META_SCALEVIEWPORTEXT = 0x0412;

    [NativeTypeName("#define META_LINETO 0x0213")]
    public const int META_LINETO = 0x0213;

    [NativeTypeName("#define META_MOVETO 0x0214")]
    public const int META_MOVETO = 0x0214;

    [NativeTypeName("#define META_EXCLUDECLIPRECT 0x0415")]
    public const int META_EXCLUDECLIPRECT = 0x0415;

    [NativeTypeName("#define META_INTERSECTCLIPRECT 0x0416")]
    public const int META_INTERSECTCLIPRECT = 0x0416;

    [NativeTypeName("#define META_ARC 0x0817")]
    public const int META_ARC = 0x0817;

    [NativeTypeName("#define META_ELLIPSE 0x0418")]
    public const int META_ELLIPSE = 0x0418;

    [NativeTypeName("#define META_FLOODFILL 0x0419")]
    public const int META_FLOODFILL = 0x0419;

    [NativeTypeName("#define META_PIE 0x081A")]
    public const int META_PIE = 0x081A;

    [NativeTypeName("#define META_RECTANGLE 0x041B")]
    public const int META_RECTANGLE = 0x041B;

    [NativeTypeName("#define META_ROUNDRECT 0x061C")]
    public const int META_ROUNDRECT = 0x061C;

    [NativeTypeName("#define META_PATBLT 0x061D")]
    public const int META_PATBLT = 0x061D;

    [NativeTypeName("#define META_SAVEDC 0x001E")]
    public const int META_SAVEDC = 0x001E;

    [NativeTypeName("#define META_SETPIXEL 0x041F")]
    public const int META_SETPIXEL = 0x041F;

    [NativeTypeName("#define META_OFFSETCLIPRGN 0x0220")]
    public const int META_OFFSETCLIPRGN = 0x0220;

    [NativeTypeName("#define META_TEXTOUT 0x0521")]
    public const int META_TEXTOUT = 0x0521;

    [NativeTypeName("#define META_BITBLT 0x0922")]
    public const int META_BITBLT = 0x0922;

    [NativeTypeName("#define META_STRETCHBLT 0x0B23")]
    public const int META_STRETCHBLT = 0x0B23;

    [NativeTypeName("#define META_POLYGON 0x0324")]
    public const int META_POLYGON = 0x0324;

    [NativeTypeName("#define META_POLYLINE 0x0325")]
    public const int META_POLYLINE = 0x0325;

    [NativeTypeName("#define META_ESCAPE 0x0626")]
    public const int META_ESCAPE = 0x0626;

    [NativeTypeName("#define META_RESTOREDC 0x0127")]
    public const int META_RESTOREDC = 0x0127;

    [NativeTypeName("#define META_FILLREGION 0x0228")]
    public const int META_FILLREGION = 0x0228;

    [NativeTypeName("#define META_FRAMEREGION 0x0429")]
    public const int META_FRAMEREGION = 0x0429;

    [NativeTypeName("#define META_INVERTREGION 0x012A")]
    public const int META_INVERTREGION = 0x012A;

    [NativeTypeName("#define META_PAINTREGION 0x012B")]
    public const int META_PAINTREGION = 0x012B;

    [NativeTypeName("#define META_SELECTCLIPREGION 0x012C")]
    public const int META_SELECTCLIPREGION = 0x012C;

    [NativeTypeName("#define META_SELECTOBJECT 0x012D")]
    public const int META_SELECTOBJECT = 0x012D;

    [NativeTypeName("#define META_SETTEXTALIGN 0x012E")]
    public const int META_SETTEXTALIGN = 0x012E;

    [NativeTypeName("#define META_CHORD 0x0830")]
    public const int META_CHORD = 0x0830;

    [NativeTypeName("#define META_SETMAPPERFLAGS 0x0231")]
    public const int META_SETMAPPERFLAGS = 0x0231;

    [NativeTypeName("#define META_EXTTEXTOUT 0x0a32")]
    public const int META_EXTTEXTOUT = 0x0a32;

    [NativeTypeName("#define META_SETDIBTODEV 0x0d33")]
    public const int META_SETDIBTODEV = 0x0d33;

    [NativeTypeName("#define META_SELECTPALETTE 0x0234")]
    public const int META_SELECTPALETTE = 0x0234;

    [NativeTypeName("#define META_REALIZEPALETTE 0x0035")]
    public const int META_REALIZEPALETTE = 0x0035;

    [NativeTypeName("#define META_ANIMATEPALETTE 0x0436")]
    public const int META_ANIMATEPALETTE = 0x0436;

    [NativeTypeName("#define META_SETPALENTRIES 0x0037")]
    public const int META_SETPALENTRIES = 0x0037;

    [NativeTypeName("#define META_POLYPOLYGON 0x0538")]
    public const int META_POLYPOLYGON = 0x0538;

    [NativeTypeName("#define META_RESIZEPALETTE 0x0139")]
    public const int META_RESIZEPALETTE = 0x0139;

    [NativeTypeName("#define META_DIBBITBLT 0x0940")]
    public const int META_DIBBITBLT = 0x0940;

    [NativeTypeName("#define META_DIBSTRETCHBLT 0x0b41")]
    public const int META_DIBSTRETCHBLT = 0x0b41;

    [NativeTypeName("#define META_DIBCREATEPATTERNBRUSH 0x0142")]
    public const int META_DIBCREATEPATTERNBRUSH = 0x0142;

    [NativeTypeName("#define META_STRETCHDIB 0x0f43")]
    public const int META_STRETCHDIB = 0x0f43;

    [NativeTypeName("#define META_EXTFLOODFILL 0x0548")]
    public const int META_EXTFLOODFILL = 0x0548;

    [NativeTypeName("#define META_SETLAYOUT 0x0149")]
    public const int META_SETLAYOUT = 0x0149;

    [NativeTypeName("#define META_DELETEOBJECT 0x01f0")]
    public const int META_DELETEOBJECT = 0x01f0;

    [NativeTypeName("#define META_CREATEPALETTE 0x00f7")]
    public const int META_CREATEPALETTE = 0x00f7;

    [NativeTypeName("#define META_CREATEPATTERNBRUSH 0x01F9")]
    public const int META_CREATEPATTERNBRUSH = 0x01F9;

    [NativeTypeName("#define META_CREATEPENINDIRECT 0x02FA")]
    public const int META_CREATEPENINDIRECT = 0x02FA;

    [NativeTypeName("#define META_CREATEFONTINDIRECT 0x02FB")]
    public const int META_CREATEFONTINDIRECT = 0x02FB;

    [NativeTypeName("#define META_CREATEBRUSHINDIRECT 0x02FC")]
    public const int META_CREATEBRUSHINDIRECT = 0x02FC;

    [NativeTypeName("#define META_CREATEREGION 0x06FF")]
    public const int META_CREATEREGION = 0x06FF;
}
