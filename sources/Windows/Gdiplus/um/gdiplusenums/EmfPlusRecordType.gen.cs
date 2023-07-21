// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Gdiplus;

/// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType"]/*' />
public enum EmfPlusRecordType
{
    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetBkColor"]/*' />
    WmfRecordTypeSetBkColor = ((int)(EmfPlusRecordType)((0x0201) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetBkMode"]/*' />
    WmfRecordTypeSetBkMode = ((int)(EmfPlusRecordType)((0x0102) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetMapMode"]/*' />
    WmfRecordTypeSetMapMode = ((int)(EmfPlusRecordType)((0x0103) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetROP2"]/*' />
    WmfRecordTypeSetROP2 = ((int)(EmfPlusRecordType)((0x0104) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetRelAbs"]/*' />
    WmfRecordTypeSetRelAbs = ((int)(EmfPlusRecordType)((0x0105) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetPolyFillMode"]/*' />
    WmfRecordTypeSetPolyFillMode = ((int)(EmfPlusRecordType)((0x0106) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetStretchBltMode"]/*' />
    WmfRecordTypeSetStretchBltMode = ((int)(EmfPlusRecordType)((0x0107) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetTextCharExtra"]/*' />
    WmfRecordTypeSetTextCharExtra = ((int)(EmfPlusRecordType)((0x0108) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetTextColor"]/*' />
    WmfRecordTypeSetTextColor = ((int)(EmfPlusRecordType)((0x0209) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetTextJustification"]/*' />
    WmfRecordTypeSetTextJustification = ((int)(EmfPlusRecordType)((0x020A) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetWindowOrg"]/*' />
    WmfRecordTypeSetWindowOrg = ((int)(EmfPlusRecordType)((0x020B) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetWindowExt"]/*' />
    WmfRecordTypeSetWindowExt = ((int)(EmfPlusRecordType)((0x020C) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetViewportOrg"]/*' />
    WmfRecordTypeSetViewportOrg = ((int)(EmfPlusRecordType)((0x020D) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetViewportExt"]/*' />
    WmfRecordTypeSetViewportExt = ((int)(EmfPlusRecordType)((0x020E) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeOffsetWindowOrg"]/*' />
    WmfRecordTypeOffsetWindowOrg = ((int)(EmfPlusRecordType)((0x020F) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeScaleWindowExt"]/*' />
    WmfRecordTypeScaleWindowExt = ((int)(EmfPlusRecordType)((0x0410) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeOffsetViewportOrg"]/*' />
    WmfRecordTypeOffsetViewportOrg = ((int)(EmfPlusRecordType)((0x0211) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeScaleViewportExt"]/*' />
    WmfRecordTypeScaleViewportExt = ((int)(EmfPlusRecordType)((0x0412) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeLineTo"]/*' />
    WmfRecordTypeLineTo = ((int)(EmfPlusRecordType)((0x0213) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeMoveTo"]/*' />
    WmfRecordTypeMoveTo = ((int)(EmfPlusRecordType)((0x0214) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeExcludeClipRect"]/*' />
    WmfRecordTypeExcludeClipRect = ((int)(EmfPlusRecordType)((0x0415) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeIntersectClipRect"]/*' />
    WmfRecordTypeIntersectClipRect = ((int)(EmfPlusRecordType)((0x0416) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeArc"]/*' />
    WmfRecordTypeArc = ((int)(EmfPlusRecordType)((0x0817) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeEllipse"]/*' />
    WmfRecordTypeEllipse = ((int)(EmfPlusRecordType)((0x0418) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeFloodFill"]/*' />
    WmfRecordTypeFloodFill = ((int)(EmfPlusRecordType)((0x0419) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypePie"]/*' />
    WmfRecordTypePie = ((int)(EmfPlusRecordType)((0x081A) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeRectangle"]/*' />
    WmfRecordTypeRectangle = ((int)(EmfPlusRecordType)((0x041B) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeRoundRect"]/*' />
    WmfRecordTypeRoundRect = ((int)(EmfPlusRecordType)((0x061C) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypePatBlt"]/*' />
    WmfRecordTypePatBlt = ((int)(EmfPlusRecordType)((0x061D) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSaveDC"]/*' />
    WmfRecordTypeSaveDC = ((int)(EmfPlusRecordType)((0x001E) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetPixel"]/*' />
    WmfRecordTypeSetPixel = ((int)(EmfPlusRecordType)((0x041F) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeOffsetClipRgn"]/*' />
    WmfRecordTypeOffsetClipRgn = ((int)(EmfPlusRecordType)((0x0220) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeTextOut"]/*' />
    WmfRecordTypeTextOut = ((int)(EmfPlusRecordType)((0x0521) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeBitBlt"]/*' />
    WmfRecordTypeBitBlt = ((int)(EmfPlusRecordType)((0x0922) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeStretchBlt"]/*' />
    WmfRecordTypeStretchBlt = ((int)(EmfPlusRecordType)((0x0B23) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypePolygon"]/*' />
    WmfRecordTypePolygon = ((int)(EmfPlusRecordType)((0x0324) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypePolyline"]/*' />
    WmfRecordTypePolyline = ((int)(EmfPlusRecordType)((0x0325) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeEscape"]/*' />
    WmfRecordTypeEscape = ((int)(EmfPlusRecordType)((0x0626) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeRestoreDC"]/*' />
    WmfRecordTypeRestoreDC = ((int)(EmfPlusRecordType)((0x0127) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeFillRegion"]/*' />
    WmfRecordTypeFillRegion = ((int)(EmfPlusRecordType)((0x0228) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeFrameRegion"]/*' />
    WmfRecordTypeFrameRegion = ((int)(EmfPlusRecordType)((0x0429) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeInvertRegion"]/*' />
    WmfRecordTypeInvertRegion = ((int)(EmfPlusRecordType)((0x012A) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypePaintRegion"]/*' />
    WmfRecordTypePaintRegion = ((int)(EmfPlusRecordType)((0x012B) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSelectClipRegion"]/*' />
    WmfRecordTypeSelectClipRegion = ((int)(EmfPlusRecordType)((0x012C) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSelectObject"]/*' />
    WmfRecordTypeSelectObject = ((int)(EmfPlusRecordType)((0x012D) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetTextAlign"]/*' />
    WmfRecordTypeSetTextAlign = ((int)(EmfPlusRecordType)((0x012E) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeDrawText"]/*' />
    WmfRecordTypeDrawText = ((int)(EmfPlusRecordType)((0x062F) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeChord"]/*' />
    WmfRecordTypeChord = ((int)(EmfPlusRecordType)((0x0830) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetMapperFlags"]/*' />
    WmfRecordTypeSetMapperFlags = ((int)(EmfPlusRecordType)((0x0231) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeExtTextOut"]/*' />
    WmfRecordTypeExtTextOut = ((int)(EmfPlusRecordType)((0x0a32) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetDIBToDev"]/*' />
    WmfRecordTypeSetDIBToDev = ((int)(EmfPlusRecordType)((0x0d33) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSelectPalette"]/*' />
    WmfRecordTypeSelectPalette = ((int)(EmfPlusRecordType)((0x0234) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeRealizePalette"]/*' />
    WmfRecordTypeRealizePalette = ((int)(EmfPlusRecordType)((0x0035) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeAnimatePalette"]/*' />
    WmfRecordTypeAnimatePalette = ((int)(EmfPlusRecordType)((0x0436) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetPalEntries"]/*' />
    WmfRecordTypeSetPalEntries = ((int)(EmfPlusRecordType)((0x0037) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypePolyPolygon"]/*' />
    WmfRecordTypePolyPolygon = ((int)(EmfPlusRecordType)((0x0538) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeResizePalette"]/*' />
    WmfRecordTypeResizePalette = ((int)(EmfPlusRecordType)((0x0139) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeDIBBitBlt"]/*' />
    WmfRecordTypeDIBBitBlt = ((int)(EmfPlusRecordType)((0x0940) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeDIBStretchBlt"]/*' />
    WmfRecordTypeDIBStretchBlt = ((int)(EmfPlusRecordType)((0x0b41) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeDIBCreatePatternBrush"]/*' />
    WmfRecordTypeDIBCreatePatternBrush = ((int)(EmfPlusRecordType)((0x0142) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeStretchDIB"]/*' />
    WmfRecordTypeStretchDIB = ((int)(EmfPlusRecordType)((0x0f43) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeExtFloodFill"]/*' />
    WmfRecordTypeExtFloodFill = ((int)(EmfPlusRecordType)((0x0548) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeSetLayout"]/*' />
    WmfRecordTypeSetLayout = ((int)(EmfPlusRecordType)((0x0149) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeResetDC"]/*' />
    WmfRecordTypeResetDC = ((int)(EmfPlusRecordType)((0x014C) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeStartDoc"]/*' />
    WmfRecordTypeStartDoc = ((int)(EmfPlusRecordType)((0x014D) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeStartPage"]/*' />
    WmfRecordTypeStartPage = ((int)(EmfPlusRecordType)((0x004F) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeEndPage"]/*' />
    WmfRecordTypeEndPage = ((int)(EmfPlusRecordType)((0x0050) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeAbortDoc"]/*' />
    WmfRecordTypeAbortDoc = ((int)(EmfPlusRecordType)((0x0052) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeEndDoc"]/*' />
    WmfRecordTypeEndDoc = ((int)(EmfPlusRecordType)((0x005E) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeDeleteObject"]/*' />
    WmfRecordTypeDeleteObject = ((int)(EmfPlusRecordType)((0x01f0) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeCreatePalette"]/*' />
    WmfRecordTypeCreatePalette = ((int)(EmfPlusRecordType)((0x00f7) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeCreateBrush"]/*' />
    WmfRecordTypeCreateBrush = ((int)(EmfPlusRecordType)((0x00F8) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeCreatePatternBrush"]/*' />
    WmfRecordTypeCreatePatternBrush = ((int)(EmfPlusRecordType)((0x01F9) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeCreatePenIndirect"]/*' />
    WmfRecordTypeCreatePenIndirect = ((int)(EmfPlusRecordType)((0x02FA) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeCreateFontIndirect"]/*' />
    WmfRecordTypeCreateFontIndirect = ((int)(EmfPlusRecordType)((0x02FB) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeCreateBrushIndirect"]/*' />
    WmfRecordTypeCreateBrushIndirect = ((int)(EmfPlusRecordType)((0x02FC) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeCreateBitmapIndirect"]/*' />
    WmfRecordTypeCreateBitmapIndirect = ((int)(EmfPlusRecordType)((0x02FD) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeCreateBitmap"]/*' />
    WmfRecordTypeCreateBitmap = ((int)(EmfPlusRecordType)((0x06FE) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.WmfRecordTypeCreateRegion"]/*' />
    WmfRecordTypeCreateRegion = ((int)(EmfPlusRecordType)((0x06FF) | 0x00010000)),

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeHeader"]/*' />
    EmfRecordTypeHeader = 1,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyBezier"]/*' />
    EmfRecordTypePolyBezier = 2,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolygon"]/*' />
    EmfRecordTypePolygon = 3,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyline"]/*' />
    EmfRecordTypePolyline = 4,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyBezierTo"]/*' />
    EmfRecordTypePolyBezierTo = 5,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyLineTo"]/*' />
    EmfRecordTypePolyLineTo = 6,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyPolyline"]/*' />
    EmfRecordTypePolyPolyline = 7,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyPolygon"]/*' />
    EmfRecordTypePolyPolygon = 8,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetWindowExtEx"]/*' />
    EmfRecordTypeSetWindowExtEx = 9,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetWindowOrgEx"]/*' />
    EmfRecordTypeSetWindowOrgEx = 10,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetViewportExtEx"]/*' />
    EmfRecordTypeSetViewportExtEx = 11,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetViewportOrgEx"]/*' />
    EmfRecordTypeSetViewportOrgEx = 12,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetBrushOrgEx"]/*' />
    EmfRecordTypeSetBrushOrgEx = 13,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeEOF"]/*' />
    EmfRecordTypeEOF = 14,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetPixelV"]/*' />
    EmfRecordTypeSetPixelV = 15,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetMapperFlags"]/*' />
    EmfRecordTypeSetMapperFlags = 16,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetMapMode"]/*' />
    EmfRecordTypeSetMapMode = 17,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetBkMode"]/*' />
    EmfRecordTypeSetBkMode = 18,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetPolyFillMode"]/*' />
    EmfRecordTypeSetPolyFillMode = 19,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetROP2"]/*' />
    EmfRecordTypeSetROP2 = 20,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetStretchBltMode"]/*' />
    EmfRecordTypeSetStretchBltMode = 21,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetTextAlign"]/*' />
    EmfRecordTypeSetTextAlign = 22,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetColorAdjustment"]/*' />
    EmfRecordTypeSetColorAdjustment = 23,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetTextColor"]/*' />
    EmfRecordTypeSetTextColor = 24,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetBkColor"]/*' />
    EmfRecordTypeSetBkColor = 25,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeOffsetClipRgn"]/*' />
    EmfRecordTypeOffsetClipRgn = 26,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeMoveToEx"]/*' />
    EmfRecordTypeMoveToEx = 27,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetMetaRgn"]/*' />
    EmfRecordTypeSetMetaRgn = 28,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeExcludeClipRect"]/*' />
    EmfRecordTypeExcludeClipRect = 29,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeIntersectClipRect"]/*' />
    EmfRecordTypeIntersectClipRect = 30,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeScaleViewportExtEx"]/*' />
    EmfRecordTypeScaleViewportExtEx = 31,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeScaleWindowExtEx"]/*' />
    EmfRecordTypeScaleWindowExtEx = 32,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSaveDC"]/*' />
    EmfRecordTypeSaveDC = 33,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeRestoreDC"]/*' />
    EmfRecordTypeRestoreDC = 34,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetWorldTransform"]/*' />
    EmfRecordTypeSetWorldTransform = 35,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeModifyWorldTransform"]/*' />
    EmfRecordTypeModifyWorldTransform = 36,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSelectObject"]/*' />
    EmfRecordTypeSelectObject = 37,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeCreatePen"]/*' />
    EmfRecordTypeCreatePen = 38,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeCreateBrushIndirect"]/*' />
    EmfRecordTypeCreateBrushIndirect = 39,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeDeleteObject"]/*' />
    EmfRecordTypeDeleteObject = 40,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeAngleArc"]/*' />
    EmfRecordTypeAngleArc = 41,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeEllipse"]/*' />
    EmfRecordTypeEllipse = 42,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeRectangle"]/*' />
    EmfRecordTypeRectangle = 43,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeRoundRect"]/*' />
    EmfRecordTypeRoundRect = 44,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeArc"]/*' />
    EmfRecordTypeArc = 45,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeChord"]/*' />
    EmfRecordTypeChord = 46,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePie"]/*' />
    EmfRecordTypePie = 47,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSelectPalette"]/*' />
    EmfRecordTypeSelectPalette = 48,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeCreatePalette"]/*' />
    EmfRecordTypeCreatePalette = 49,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetPaletteEntries"]/*' />
    EmfRecordTypeSetPaletteEntries = 50,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeResizePalette"]/*' />
    EmfRecordTypeResizePalette = 51,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeRealizePalette"]/*' />
    EmfRecordTypeRealizePalette = 52,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeExtFloodFill"]/*' />
    EmfRecordTypeExtFloodFill = 53,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeLineTo"]/*' />
    EmfRecordTypeLineTo = 54,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeArcTo"]/*' />
    EmfRecordTypeArcTo = 55,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyDraw"]/*' />
    EmfRecordTypePolyDraw = 56,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetArcDirection"]/*' />
    EmfRecordTypeSetArcDirection = 57,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetMiterLimit"]/*' />
    EmfRecordTypeSetMiterLimit = 58,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeBeginPath"]/*' />
    EmfRecordTypeBeginPath = 59,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeEndPath"]/*' />
    EmfRecordTypeEndPath = 60,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeCloseFigure"]/*' />
    EmfRecordTypeCloseFigure = 61,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeFillPath"]/*' />
    EmfRecordTypeFillPath = 62,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeStrokeAndFillPath"]/*' />
    EmfRecordTypeStrokeAndFillPath = 63,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeStrokePath"]/*' />
    EmfRecordTypeStrokePath = 64,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeFlattenPath"]/*' />
    EmfRecordTypeFlattenPath = 65,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeWidenPath"]/*' />
    EmfRecordTypeWidenPath = 66,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSelectClipPath"]/*' />
    EmfRecordTypeSelectClipPath = 67,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeAbortPath"]/*' />
    EmfRecordTypeAbortPath = 68,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeReserved_069"]/*' />
    EmfRecordTypeReserved_069 = 69,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeGdiComment"]/*' />
    EmfRecordTypeGdiComment = 70,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeFillRgn"]/*' />
    EmfRecordTypeFillRgn = 71,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeFrameRgn"]/*' />
    EmfRecordTypeFrameRgn = 72,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeInvertRgn"]/*' />
    EmfRecordTypeInvertRgn = 73,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePaintRgn"]/*' />
    EmfRecordTypePaintRgn = 74,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeExtSelectClipRgn"]/*' />
    EmfRecordTypeExtSelectClipRgn = 75,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeBitBlt"]/*' />
    EmfRecordTypeBitBlt = 76,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeStretchBlt"]/*' />
    EmfRecordTypeStretchBlt = 77,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeMaskBlt"]/*' />
    EmfRecordTypeMaskBlt = 78,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePlgBlt"]/*' />
    EmfRecordTypePlgBlt = 79,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetDIBitsToDevice"]/*' />
    EmfRecordTypeSetDIBitsToDevice = 80,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeStretchDIBits"]/*' />
    EmfRecordTypeStretchDIBits = 81,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeExtCreateFontIndirect"]/*' />
    EmfRecordTypeExtCreateFontIndirect = 82,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeExtTextOutA"]/*' />
    EmfRecordTypeExtTextOutA = 83,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeExtTextOutW"]/*' />
    EmfRecordTypeExtTextOutW = 84,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyBezier16"]/*' />
    EmfRecordTypePolyBezier16 = 85,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolygon16"]/*' />
    EmfRecordTypePolygon16 = 86,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyline16"]/*' />
    EmfRecordTypePolyline16 = 87,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyBezierTo16"]/*' />
    EmfRecordTypePolyBezierTo16 = 88,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolylineTo16"]/*' />
    EmfRecordTypePolylineTo16 = 89,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyPolyline16"]/*' />
    EmfRecordTypePolyPolyline16 = 90,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyPolygon16"]/*' />
    EmfRecordTypePolyPolygon16 = 91,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyDraw16"]/*' />
    EmfRecordTypePolyDraw16 = 92,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeCreateMonoBrush"]/*' />
    EmfRecordTypeCreateMonoBrush = 93,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeCreateDIBPatternBrushPt"]/*' />
    EmfRecordTypeCreateDIBPatternBrushPt = 94,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeExtCreatePen"]/*' />
    EmfRecordTypeExtCreatePen = 95,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyTextOutA"]/*' />
    EmfRecordTypePolyTextOutA = 96,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePolyTextOutW"]/*' />
    EmfRecordTypePolyTextOutW = 97,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetICMMode"]/*' />
    EmfRecordTypeSetICMMode = 98,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeCreateColorSpace"]/*' />
    EmfRecordTypeCreateColorSpace = 99,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetColorSpace"]/*' />
    EmfRecordTypeSetColorSpace = 100,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeDeleteColorSpace"]/*' />
    EmfRecordTypeDeleteColorSpace = 101,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeGLSRecord"]/*' />
    EmfRecordTypeGLSRecord = 102,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeGLSBoundedRecord"]/*' />
    EmfRecordTypeGLSBoundedRecord = 103,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypePixelFormat"]/*' />
    EmfRecordTypePixelFormat = 104,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeDrawEscape"]/*' />
    EmfRecordTypeDrawEscape = 105,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeExtEscape"]/*' />
    EmfRecordTypeExtEscape = 106,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeStartDoc"]/*' />
    EmfRecordTypeStartDoc = 107,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSmallTextOut"]/*' />
    EmfRecordTypeSmallTextOut = 108,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeForceUFIMapping"]/*' />
    EmfRecordTypeForceUFIMapping = 109,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeNamedEscape"]/*' />
    EmfRecordTypeNamedEscape = 110,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeColorCorrectPalette"]/*' />
    EmfRecordTypeColorCorrectPalette = 111,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetICMProfileA"]/*' />
    EmfRecordTypeSetICMProfileA = 112,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetICMProfileW"]/*' />
    EmfRecordTypeSetICMProfileW = 113,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeAlphaBlend"]/*' />
    EmfRecordTypeAlphaBlend = 114,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetLayout"]/*' />
    EmfRecordTypeSetLayout = 115,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeTransparentBlt"]/*' />
    EmfRecordTypeTransparentBlt = 116,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeReserved_117"]/*' />
    EmfRecordTypeReserved_117 = 117,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeGradientFill"]/*' />
    EmfRecordTypeGradientFill = 118,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetLinkedUFIs"]/*' />
    EmfRecordTypeSetLinkedUFIs = 119,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeSetTextJustification"]/*' />
    EmfRecordTypeSetTextJustification = 120,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeColorMatchToTargetW"]/*' />
    EmfRecordTypeColorMatchToTargetW = 121,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeCreateColorSpaceW"]/*' />
    EmfRecordTypeCreateColorSpaceW = 122,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeMax"]/*' />
    EmfRecordTypeMax = 122,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfRecordTypeMin"]/*' />
    EmfRecordTypeMin = 1,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeInvalid"]/*' />
    EmfPlusRecordTypeInvalid = 0x00004000,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeHeader"]/*' />
    EmfPlusRecordTypeHeader,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeEndOfFile"]/*' />
    EmfPlusRecordTypeEndOfFile,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeComment"]/*' />
    EmfPlusRecordTypeComment,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeGetDC"]/*' />
    EmfPlusRecordTypeGetDC,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeMultiFormatStart"]/*' />
    EmfPlusRecordTypeMultiFormatStart,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeMultiFormatSection"]/*' />
    EmfPlusRecordTypeMultiFormatSection,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeMultiFormatEnd"]/*' />
    EmfPlusRecordTypeMultiFormatEnd,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeObject"]/*' />
    EmfPlusRecordTypeObject,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeClear"]/*' />
    EmfPlusRecordTypeClear,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeFillRects"]/*' />
    EmfPlusRecordTypeFillRects,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawRects"]/*' />
    EmfPlusRecordTypeDrawRects,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeFillPolygon"]/*' />
    EmfPlusRecordTypeFillPolygon,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawLines"]/*' />
    EmfPlusRecordTypeDrawLines,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeFillEllipse"]/*' />
    EmfPlusRecordTypeFillEllipse,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawEllipse"]/*' />
    EmfPlusRecordTypeDrawEllipse,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeFillPie"]/*' />
    EmfPlusRecordTypeFillPie,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawPie"]/*' />
    EmfPlusRecordTypeDrawPie,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawArc"]/*' />
    EmfPlusRecordTypeDrawArc,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeFillRegion"]/*' />
    EmfPlusRecordTypeFillRegion,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeFillPath"]/*' />
    EmfPlusRecordTypeFillPath,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawPath"]/*' />
    EmfPlusRecordTypeDrawPath,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeFillClosedCurve"]/*' />
    EmfPlusRecordTypeFillClosedCurve,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawClosedCurve"]/*' />
    EmfPlusRecordTypeDrawClosedCurve,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawCurve"]/*' />
    EmfPlusRecordTypeDrawCurve,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawBeziers"]/*' />
    EmfPlusRecordTypeDrawBeziers,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawImage"]/*' />
    EmfPlusRecordTypeDrawImage,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawImagePoints"]/*' />
    EmfPlusRecordTypeDrawImagePoints,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawString"]/*' />
    EmfPlusRecordTypeDrawString,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetRenderingOrigin"]/*' />
    EmfPlusRecordTypeSetRenderingOrigin,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetAntiAliasMode"]/*' />
    EmfPlusRecordTypeSetAntiAliasMode,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetTextRenderingHint"]/*' />
    EmfPlusRecordTypeSetTextRenderingHint,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetTextContrast"]/*' />
    EmfPlusRecordTypeSetTextContrast,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetInterpolationMode"]/*' />
    EmfPlusRecordTypeSetInterpolationMode,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetPixelOffsetMode"]/*' />
    EmfPlusRecordTypeSetPixelOffsetMode,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetCompositingMode"]/*' />
    EmfPlusRecordTypeSetCompositingMode,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetCompositingQuality"]/*' />
    EmfPlusRecordTypeSetCompositingQuality,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSave"]/*' />
    EmfPlusRecordTypeSave,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeRestore"]/*' />
    EmfPlusRecordTypeRestore,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeBeginContainer"]/*' />
    EmfPlusRecordTypeBeginContainer,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeBeginContainerNoParams"]/*' />
    EmfPlusRecordTypeBeginContainerNoParams,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeEndContainer"]/*' />
    EmfPlusRecordTypeEndContainer,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetWorldTransform"]/*' />
    EmfPlusRecordTypeSetWorldTransform,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeResetWorldTransform"]/*' />
    EmfPlusRecordTypeResetWorldTransform,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeMultiplyWorldTransform"]/*' />
    EmfPlusRecordTypeMultiplyWorldTransform,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeTranslateWorldTransform"]/*' />
    EmfPlusRecordTypeTranslateWorldTransform,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeScaleWorldTransform"]/*' />
    EmfPlusRecordTypeScaleWorldTransform,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeRotateWorldTransform"]/*' />
    EmfPlusRecordTypeRotateWorldTransform,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetPageTransform"]/*' />
    EmfPlusRecordTypeSetPageTransform,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeResetClip"]/*' />
    EmfPlusRecordTypeResetClip,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetClipRect"]/*' />
    EmfPlusRecordTypeSetClipRect,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetClipPath"]/*' />
    EmfPlusRecordTypeSetClipPath,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetClipRegion"]/*' />
    EmfPlusRecordTypeSetClipRegion,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeOffsetClip"]/*' />
    EmfPlusRecordTypeOffsetClip,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeDrawDriverString"]/*' />
    EmfPlusRecordTypeDrawDriverString,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeStrokeFillPath"]/*' />
    EmfPlusRecordTypeStrokeFillPath,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSerializableObject"]/*' />
    EmfPlusRecordTypeSerializableObject,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetTSGraphics"]/*' />
    EmfPlusRecordTypeSetTSGraphics,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeSetTSClip"]/*' />
    EmfPlusRecordTypeSetTSClip,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTotal"]/*' />
    EmfPlusRecordTotal,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeMax"]/*' />
    EmfPlusRecordTypeMax = EmfPlusRecordTotal - 1,

    /// <include file='EmfPlusRecordType.xml' path='doc/member[@name="EmfPlusRecordType.EmfPlusRecordTypeMin"]/*' />
    EmfPlusRecordTypeMin = EmfPlusRecordTypeHeader,
}
