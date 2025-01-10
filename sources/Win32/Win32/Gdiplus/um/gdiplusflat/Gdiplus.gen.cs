// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusflat.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public static unsafe partial class Gdiplus
{
    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreatePath(
        [NativeTypeName("Gdiplus::GpFillMode")] GpFillMode brushMode,
        GpPath** path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreatePath2(
        [NativeTypeName("const GpPointF *")] GpPointF* param0,
        [NativeTypeName("const BYTE *")] byte* param1,
        int param2,
        [NativeTypeName("Gdiplus::GpFillMode")] GpFillMode param3,
        GpPath** path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreatePath2I(
        [NativeTypeName("const GpPoint *")] GpPoint* param0,
        [NativeTypeName("const BYTE *")] byte* param1,
        int param2,
        [NativeTypeName("Gdiplus::GpFillMode")] GpFillMode param3,
        GpPath** path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipClonePath(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        GpPath** clonePath
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeletePath(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipResetPath([NativeTypeName("Gdiplus::GpPath *")] GpPath* path);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPointCount(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathTypes(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        byte* types,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathPoints(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* param0,
        [NativeTypeName("Gdiplus::GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathPointsI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* param0,
        [NativeTypeName("Gdiplus::GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathFillMode(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpFillMode *")] GpFillMode* fillmode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathFillMode(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpFillMode")] GpFillMode fillmode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathData(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpPathData *")] GpPathData* pathData
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipStartPathFigure(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipClosePathFigure(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipClosePathFigures(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathMarker(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipClearPathMarkers(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipReversePath(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathLastPoint(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpPointF *")] GpPointF* lastPoint
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathLine(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::REAL")] float x1,
        [NativeTypeName("Gdiplus::REAL")] float y1,
        [NativeTypeName("Gdiplus::REAL")] float x2,
        [NativeTypeName("Gdiplus::REAL")] float y2
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathLine2(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathArc(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathBezier(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::REAL")] float x1,
        [NativeTypeName("Gdiplus::REAL")] float y1,
        [NativeTypeName("Gdiplus::REAL")] float x2,
        [NativeTypeName("Gdiplus::REAL")] float y2,
        [NativeTypeName("Gdiplus::REAL")] float x3,
        [NativeTypeName("Gdiplus::REAL")] float y3,
        [NativeTypeName("Gdiplus::REAL")] float x4,
        [NativeTypeName("Gdiplus::REAL")] float y4
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathBeziers(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathCurve(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathCurve2(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathCurve3(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        int offset,
        int numberOfSegments,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathClosedCurve(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathClosedCurve2(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathRectangle(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathRectangles(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpRectF *")] GpRectF* rects,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathEllipse(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathPie(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathPolygon(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathPath(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPath *")] GpPath* addingPath,
        BOOL connect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathString(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const WCHAR *")] ushort* @string,
        int length,
        [NativeTypeName("const GpFontFamily *")] GpFontFamily* family,
        int style,
        [NativeTypeName("Gdiplus::REAL")] float emSize,
        [NativeTypeName("const RectF *")] GpRectF* layoutRect,
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathStringI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const WCHAR *")] ushort* @string,
        int length,
        [NativeTypeName("const GpFontFamily *")] GpFontFamily* family,
        int style,
        [NativeTypeName("Gdiplus::REAL")] float emSize,
        [NativeTypeName("const Rect *")] GpRect* layoutRect,
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathLineI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        int x1,
        int y1,
        int x2,
        int y2
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathLine2I(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathArcI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        int x,
        int y,
        int width,
        int height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathBezierI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        int x1,
        int y1,
        int x2,
        int y2,
        int x3,
        int y3,
        int x4,
        int y4
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathBeziersI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathCurveI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathCurve2I(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathCurve3I(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        int offset,
        int numberOfSegments,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathClosedCurveI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathClosedCurve2I(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathRectangleI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        int x,
        int y,
        int width,
        int height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathRectanglesI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpRect *")] GpRect* rects,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathEllipseI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        int x,
        int y,
        int width,
        int height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathPieI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        int x,
        int y,
        int width,
        int height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipAddPathPolygonI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFlattenPath(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::REAL")] float flatness
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipWindingModeOutline(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::REAL")] float flatness
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipWidenPath(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* nativePath,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::REAL")] float flatness
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipWarpPath(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float srcx,
        [NativeTypeName("Gdiplus::REAL")] float srcy,
        [NativeTypeName("Gdiplus::REAL")] float srcwidth,
        [NativeTypeName("Gdiplus::REAL")] float srcheight,
        [NativeTypeName("Gdiplus::WarpMode")] WarpMode warpMode,
        [NativeTypeName("Gdiplus::REAL")] float flatness
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTransformPath(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathWorldBounds(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpRectF *")] GpRectF* bounds,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("const GpPen *")] GpPen* pen
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathWorldBoundsI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::GpRect *")] GpRect* bounds,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("const GpPen *")] GpPen* pen
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisiblePathPoint(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisiblePathPointI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        int x,
        int y,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsOutlineVisiblePathPoint(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsOutlineVisiblePathPointI(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        int x,
        int y,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreatePathIter(
        GpPathIterator** iterator,
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeletePathIter(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterNextSubpath(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        int* resultCount,
        int* startIndex,
        int* endIndex,
        BOOL* isClosed
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterNextSubpathPath(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        int* resultCount,
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        BOOL* isClosed
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterNextPathType(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        int* resultCount,
        byte* pathType,
        int* startIndex,
        int* endIndex
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterNextMarker(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        int* resultCount,
        int* startIndex,
        int* endIndex
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterNextMarkerPath(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        int* resultCount,
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterGetCount(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterGetSubpathCount(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterIsValid(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        BOOL* valid
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterHasCurve(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        BOOL* hasCurve
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterRewind(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterEnumerate(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        int* resultCount,
        [NativeTypeName("Gdiplus::GpPointF *")] GpPointF* points,
        byte* types,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPathIterCopyData(
        [NativeTypeName("Gdiplus::GpPathIterator *")] GpPathIterator* iterator,
        int* resultCount,
        [NativeTypeName("Gdiplus::GpPointF *")] GpPointF* points,
        byte* types,
        int startIndex,
        int endIndex
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateMatrix(GpMatrix** matrix);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateMatrix2(
        [NativeTypeName("Gdiplus::REAL")] float m11,
        [NativeTypeName("Gdiplus::REAL")] float m12,
        [NativeTypeName("Gdiplus::REAL")] float m21,
        [NativeTypeName("Gdiplus::REAL")] float m22,
        [NativeTypeName("Gdiplus::REAL")] float dx,
        [NativeTypeName("Gdiplus::REAL")] float dy,
        GpMatrix** matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateMatrix3(
        [NativeTypeName("const GpRectF *")] GpRectF* rect,
        [NativeTypeName("const GpPointF *")] GpPointF* dstplg,
        GpMatrix** matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateMatrix3I(
        [NativeTypeName("const GpRect *")] GpRect* rect,
        [NativeTypeName("const GpPoint *")] GpPoint* dstplg,
        GpMatrix** matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneMatrix(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        GpMatrix** cloneMatrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeleteMatrix(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetMatrixElements(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::REAL")] float m11,
        [NativeTypeName("Gdiplus::REAL")] float m12,
        [NativeTypeName("Gdiplus::REAL")] float m21,
        [NativeTypeName("Gdiplus::REAL")] float m22,
        [NativeTypeName("Gdiplus::REAL")] float dx,
        [NativeTypeName("Gdiplus::REAL")] float dy
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipMultiplyMatrix(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix2,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslateMatrix(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::REAL")] float offsetX,
        [NativeTypeName("Gdiplus::REAL")] float offsetY,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipScaleMatrix(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::REAL")] float scaleX,
        [NativeTypeName("Gdiplus::REAL")] float scaleY,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRotateMatrix(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::REAL")] float angle,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipShearMatrix(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::REAL")] float shearX,
        [NativeTypeName("Gdiplus::REAL")] float shearY,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipInvertMatrix(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTransformMatrixPoints(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpPointF *")] GpPointF* pts,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTransformMatrixPointsI(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpPoint *")] GpPoint* pts,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipVectorTransformMatrixPoints(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpPointF *")] GpPointF* pts,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipVectorTransformMatrixPointsI(
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpPoint *")] GpPoint* pts,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetMatrixElements(
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::REAL *")] float* matrixOut
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsMatrixInvertible(
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsMatrixIdentity(
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsMatrixEqual(
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix2,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateRegion(GpRegion** region);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateRegionRect(
        [NativeTypeName("const GpRectF *")] GpRectF* rect,
        GpRegion** region
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateRegionRectI(
        [NativeTypeName("const GpRect *")] GpRect* rect,
        GpRegion** region
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateRegionPath(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        GpRegion** region
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateRegionRgnData(
        [NativeTypeName("const BYTE *")] byte* regionData,
        int size,
        GpRegion** region
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateRegionHrgn(HRGN hRgn, GpRegion** region);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneRegion(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        GpRegion** cloneRegion
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeleteRegion(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetInfinite(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetEmpty(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCombineRegionRect(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("const GpRectF *")] GpRectF* rect,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCombineRegionRectI(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("const GpRect *")] GpRect* rect,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCombineRegionPath(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCombineRegionRegion(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region2,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslateRegion(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::REAL")] float dx,
        [NativeTypeName("Gdiplus::REAL")] float dy
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslateRegionI(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        int dx,
        int dy
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTransformRegion(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetRegionBounds(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpRectF *")] GpRectF* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetRegionBoundsI(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpRect *")] GpRect* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetRegionHRgn(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        HRGN* hRgn
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsEmptyRegion(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsInfiniteRegion(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsEqualRegion(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region2,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetRegionDataSize(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        uint* bufferSize
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetRegionData(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        byte* buffer,
        uint bufferSize,
        uint* sizeFilled
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisibleRegionPoint(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisibleRegionPointI(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        int x,
        int y,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisibleRegionRect(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisibleRegionRectI(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        int x,
        int y,
        int width,
        int height,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetRegionScansCount(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        uint* count,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetRegionScans(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpRectF *")] GpRectF* rects,
        int* count,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetRegionScansI(
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::GpRect *")] GpRect* rects,
        int* count,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneBrush(
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        GpBrush** cloneBrush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeleteBrush(
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetBrushType(
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("Gdiplus::GpBrushType *")] GpBrushType* type
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateHatchBrush(
        [NativeTypeName("Gdiplus::GpHatchStyle")] GpHatchStyle hatchstyle,
        [NativeTypeName("Gdiplus::ARGB")] uint forecol,
        [NativeTypeName("Gdiplus::ARGB")] uint backcol,
        GpHatch** brush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetHatchStyle(
        [NativeTypeName("Gdiplus::GpHatch *")] GpHatch* brush,
        [NativeTypeName("Gdiplus::GpHatchStyle *")] GpHatchStyle* hatchstyle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetHatchForegroundColor(
        [NativeTypeName("Gdiplus::GpHatch *")] GpHatch* brush,
        [NativeTypeName("Gdiplus::ARGB *")] uint* forecol
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetHatchBackgroundColor(
        [NativeTypeName("Gdiplus::GpHatch *")] GpHatch* brush,
        [NativeTypeName("Gdiplus::ARGB *")] uint* backcol
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateTexture(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapmode,
        GpTexture** texture
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateTexture2(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapmode,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        GpTexture** texture
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateTextureIA(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        GpTexture** texture
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateTexture2I(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapmode,
        int x,
        int y,
        int width,
        int height,
        GpTexture** texture
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateTextureIAI(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes,
        int x,
        int y,
        int width,
        int height,
        GpTexture** texture
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetTextureTransform(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetTextureTransform(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipResetTextureTransform(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipMultiplyTextureTransform(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslateTextureTransform(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush,
        [NativeTypeName("Gdiplus::REAL")] float dx,
        [NativeTypeName("Gdiplus::REAL")] float dy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipScaleTextureTransform(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush,
        [NativeTypeName("Gdiplus::REAL")] float sx,
        [NativeTypeName("Gdiplus::REAL")] float sy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRotateTextureTransform(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush,
        [NativeTypeName("Gdiplus::REAL")] float angle,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetTextureWrapMode(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapmode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetTextureWrapMode(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush,
        [NativeTypeName("Gdiplus::GpWrapMode *")] GpWrapMode* wrapmode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetTextureImage(
        [NativeTypeName("Gdiplus::GpTexture *")] GpTexture* brush,
        GpImage** image
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateSolidFill(
        [NativeTypeName("Gdiplus::ARGB")] uint color,
        GpSolidFill** brush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetSolidFillColor(
        [NativeTypeName("Gdiplus::GpSolidFill *")] GpSolidFill* brush,
        [NativeTypeName("Gdiplus::ARGB")] uint color
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetSolidFillColor(
        [NativeTypeName("Gdiplus::GpSolidFill *")] GpSolidFill* brush,
        [NativeTypeName("Gdiplus::ARGB *")] uint* color
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateLineBrush(
        [NativeTypeName("const GpPointF *")] GpPointF* point1,
        [NativeTypeName("const GpPointF *")] GpPointF* point2,
        [NativeTypeName("Gdiplus::ARGB")] uint color1,
        [NativeTypeName("Gdiplus::ARGB")] uint color2,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapMode,
        GpLineGradient** lineGradient
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateLineBrushI(
        [NativeTypeName("const GpPoint *")] GpPoint* point1,
        [NativeTypeName("const GpPoint *")] GpPoint* point2,
        [NativeTypeName("Gdiplus::ARGB")] uint color1,
        [NativeTypeName("Gdiplus::ARGB")] uint color2,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapMode,
        GpLineGradient** lineGradient
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateLineBrushFromRect(
        [NativeTypeName("const GpRectF *")] GpRectF* rect,
        [NativeTypeName("Gdiplus::ARGB")] uint color1,
        [NativeTypeName("Gdiplus::ARGB")] uint color2,
        [NativeTypeName("Gdiplus::LinearGradientMode")] LinearGradientMode mode,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapMode,
        GpLineGradient** lineGradient
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateLineBrushFromRectI(
        [NativeTypeName("const GpRect *")] GpRect* rect,
        [NativeTypeName("Gdiplus::ARGB")] uint color1,
        [NativeTypeName("Gdiplus::ARGB")] uint color2,
        [NativeTypeName("Gdiplus::LinearGradientMode")] LinearGradientMode mode,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapMode,
        GpLineGradient** lineGradient
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateLineBrushFromRectWithAngle(
        [NativeTypeName("const GpRectF *")] GpRectF* rect,
        [NativeTypeName("Gdiplus::ARGB")] uint color1,
        [NativeTypeName("Gdiplus::ARGB")] uint color2,
        [NativeTypeName("Gdiplus::REAL")] float angle,
        BOOL isAngleScalable,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapMode,
        GpLineGradient** lineGradient
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateLineBrushFromRectWithAngleI(
        [NativeTypeName("const GpRect *")] GpRect* rect,
        [NativeTypeName("Gdiplus::ARGB")] uint color1,
        [NativeTypeName("Gdiplus::ARGB")] uint color2,
        [NativeTypeName("Gdiplus::REAL")] float angle,
        BOOL isAngleScalable,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapMode,
        GpLineGradient** lineGradient
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetLineColors(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::ARGB")] uint color1,
        [NativeTypeName("Gdiplus::ARGB")] uint color2
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLineColors(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::ARGB *")] uint* colors
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLineRect(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::GpRectF *")] GpRectF* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLineRectI(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::GpRect *")] GpRect* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetLineGammaCorrection(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        BOOL useGammaCorrection
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLineGammaCorrection(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        BOOL* useGammaCorrection
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLineBlendCount(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLineBlend(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::REAL *")] float* blend,
        [NativeTypeName("Gdiplus::REAL *")] float* positions,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetLineBlend(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("const REAL *")] float* blend,
        [NativeTypeName("const REAL *")] float* positions,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLinePresetBlendCount(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLinePresetBlend(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::ARGB *")] uint* blend,
        [NativeTypeName("Gdiplus::REAL *")] float* positions,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetLinePresetBlend(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("const ARGB *")] uint* blend,
        [NativeTypeName("const REAL *")] float* positions,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetLineSigmaBlend(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float focus,
        [NativeTypeName("Gdiplus::REAL")] float scale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetLineLinearBlend(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float focus,
        [NativeTypeName("Gdiplus::REAL")] float scale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetLineWrapMode(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapmode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLineWrapMode(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::GpWrapMode *")] GpWrapMode* wrapmode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLineTransform(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetLineTransform(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipResetLineTransform(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipMultiplyLineTransform(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslateLineTransform(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float dx,
        [NativeTypeName("Gdiplus::REAL")] float dy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipScaleLineTransform(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float sx,
        [NativeTypeName("Gdiplus::REAL")] float sy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRotateLineTransform(
        [NativeTypeName("Gdiplus::GpLineGradient *")] GpLineGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float angle,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreatePathGradient(
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapMode,
        GpPathGradient** polyGradient
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreatePathGradientI(
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapMode,
        GpPathGradient** polyGradient
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreatePathGradientFromPath(
        [NativeTypeName("const GpPath *")] GpPath* path,
        GpPathGradient** polyGradient
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientCenterColor(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::ARGB *")] uint* colors
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientCenterColor(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::ARGB")] uint colors
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientSurroundColorsWithCount(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::ARGB *")] uint* color,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientSurroundColorsWithCount(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("const ARGB *")] uint* color,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientPath(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientPath(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("const GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientCenterPoint(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::GpPointF *")] GpPointF* points
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientCenterPointI(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::GpPoint *")] GpPoint* points
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientCenterPoint(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("const GpPointF *")] GpPointF* points
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientCenterPointI(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("const GpPoint *")] GpPoint* points
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientRect(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::GpRectF *")] GpRectF* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientRectI(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::GpRect *")] GpRect* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientPointCount(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientSurroundColorCount(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientGammaCorrection(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        BOOL useGammaCorrection
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientGammaCorrection(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        BOOL* useGammaCorrection
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientBlendCount(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientBlend(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::REAL *")] float* blend,
        [NativeTypeName("Gdiplus::REAL *")] float* positions,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientBlend(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("const REAL *")] float* blend,
        [NativeTypeName("const REAL *")] float* positions,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientPresetBlendCount(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientPresetBlend(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::ARGB *")] uint* blend,
        [NativeTypeName("Gdiplus::REAL *")] float* positions,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientPresetBlend(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("const ARGB *")] uint* blend,
        [NativeTypeName("const REAL *")] float* positions,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientSigmaBlend(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float focus,
        [NativeTypeName("Gdiplus::REAL")] float scale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientLinearBlend(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float focus,
        [NativeTypeName("Gdiplus::REAL")] float scale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientWrapMode(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::GpWrapMode *")] GpWrapMode* wrapmode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientWrapMode(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::GpWrapMode")] GpWrapMode wrapmode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientTransform(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientTransform(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipResetPathGradientTransform(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipMultiplyPathGradientTransform(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslatePathGradientTransform(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float dx,
        [NativeTypeName("Gdiplus::REAL")] float dy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipScalePathGradientTransform(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float sx,
        [NativeTypeName("Gdiplus::REAL")] float sy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRotatePathGradientTransform(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float angle,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPathGradientFocusScales(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::REAL *")] float* xScale,
        [NativeTypeName("Gdiplus::REAL *")] float* yScale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPathGradientFocusScales(
        [NativeTypeName("Gdiplus::GpPathGradient *")] GpPathGradient* brush,
        [NativeTypeName("Gdiplus::REAL")] float xScale,
        [NativeTypeName("Gdiplus::REAL")] float yScale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreatePen1(
        [NativeTypeName("Gdiplus::ARGB")] uint color,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit unit,
        GpPen** pen
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreatePen2(
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit unit,
        GpPen** pen
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipClonePen(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        GpPen** clonepen
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeletePen([NativeTypeName("Gdiplus::GpPen *")] GpPen* pen);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenWidth(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float width
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenWidth(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL *")] float* width
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenUnit(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit unit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenUnit(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpUnit *")] GpUnit* unit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenLineCap197819(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpLineCap")] GpLineCap startCap,
        [NativeTypeName("Gdiplus::GpLineCap")] GpLineCap endCap,
        [NativeTypeName("Gdiplus::GpDashCap")] GpDashCap dashCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenStartCap(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpLineCap")] GpLineCap startCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenEndCap(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpLineCap")] GpLineCap endCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenDashCap197819(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpDashCap")] GpDashCap dashCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenStartCap(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpLineCap *")] GpLineCap* startCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenEndCap(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpLineCap *")] GpLineCap* endCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenDashCap197819(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpDashCap *")] GpDashCap* dashCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenLineJoin(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpLineJoin")] GpLineJoin lineJoin
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenLineJoin(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpLineJoin *")] GpLineJoin* lineJoin
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenCustomStartCap(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenCustomStartCap(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        GpCustomLineCap** customCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenCustomEndCap(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenCustomEndCap(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        GpCustomLineCap** customCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenMiterLimit(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float miterLimit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenMiterLimit(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL *")] float* miterLimit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenMode(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpPenAlignment")] GpPenAlignment penMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenMode(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpPenAlignment *")] GpPenAlignment* penMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenTransform(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenTransform(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipResetPenTransform(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipMultiplyPenTransform(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslatePenTransform(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float dx,
        [NativeTypeName("Gdiplus::REAL")] float dy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipScalePenTransform(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float sx,
        [NativeTypeName("Gdiplus::REAL")] float sy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRotatePenTransform(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float angle,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenColor(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::ARGB")] uint argb
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenColor(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::ARGB *")] uint* argb
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenBrushFill(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenBrushFill(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        GpBrush** brush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenFillType(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpPenType *")] GpPenType* type
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenDashStyle(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpDashStyle *")] GpDashStyle* dashstyle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenDashStyle(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpDashStyle")] GpDashStyle dashstyle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenDashOffset(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL *")] float* offset
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenDashOffset(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float offset
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenDashCount(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenDashArray(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const REAL *")] float* dash,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenDashArray(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL *")] float* dash,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenCompoundCount(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPenCompoundArray(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const REAL *")] float* dash,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPenCompoundArray(
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL *")] float* dash,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateCustomLineCap(
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* fillPath,
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* strokePath,
        [NativeTypeName("Gdiplus::GpLineCap")] GpLineCap baseCap,
        [NativeTypeName("Gdiplus::REAL")] float baseInset,
        GpCustomLineCap** customCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeleteCustomLineCap(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneCustomLineCap(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        GpCustomLineCap** clonedCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCustomLineCapType(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::CustomLineCapType *")] CustomLineCapType* capType
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetCustomLineCapStrokeCaps(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::GpLineCap")] GpLineCap startCap,
        [NativeTypeName("Gdiplus::GpLineCap")] GpLineCap endCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCustomLineCapStrokeCaps(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::GpLineCap *")] GpLineCap* startCap,
        [NativeTypeName("Gdiplus::GpLineCap *")] GpLineCap* endCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetCustomLineCapStrokeJoin(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::GpLineJoin")] GpLineJoin lineJoin
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCustomLineCapStrokeJoin(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::GpLineJoin *")] GpLineJoin* lineJoin
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetCustomLineCapBaseCap(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::GpLineCap")] GpLineCap baseCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCustomLineCapBaseCap(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::GpLineCap *")] GpLineCap* baseCap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetCustomLineCapBaseInset(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::REAL")] float inset
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCustomLineCapBaseInset(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::REAL *")] float* inset
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetCustomLineCapWidthScale(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::REAL")] float widthScale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCustomLineCapWidthScale(
        [NativeTypeName("Gdiplus::GpCustomLineCap *")] GpCustomLineCap* customCap,
        [NativeTypeName("Gdiplus::REAL *")] float* widthScale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateAdjustableArrowCap(
        [NativeTypeName("Gdiplus::REAL")] float height,
        [NativeTypeName("Gdiplus::REAL")] float width,
        BOOL isFilled,
        GpAdjustableArrowCap** cap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetAdjustableArrowCapHeight(
        [NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] GpAdjustableArrowCap* cap,
        [NativeTypeName("Gdiplus::REAL")] float height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetAdjustableArrowCapHeight(
        [NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] GpAdjustableArrowCap* cap,
        [NativeTypeName("Gdiplus::REAL *")] float* height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetAdjustableArrowCapWidth(
        [NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] GpAdjustableArrowCap* cap,
        [NativeTypeName("Gdiplus::REAL")] float width
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetAdjustableArrowCapWidth(
        [NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] GpAdjustableArrowCap* cap,
        [NativeTypeName("Gdiplus::REAL *")] float* width
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetAdjustableArrowCapMiddleInset(
        [NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] GpAdjustableArrowCap* cap,
        [NativeTypeName("Gdiplus::REAL")] float middleInset
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetAdjustableArrowCapMiddleInset(
        [NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] GpAdjustableArrowCap* cap,
        [NativeTypeName("Gdiplus::REAL *")] float* middleInset
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetAdjustableArrowCapFillState(
        [NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] GpAdjustableArrowCap* cap,
        BOOL fillState
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetAdjustableArrowCapFillState(
        [NativeTypeName("Gdiplus::GpAdjustableArrowCap *")] GpAdjustableArrowCap* cap,
        BOOL* fillState
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipLoadImageFromStream(IStream stream, GpImage** image);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipLoadImageFromFile(
        [NativeTypeName("const WCHAR *")] ushort* filename,
        GpImage** image
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipLoadImageFromStreamICM(IStream stream, GpImage** image);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipLoadImageFromFileICM(
        [NativeTypeName("const WCHAR *")] ushort* filename,
        GpImage** image
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneImage(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        GpImage** cloneImage
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDisposeImage(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSaveImageToFile(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const WCHAR *")] ushort* filename,
        [NativeTypeName("const CLSID *")] Guid* clsidEncoder,
        [NativeTypeName("const EncoderParameters *")] EncoderParameters* encoderParams
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSaveImageToStream(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        IStream stream,
        [NativeTypeName("const CLSID *")] Guid* clsidEncoder,
        [NativeTypeName("const EncoderParameters *")] EncoderParameters* encoderParams
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSaveAdd(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const EncoderParameters *")] EncoderParameters* encoderParams
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSaveAddImage(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* newImage,
        [NativeTypeName("const EncoderParameters *")] EncoderParameters* encoderParams
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageGraphicsContext(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        GpGraphics** graphics
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageBounds(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::GpRectF *")] GpRectF* srcRect,
        [NativeTypeName("Gdiplus::GpUnit *")] GpUnit* srcUnit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageDimension(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::REAL *")] float* width,
        [NativeTypeName("Gdiplus::REAL *")] float* height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageType(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::ImageType *")] ImageType* type
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageWidth(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        uint* width
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageHeight(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        uint* height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageHorizontalResolution(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::REAL *")] float* resolution
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageVerticalResolution(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::REAL *")] float* resolution
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageFlags(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        uint* flags
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageRawFormat(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        Guid* format
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImagePixelFormat(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::PixelFormat *")] int* format
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageThumbnail(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        uint thumbWidth,
        uint thumbHeight,
        GpImage** thumbImage,
        [NativeTypeName("Gdiplus::GetThumbnailImageAbort")]
            delegate* unmanaged<void*, BOOL> callback,
        void* callbackData
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetEncoderParameterListSize(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const CLSID *")] Guid* clsidEncoder,
        uint* size
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetEncoderParameterList(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const CLSID *")] Guid* clsidEncoder,
        uint size,
        [NativeTypeName("Gdiplus::EncoderParameters *")] EncoderParameters* buffer
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipImageGetFrameDimensionsCount(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        uint* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipImageGetFrameDimensionsList(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        Guid* dimensionIDs,
        uint count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipImageGetFrameCount(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const GUID *")] Guid* dimensionID,
        uint* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipImageSelectActiveFrame(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const GUID *")] Guid* dimensionID,
        uint frameIndex
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipImageRotateFlip(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::RotateFlipType")] RotateFlipType rfType
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImagePalette(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::ColorPalette *")] ColorPalette* palette,
        int size
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImagePalette(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const ColorPalette *")] ColorPalette* palette
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImagePaletteSize(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        int* size
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPropertyCount(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        uint* numOfProperty
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPropertyIdList(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        uint numOfProperty,
        [NativeTypeName("PROPID *")] uint* list
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPropertyItemSize(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("PROPID")] uint propId,
        uint* size
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPropertyItem(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("PROPID")] uint propId,
        uint propSize,
        [NativeTypeName("Gdiplus::PropertyItem *")] PropertyItem* buffer
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPropertySize(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        uint* totalBufferSize,
        uint* numProperties
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetAllPropertyItems(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        uint totalBufferSize,
        uint numProperties,
        [NativeTypeName("Gdiplus::PropertyItem *")] PropertyItem* allItems
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRemovePropertyItem(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("PROPID")] uint propId
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPropertyItem(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const PropertyItem *")] PropertyItem* item
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFindFirstImageItem(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::ImageItemData *")] ImageItemData* item
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFindNextImageItem(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::ImageItemData *")] ImageItemData* item
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageItemData(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::ImageItemData *")] ImageItemData* item
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipImageForceValidation(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromStream(IStream stream, GpBitmap** bitmap);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromFile(
        [NativeTypeName("const WCHAR *")] ushort* filename,
        GpBitmap** bitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromStreamICM(IStream stream, GpBitmap** bitmap);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromFileICM(
        [NativeTypeName("const WCHAR *")] ushort* filename,
        GpBitmap** bitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromScan0(
        int width,
        int height,
        int stride,
        [NativeTypeName("Gdiplus::PixelFormat")] int format,
        byte* scan0,
        GpBitmap** bitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromGraphics(
        int width,
        int height,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* target,
        GpBitmap** bitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromDirectDrawSurface(
        IDirectDrawSurface7 surface,
        GpBitmap** bitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromGdiDib(
        [NativeTypeName("const BITMAPINFO *")] BITMAPINFO* gdiBitmapInfo,
        void* gdiBitmapData,
        GpBitmap** bitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromHBITMAP(
        HBITMAP hbm,
        HPALETTE hpal,
        GpBitmap** bitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateHBITMAPFromBitmap(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        HBITMAP* hbmReturn,
        [NativeTypeName("Gdiplus::ARGB")] uint background
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromHICON(HICON hicon, GpBitmap** bitmap);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateHICONFromBitmap(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        HICON* hbmReturn
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateBitmapFromResource(
        HINSTANCE hInstance,
        [NativeTypeName("const WCHAR *")] ushort* lpBitmapName,
        GpBitmap** bitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneBitmapArea(
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        [NativeTypeName("Gdiplus::PixelFormat")] int format,
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* srcBitmap,
        GpBitmap** dstBitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneBitmapAreaI(
        int x,
        int y,
        int width,
        int height,
        [NativeTypeName("Gdiplus::PixelFormat")] int format,
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* srcBitmap,
        GpBitmap** dstBitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapLockBits(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        [NativeTypeName("const GpRect *")] GpRect* rect,
        uint flags,
        [NativeTypeName("Gdiplus::PixelFormat")] int format,
        [NativeTypeName("Gdiplus::BitmapData *")] BitmapData* lockedBitmapData
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapUnlockBits(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        [NativeTypeName("Gdiplus::BitmapData *")] BitmapData* lockedBitmapData
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapGetPixel(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        int x,
        int y,
        [NativeTypeName("Gdiplus::ARGB *")] uint* color
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapSetPixel(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        int x,
        int y,
        [NativeTypeName("Gdiplus::ARGB")] uint color
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipImageSetAbort(
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* pImage,
        [NativeTypeName("Gdiplus::GdiplusAbort *")] GdiplusAbort* pIAbort
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGraphicsSetAbort(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* pGraphics,
        [NativeTypeName("Gdiplus::GdiplusAbort *")] GdiplusAbort* pIAbort
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapConvertFormat(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* pInputBitmap,
        [NativeTypeName("Gdiplus::PixelFormat")] int format,
        [NativeTypeName("Gdiplus::DitherType")] DitherType dithertype,
        [NativeTypeName("Gdiplus::PaletteType")] PaletteType palettetype,
        [NativeTypeName("Gdiplus::ColorPalette *")] ColorPalette* palette,
        [NativeTypeName("Gdiplus::REAL")] float alphaThresholdPercent
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipInitializePalette(
        [NativeTypeName("Gdiplus::ColorPalette *")] ColorPalette* palette,
        [NativeTypeName("Gdiplus::PaletteType")] PaletteType palettetype,
        int optimalColors,
        BOOL useTransparentColor,
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapApplyEffect(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        [NativeTypeName("Gdiplus::CGpEffect *")] CGpEffect* effect,
        RECT* roi,
        BOOL useAuxData,
        void** auxData,
        int* auxDataSize
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapCreateApplyEffect(
        GpBitmap** inputBitmaps,
        int numInputs,
        [NativeTypeName("Gdiplus::CGpEffect *")] CGpEffect* effect,
        RECT* roi,
        RECT* outputRect,
        GpBitmap** outputBitmap,
        BOOL useAuxData,
        void** auxData,
        int* auxDataSize
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapGetHistogram(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        [NativeTypeName("Gdiplus::HistogramFormat")] HistogramFormat format,
        uint NumberOfEntries,
        uint* channel0,
        uint* channel1,
        uint* channel2,
        uint* channel3
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapGetHistogramSize(
        [NativeTypeName("Gdiplus::HistogramFormat")] HistogramFormat format,
        uint* NumberOfEntries
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBitmapSetResolution(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        [NativeTypeName("Gdiplus::REAL")] float xdpi,
        [NativeTypeName("Gdiplus::REAL")] float ydpi
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateImageAttributes(GpImageAttributes** imageattr);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneImageAttributes(
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageattr,
        GpImageAttributes** cloneImageattr
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDisposeImageAttributes(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesToIdentity(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipResetImageAttributes(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesColorMatrix(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type,
        BOOL enableFlag,
        [NativeTypeName("const ColorMatrix *")] ColorMatrix* colorMatrix,
        [NativeTypeName("const ColorMatrix *")] ColorMatrix* grayMatrix,
        [NativeTypeName("Gdiplus::ColorMatrixFlags")] ColorMatrixFlags flags
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesThreshold(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type,
        BOOL enableFlag,
        [NativeTypeName("Gdiplus::REAL")] float threshold
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesGamma(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type,
        BOOL enableFlag,
        [NativeTypeName("Gdiplus::REAL")] float gamma
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesNoOp(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type,
        BOOL enableFlag
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesColorKeys(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type,
        BOOL enableFlag,
        [NativeTypeName("Gdiplus::ARGB")] uint colorLow,
        [NativeTypeName("Gdiplus::ARGB")] uint colorHigh
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesOutputChannel(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type,
        BOOL enableFlag,
        [NativeTypeName("Gdiplus::ColorChannelFlags")] ColorChannelFlags channelFlags
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesOutputChannelColorProfile(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type,
        BOOL enableFlag,
        [NativeTypeName("const WCHAR *")] ushort* colorProfileFilename
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesRemapTable(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType type,
        BOOL enableFlag,
        uint mapSize,
        [NativeTypeName("const ColorMap *")] ColorMap* map
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesWrapMode(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageAttr,
        [NativeTypeName("Gdiplus::WrapMode")] GpWrapMode wrap,
        [NativeTypeName("Gdiplus::ARGB")] uint argb,
        BOOL clamp
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageAttributesAdjustedPalette(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageAttr,
        [NativeTypeName("Gdiplus::ColorPalette *")] ColorPalette* colorPalette,
        [NativeTypeName("Gdiplus::ColorAdjustType")] ColorAdjustType colorAdjustType
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFlush(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpFlushIntention")] GpFlushIntention intention
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateFromHDC(HDC hdc, GpGraphics** graphics);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateFromHDC2(
        HDC hdc,
        HANDLE hDevice,
        GpGraphics** graphics
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateFromHWND(HWND hwnd, GpGraphics** graphics);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateFromHWNDICM(HWND hwnd, GpGraphics** graphics);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeleteGraphics(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetDC(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        HDC* hdc
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipReleaseDC(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        HDC hdc
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetCompositingMode(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::CompositingMode")] CompositingMode compositingMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCompositingMode(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::CompositingMode *")] CompositingMode* compositingMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetRenderingOrigin(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        int x,
        int y
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetRenderingOrigin(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        int* x,
        int* y
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetCompositingQuality(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::CompositingQuality")] CompositingQuality compositingQuality
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCompositingQuality(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::CompositingQuality *")] CompositingQuality* compositingQuality
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetSmoothingMode(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::SmoothingMode")] SmoothingMode smoothingMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetSmoothingMode(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::SmoothingMode *")] SmoothingMode* smoothingMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPixelOffsetMode(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::PixelOffsetMode")] PixelOffsetMode pixelOffsetMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPixelOffsetMode(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::PixelOffsetMode *")] PixelOffsetMode* pixelOffsetMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetTextRenderingHint(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::TextRenderingHint")] TextRenderingHint mode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetTextRenderingHint(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::TextRenderingHint *")] TextRenderingHint* mode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetTextContrast(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        uint contrast
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetTextContrast(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        uint* contrast
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetInterpolationMode(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::InterpolationMode")] InterpolationMode interpolationMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetInterpolationMode(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::InterpolationMode *")] InterpolationMode* interpolationMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetWorldTransform(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipResetWorldTransform(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipMultiplyWorldTransform(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslateWorldTransform(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL")] float dx,
        [NativeTypeName("Gdiplus::REAL")] float dy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipScaleWorldTransform(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL")] float sx,
        [NativeTypeName("Gdiplus::REAL")] float sy,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRotateWorldTransform(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL")] float angle,
        [NativeTypeName("Gdiplus::GpMatrixOrder")] GpMatrixOrder order
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetWorldTransform(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipResetPageTransform(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPageUnit(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpUnit *")] GpUnit* unit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetPageScale(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL *")] float* scale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPageUnit(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit unit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetPageScale(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL")] float scale
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetDpiX(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL *")] float* dpi
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetDpiY(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL *")] float* dpi
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTransformPoints(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpCoordinateSpace")] GpCoordinateSpace destSpace,
        [NativeTypeName("Gdiplus::GpCoordinateSpace")] GpCoordinateSpace srcSpace,
        [NativeTypeName("Gdiplus::GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTransformPointsI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpCoordinateSpace")] GpCoordinateSpace destSpace,
        [NativeTypeName("Gdiplus::GpCoordinateSpace")] GpCoordinateSpace srcSpace,
        [NativeTypeName("Gdiplus::GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetNearestColor(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::ARGB *")] uint* argb
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    public static extern HPALETTE GdipCreateHalftonePalette();

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawLine(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float x1,
        [NativeTypeName("Gdiplus::REAL")] float y1,
        [NativeTypeName("Gdiplus::REAL")] float x2,
        [NativeTypeName("Gdiplus::REAL")] float y2
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawLineI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        int x1,
        int y1,
        int x2,
        int y2
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawLines(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawLinesI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawArc(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawArcI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        int x,
        int y,
        int width,
        int height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawBezier(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float x1,
        [NativeTypeName("Gdiplus::REAL")] float y1,
        [NativeTypeName("Gdiplus::REAL")] float x2,
        [NativeTypeName("Gdiplus::REAL")] float y2,
        [NativeTypeName("Gdiplus::REAL")] float x3,
        [NativeTypeName("Gdiplus::REAL")] float y3,
        [NativeTypeName("Gdiplus::REAL")] float x4,
        [NativeTypeName("Gdiplus::REAL")] float y4
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawBezierI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        int x1,
        int y1,
        int x2,
        int y2,
        int x3,
        int y3,
        int x4,
        int y4
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawBeziers(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawBeziersI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawRectangle(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawRectangleI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        int x,
        int y,
        int width,
        int height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawRectangles(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpRectF *")] GpRectF* rects,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawRectanglesI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpRect *")] GpRect* rects,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawEllipse(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawEllipseI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        int x,
        int y,
        int width,
        int height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawPie(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawPieI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        int x,
        int y,
        int width,
        int height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawPolygon(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawPolygonI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawPath(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawCurve(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawCurveI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawCurve2(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawCurve2I(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawCurve3(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        int offset,
        int numberOfSegments,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawCurve3I(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        int offset,
        int numberOfSegments,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawClosedCurve(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawClosedCurveI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawClosedCurve2(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawClosedCurve2I(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPen *")] GpPen* pen,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGraphicsClear(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::ARGB")] uint color
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillRectangle(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillRectangleI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        int x,
        int y,
        int width,
        int height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillRectangles(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpRectF *")] GpRectF* rects,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillRectanglesI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpRect *")] GpRect* rects,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillPolygon(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        [NativeTypeName("Gdiplus::GpFillMode")] GpFillMode fillMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillPolygonI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        [NativeTypeName("Gdiplus::GpFillMode")] GpFillMode fillMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillPolygon2(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillPolygon2I(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillEllipse(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillEllipseI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        int x,
        int y,
        int width,
        int height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillPie(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillPieI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        int x,
        int y,
        int width,
        int height,
        [NativeTypeName("Gdiplus::REAL")] float startAngle,
        [NativeTypeName("Gdiplus::REAL")] float sweepAngle
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillPath(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillClosedCurve(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillClosedCurveI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillClosedCurve2(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension,
        [NativeTypeName("Gdiplus::GpFillMode")] GpFillMode fillMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillClosedCurve2I(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float tension,
        [NativeTypeName("Gdiplus::GpFillMode")] GpFillMode fillMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipFillRegion(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpBrush *")] GpBrush* brush,
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImageFX(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::GpRectF *")] GpRectF* source,
        [NativeTypeName("Gdiplus::GpMatrix *")] GpMatrix* xForm,
        [NativeTypeName("Gdiplus::CGpEffect *")] CGpEffect* effect,
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageAttributes,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit srcUnit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImage(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImageI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        int x,
        int y
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImageRect(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImageRectI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        int x,
        int y,
        int width,
        int height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImagePoints(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const GpPointF *")] GpPointF* dstpoints,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImagePointsI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const GpPoint *")] GpPoint* dstpoints,
        int count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImagePointRect(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float srcx,
        [NativeTypeName("Gdiplus::REAL")] float srcy,
        [NativeTypeName("Gdiplus::REAL")] float srcwidth,
        [NativeTypeName("Gdiplus::REAL")] float srcheight,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit srcUnit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImagePointRectI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        int x,
        int y,
        int srcx,
        int srcy,
        int srcwidth,
        int srcheight,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit srcUnit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImageRectRect(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("Gdiplus::REAL")] float dstx,
        [NativeTypeName("Gdiplus::REAL")] float dsty,
        [NativeTypeName("Gdiplus::REAL")] float dstwidth,
        [NativeTypeName("Gdiplus::REAL")] float dstheight,
        [NativeTypeName("Gdiplus::REAL")] float srcx,
        [NativeTypeName("Gdiplus::REAL")] float srcy,
        [NativeTypeName("Gdiplus::REAL")] float srcwidth,
        [NativeTypeName("Gdiplus::REAL")] float srcheight,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit srcUnit,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes,
        [NativeTypeName("Gdiplus::DrawImageAbort")] delegate* unmanaged<void*, BOOL> callback,
        void* callbackData
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImageRectRectI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        int dstx,
        int dsty,
        int dstwidth,
        int dstheight,
        int srcx,
        int srcy,
        int srcwidth,
        int srcheight,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit srcUnit,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes,
        [NativeTypeName("Gdiplus::DrawImageAbort")] delegate* unmanaged<void*, BOOL> callback,
        void* callbackData
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImagePointsRect(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const GpPointF *")] GpPointF* points,
        int count,
        [NativeTypeName("Gdiplus::REAL")] float srcx,
        [NativeTypeName("Gdiplus::REAL")] float srcy,
        [NativeTypeName("Gdiplus::REAL")] float srcwidth,
        [NativeTypeName("Gdiplus::REAL")] float srcheight,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit srcUnit,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes,
        [NativeTypeName("Gdiplus::DrawImageAbort")] delegate* unmanaged<void*, BOOL> callback,
        void* callbackData
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawImagePointsRectI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpImage *")] GpImage* image,
        [NativeTypeName("const GpPoint *")] GpPoint* points,
        int count,
        int srcx,
        int srcy,
        int srcwidth,
        int srcheight,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit srcUnit,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes,
        [NativeTypeName("Gdiplus::DrawImageAbort")] delegate* unmanaged<void*, BOOL> callback,
        void* callbackData
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileDestPoint(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const PointF &")] GpPointF* destPoint,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileDestPointI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const Point &")] GpPoint* destPoint,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileDestRect(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const RectF &")] GpRectF* destRect,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileDestRectI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const Rect &")] GpRect* destRect,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileDestPoints(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const PointF *")] GpPointF* destPoints,
        int count,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileDestPointsI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const Point *")] GpPoint* destPoints,
        int count,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileSrcRectDestPoint(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const PointF &")] GpPointF* destPoint,
        [NativeTypeName("const RectF &")] GpRectF* srcRect,
        [NativeTypeName("Gdiplus::Unit")] GpUnit srcUnit,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileSrcRectDestPointI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const Point &")] GpPoint* destPoint,
        [NativeTypeName("const Rect &")] GpRect* srcRect,
        [NativeTypeName("Gdiplus::Unit")] GpUnit srcUnit,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileSrcRectDestRect(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const RectF &")] GpRectF* destRect,
        [NativeTypeName("const RectF &")] GpRectF* srcRect,
        [NativeTypeName("Gdiplus::Unit")] GpUnit srcUnit,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileSrcRectDestRectI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const Rect &")] GpRect* destRect,
        [NativeTypeName("const Rect &")] GpRect* srcRect,
        [NativeTypeName("Gdiplus::Unit")] GpUnit srcUnit,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileSrcRectDestPoints(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const PointF *")] GpPointF* destPoints,
        int count,
        [NativeTypeName("const RectF &")] GpRectF* srcRect,
        [NativeTypeName("Gdiplus::Unit")] GpUnit srcUnit,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEnumerateMetafileSrcRectDestPointsI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("const Point *")] GpPoint* destPoints,
        int count,
        [NativeTypeName("const Rect &")] GpRect* srcRect,
        [NativeTypeName("Gdiplus::Unit")] GpUnit srcUnit,
        [NativeTypeName("Gdiplus::EnumerateMetafileProc")]
            delegate* unmanaged<EmfPlusRecordType, uint, uint, byte*, void*, BOOL> callback,
        void* callbackData,
        [NativeTypeName("const GpImageAttributes *")] GpImageAttributes* imageAttributes
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPlayMetafileRecord(
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("Gdiplus::EmfPlusRecordType")] EmfPlusRecordType recordType,
        uint flags,
        uint dataSize,
        [NativeTypeName("const BYTE *")] byte* data
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetClipGraphics(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* srcgraphics,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetClipRect(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetClipRectI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        int x,
        int y,
        int width,
        int height,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetClipPath(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpPath *")] GpPath* path,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetClipRegion(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetClipHrgn(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        HRGN hRgn,
        [NativeTypeName("Gdiplus::CombineMode")] CombineMode combineMode
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipResetClip(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslateClip(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL")] float dx,
        [NativeTypeName("Gdiplus::REAL")] float dy
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTranslateClipI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        int dx,
        int dy
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetClip(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpRegion *")] GpRegion* region
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetClipBounds(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpRectF *")] GpRectF* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetClipBoundsI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpRect *")] GpRect* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsClipEmpty(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetVisibleClipBounds(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpRectF *")] GpRectF* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetVisibleClipBoundsI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpRect *")] GpRect* rect
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisibleClipEmpty(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisiblePoint(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisiblePointI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        int x,
        int y,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisibleRect(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y,
        [NativeTypeName("Gdiplus::REAL")] float width,
        [NativeTypeName("Gdiplus::REAL")] float height,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsVisibleRectI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        int x,
        int y,
        int width,
        int height,
        BOOL* result
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSaveGraphics(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GraphicsState *")] uint* state
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRestoreGraphics(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GraphicsState")] uint state
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBeginContainer(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpRectF *")] GpRectF* dstrect,
        [NativeTypeName("const GpRectF *")] GpRectF* srcrect,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit unit,
        [NativeTypeName("Gdiplus::GraphicsContainer *")] uint* state
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBeginContainerI(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const GpRect *")] GpRect* dstrect,
        [NativeTypeName("const GpRect *")] GpRect* srcrect,
        [NativeTypeName("Gdiplus::GpUnit")] GpUnit unit,
        [NativeTypeName("Gdiplus::GraphicsContainer *")] uint* state
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipBeginContainer2(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GraphicsContainer *")] uint* state
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipEndContainer(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GraphicsContainer")] uint state
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetMetafileHeaderFromWmf(
        HMETAFILE hWmf,
        [NativeTypeName("const WmfPlaceableFileHeader *")]
            WmfPlaceableFileHeader* wmfPlaceableFileHeader,
        [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetMetafileHeaderFromEmf(
        HENHMETAFILE hEmf,
        [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetMetafileHeaderFromFile(
        [NativeTypeName("const WCHAR *")] ushort* filename,
        [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetMetafileHeaderFromStream(
        IStream stream,
        [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetMetafileHeaderFromMetafile(
        [NativeTypeName("Gdiplus::GpMetafile *")] GpMetafile* metafile,
        [NativeTypeName("Gdiplus::MetafileHeader *")] MetafileHeader* header
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetHemfFromMetafile(
        [NativeTypeName("Gdiplus::GpMetafile *")] GpMetafile* metafile,
        HENHMETAFILE* hEmf
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateStreamOnFile(
        [NativeTypeName("const WCHAR *")] ushort* filename,
        uint access,
        IStream* stream
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateMetafileFromWmf(
        HMETAFILE hWmf,
        BOOL deleteWmf,
        [NativeTypeName("const WmfPlaceableFileHeader *")]
            WmfPlaceableFileHeader* wmfPlaceableFileHeader,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateMetafileFromEmf(
        HENHMETAFILE hEmf,
        BOOL deleteEmf,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateMetafileFromFile(
        [NativeTypeName("const WCHAR *")] ushort* file,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateMetafileFromWmfFile(
        [NativeTypeName("const WCHAR *")] ushort* file,
        [NativeTypeName("const WmfPlaceableFileHeader *")]
            WmfPlaceableFileHeader* wmfPlaceableFileHeader,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateMetafileFromStream(
        IStream stream,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRecordMetafile(
        HDC referenceHdc,
        [NativeTypeName("Gdiplus::EmfType")] EmfType type,
        [NativeTypeName("const GpRectF *")] GpRectF* frameRect,
        [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit,
        [NativeTypeName("const WCHAR *")] ushort* description,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRecordMetafileI(
        HDC referenceHdc,
        [NativeTypeName("Gdiplus::EmfType")] EmfType type,
        [NativeTypeName("const GpRect *")] GpRect* frameRect,
        [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit,
        [NativeTypeName("const WCHAR *")] ushort* description,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRecordMetafileFileName(
        [NativeTypeName("const WCHAR *")] ushort* fileName,
        HDC referenceHdc,
        [NativeTypeName("Gdiplus::EmfType")] EmfType type,
        [NativeTypeName("const GpRectF *")] GpRectF* frameRect,
        [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit,
        [NativeTypeName("const WCHAR *")] ushort* description,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRecordMetafileFileNameI(
        [NativeTypeName("const WCHAR *")] ushort* fileName,
        HDC referenceHdc,
        [NativeTypeName("Gdiplus::EmfType")] EmfType type,
        [NativeTypeName("const GpRect *")] GpRect* frameRect,
        [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit,
        [NativeTypeName("const WCHAR *")] ushort* description,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRecordMetafileStream(
        IStream stream,
        HDC referenceHdc,
        [NativeTypeName("Gdiplus::EmfType")] EmfType type,
        [NativeTypeName("const GpRectF *")] GpRectF* frameRect,
        [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit,
        [NativeTypeName("const WCHAR *")] ushort* description,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipRecordMetafileStreamI(
        IStream stream,
        HDC referenceHdc,
        [NativeTypeName("Gdiplus::EmfType")] EmfType type,
        [NativeTypeName("const GpRect *")] GpRect* frameRect,
        [NativeTypeName("Gdiplus::MetafileFrameUnit")] MetafileFrameUnit frameUnit,
        [NativeTypeName("const WCHAR *")] ushort* description,
        GpMetafile** metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetMetafileDownLevelRasterizationLimit(
        [NativeTypeName("Gdiplus::GpMetafile *")] GpMetafile* metafile,
        uint metafileRasterizationLimitDpi
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetMetafileDownLevelRasterizationLimit(
        [NativeTypeName("const GpMetafile *")] GpMetafile* metafile,
        uint* metafileRasterizationLimitDpi
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageDecodersSize(uint* numDecoders, uint* size);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageDecoders(
        uint numDecoders,
        uint size,
        [NativeTypeName("Gdiplus::ImageCodecInfo *")] ImageCodecInfo* decoders
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageEncodersSize(uint* numEncoders, uint* size);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetImageEncoders(
        uint numEncoders,
        uint size,
        [NativeTypeName("Gdiplus::ImageCodecInfo *")] ImageCodecInfo* encoders
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipComment(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        uint sizeData,
        [NativeTypeName("const BYTE *")] byte* data
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateFontFamilyFromName(
        [NativeTypeName("const WCHAR *")] ushort* name,
        [NativeTypeName("Gdiplus::GpFontCollection *")] GpFontCollection* fontCollection,
        GpFontFamily** fontFamily
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeleteFontFamily(
        [NativeTypeName("Gdiplus::GpFontFamily *")] GpFontFamily* fontFamily
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneFontFamily(
        [NativeTypeName("Gdiplus::GpFontFamily *")] GpFontFamily* fontFamily,
        GpFontFamily** clonedFontFamily
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetGenericFontFamilySansSerif(GpFontFamily** nativeFamily);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetGenericFontFamilySerif(GpFontFamily** nativeFamily);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetGenericFontFamilyMonospace(GpFontFamily** nativeFamily);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetFamilyName(
        [NativeTypeName("const GpFontFamily *")] GpFontFamily* family,
        [NativeTypeName("LPWSTR")] ushort* name,
        [NativeTypeName("LANGID")] ushort language
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipIsStyleAvailable(
        [NativeTypeName("const GpFontFamily *")] GpFontFamily* family,
        int style,
        BOOL* IsStyleAvailable
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetEmHeight(
        [NativeTypeName("const GpFontFamily *")] GpFontFamily* family,
        int style,
        [NativeTypeName("UINT16 *")] ushort* EmHeight
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCellAscent(
        [NativeTypeName("const GpFontFamily *")] GpFontFamily* family,
        int style,
        [NativeTypeName("UINT16 *")] ushort* CellAscent
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetCellDescent(
        [NativeTypeName("const GpFontFamily *")] GpFontFamily* family,
        int style,
        [NativeTypeName("UINT16 *")] ushort* CellDescent
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLineSpacing(
        [NativeTypeName("const GpFontFamily *")] GpFontFamily* family,
        int style,
        [NativeTypeName("UINT16 *")] ushort* LineSpacing
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateFontFromDC(HDC hdc, GpFont** font);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateFontFromLogfontA(
        HDC hdc,
        [NativeTypeName("const LOGFONTA *")] LOGFONTA* logfont,
        GpFont** font
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateFontFromLogfontW(
        HDC hdc,
        [NativeTypeName("const LOGFONTW *")] LOGFONTW* logfont,
        GpFont** font
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateFont(
        [NativeTypeName("const GpFontFamily *")] GpFontFamily* fontFamily,
        [NativeTypeName("Gdiplus::REAL")] float emSize,
        int style,
        [NativeTypeName("Gdiplus::Unit")] GpUnit unit,
        GpFont** font
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneFont(
        [NativeTypeName("Gdiplus::GpFont *")] GpFont* font,
        GpFont** cloneFont
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeleteFont(
        [NativeTypeName("Gdiplus::GpFont *")] GpFont* font
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetFamily(
        [NativeTypeName("Gdiplus::GpFont *")] GpFont* font,
        GpFontFamily** family
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetFontStyle(
        [NativeTypeName("Gdiplus::GpFont *")] GpFont* font,
        int* style
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetFontSize(
        [NativeTypeName("Gdiplus::GpFont *")] GpFont* font,
        [NativeTypeName("Gdiplus::REAL *")] float* size
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetFontUnit(
        [NativeTypeName("Gdiplus::GpFont *")] GpFont* font,
        [NativeTypeName("Gdiplus::Unit *")] GpUnit* unit
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetFontHeight(
        [NativeTypeName("const GpFont *")] GpFont* font,
        [NativeTypeName("const GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::REAL *")] float* height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetFontHeightGivenDPI(
        [NativeTypeName("const GpFont *")] GpFont* font,
        [NativeTypeName("Gdiplus::REAL")] float dpi,
        [NativeTypeName("Gdiplus::REAL *")] float* height
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLogFontA(
        [NativeTypeName("Gdiplus::GpFont *")] GpFont* font,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        LOGFONTA* logfontA
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetLogFontW(
        [NativeTypeName("Gdiplus::GpFont *")] GpFont* font,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        LOGFONTW* logfontW
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipNewInstalledFontCollection(GpFontCollection** fontCollection);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipNewPrivateFontCollection(GpFontCollection** fontCollection);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeletePrivateFontCollection(
        GpFontCollection** fontCollection
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetFontCollectionFamilyCount(
        [NativeTypeName("Gdiplus::GpFontCollection *")] GpFontCollection* fontCollection,
        int* numFound
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetFontCollectionFamilyList(
        [NativeTypeName("Gdiplus::GpFontCollection *")] GpFontCollection* fontCollection,
        int numSought,
        [NativeTypeName("GpFontFamily *[]")] GpFontFamily** gpfamilies,
        int* numFound
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPrivateAddFontFile(
        [NativeTypeName("Gdiplus::GpFontCollection *")] GpFontCollection* fontCollection,
        [NativeTypeName("const WCHAR *")] ushort* filename
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipPrivateAddMemoryFont(
        [NativeTypeName("Gdiplus::GpFontCollection *")] GpFontCollection* fontCollection,
        [NativeTypeName("const void *")] void* memory,
        int length
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawString(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const WCHAR *")] ushort* @string,
        int length,
        [NativeTypeName("const GpFont *")] GpFont* font,
        [NativeTypeName("const RectF *")] GpRectF* layoutRect,
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* stringFormat,
        [NativeTypeName("const GpBrush *")] GpBrush* brush
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipMeasureString(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const WCHAR *")] ushort* @string,
        int length,
        [NativeTypeName("const GpFont *")] GpFont* font,
        [NativeTypeName("const RectF *")] GpRectF* layoutRect,
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* stringFormat,
        [NativeTypeName("Gdiplus::RectF *")] GpRectF* boundingBox,
        int* codepointsFitted,
        int* linesFilled
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipMeasureCharacterRanges(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const WCHAR *")] ushort* @string,
        int length,
        [NativeTypeName("const GpFont *")] GpFont* font,
        [NativeTypeName("const RectF &")] GpRectF* layoutRect,
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* stringFormat,
        int regionCount,
        GpRegion** regions
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawDriverString(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const UINT16 *")] ushort* text,
        int length,
        [NativeTypeName("const GpFont *")] GpFont* font,
        [NativeTypeName("const GpBrush *")] GpBrush* brush,
        [NativeTypeName("const PointF *")] GpPointF* positions,
        int flags,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipMeasureDriverString(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("const UINT16 *")] ushort* text,
        int length,
        [NativeTypeName("const GpFont *")] GpFont* font,
        [NativeTypeName("const PointF *")] GpPointF* positions,
        int flags,
        [NativeTypeName("const GpMatrix *")] GpMatrix* matrix,
        [NativeTypeName("Gdiplus::RectF *")] GpRectF* boundingBox
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateStringFormat(
        int formatAttributes,
        [NativeTypeName("LANGID")] ushort language,
        GpStringFormat** format
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipStringFormatGetGenericDefault(GpStringFormat** format);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipStringFormatGetGenericTypographic(GpStringFormat** format);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeleteStringFormat(
        [NativeTypeName("Gdiplus::GpStringFormat *")] GpStringFormat* format
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCloneStringFormat(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        GpStringFormat** newFormat
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetStringFormatFlags(
        [NativeTypeName("Gdiplus::GpStringFormat *")] GpStringFormat* format,
        int flags
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetStringFormatFlags(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        int* flags
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetStringFormatAlign(
        [NativeTypeName("Gdiplus::GpStringFormat *")] GpStringFormat* format,
        [NativeTypeName("Gdiplus::StringAlignment")] StringAlignment align
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetStringFormatAlign(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        [NativeTypeName("Gdiplus::StringAlignment *")] StringAlignment* align
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetStringFormatLineAlign(
        [NativeTypeName("Gdiplus::GpStringFormat *")] GpStringFormat* format,
        [NativeTypeName("Gdiplus::StringAlignment")] StringAlignment align
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetStringFormatLineAlign(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        [NativeTypeName("Gdiplus::StringAlignment *")] StringAlignment* align
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetStringFormatTrimming(
        [NativeTypeName("Gdiplus::GpStringFormat *")] GpStringFormat* format,
        [NativeTypeName("Gdiplus::StringTrimming")] StringTrimming trimming
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetStringFormatTrimming(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        [NativeTypeName("Gdiplus::StringTrimming *")] StringTrimming* trimming
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetStringFormatHotkeyPrefix(
        [NativeTypeName("Gdiplus::GpStringFormat *")] GpStringFormat* format,
        int hotkeyPrefix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetStringFormatHotkeyPrefix(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        int* hotkeyPrefix
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetStringFormatTabStops(
        [NativeTypeName("Gdiplus::GpStringFormat *")] GpStringFormat* format,
        [NativeTypeName("Gdiplus::REAL")] float firstTabOffset,
        int count,
        [NativeTypeName("const REAL *")] float* tabStops
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetStringFormatTabStops(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        int count,
        [NativeTypeName("Gdiplus::REAL *")] float* firstTabOffset,
        [NativeTypeName("Gdiplus::REAL *")] float* tabStops
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetStringFormatTabStopCount(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetStringFormatDigitSubstitution(
        [NativeTypeName("Gdiplus::GpStringFormat *")] GpStringFormat* format,
        [NativeTypeName("LANGID")] ushort language,
        [NativeTypeName("Gdiplus::StringDigitSubstitute")] StringDigitSubstitute substitute
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetStringFormatDigitSubstitution(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        [NativeTypeName("LANGID *")] ushort* language,
        [NativeTypeName("Gdiplus::StringDigitSubstitute *")] StringDigitSubstitute* substitute
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipGetStringFormatMeasurableCharacterRangeCount(
        [NativeTypeName("const GpStringFormat *")] GpStringFormat* format,
        int* count
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetStringFormatMeasurableCharacterRanges(
        [NativeTypeName("Gdiplus::GpStringFormat *")] GpStringFormat* format,
        int rangeCount,
        [NativeTypeName("const CharacterRange *")] CharacterRange* ranges
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipCreateCachedBitmap(
        [NativeTypeName("Gdiplus::GpBitmap *")] GpBitmap* bitmap,
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        GpCachedBitmap** cachedBitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDeleteCachedBitmap(
        [NativeTypeName("Gdiplus::GpCachedBitmap *")] GpCachedBitmap* cachedBitmap
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipDrawCachedBitmap(
        [NativeTypeName("Gdiplus::GpGraphics *")] GpGraphics* graphics,
        [NativeTypeName("Gdiplus::GpCachedBitmap *")] GpCachedBitmap* cachedBitmap,
        int x,
        int y
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    public static extern uint GdipEmfToWmfBits(
        HENHMETAFILE hemf,
        uint cbData16,
        [NativeTypeName("LPBYTE")] byte* pData16,
        int iMapMode,
        int eFlags
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipSetImageAttributesCachedBackground(
        [NativeTypeName("Gdiplus::GpImageAttributes *")] GpImageAttributes* imageattr,
        BOOL enableFlag
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipTestControl(
        [NativeTypeName("Gdiplus::GpTestControlEnum")] GpTestControlEnum control,
        void* param1
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdiplusNotificationHook(
        [NativeTypeName("ULONG_PTR *")] nuint* token
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    public static extern void GdiplusNotificationUnhook([NativeTypeName("ULONG_PTR")] nuint token);

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipConvertToEmfPlus(
        [NativeTypeName("const GpGraphics *")] GpGraphics* refGraphics,
        [NativeTypeName("Gdiplus::GpMetafile *")] GpMetafile* metafile,
        int* conversionFailureFlag,
        [NativeTypeName("Gdiplus::EmfType")] EmfType emfType,
        [NativeTypeName("const WCHAR *")] ushort* description,
        GpMetafile** out_metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipConvertToEmfPlusToFile(
        [NativeTypeName("const GpGraphics *")] GpGraphics* refGraphics,
        [NativeTypeName("Gdiplus::GpMetafile *")] GpMetafile* metafile,
        int* conversionFailureFlag,
        [NativeTypeName("const WCHAR *")] ushort* filename,
        [NativeTypeName("Gdiplus::EmfType")] EmfType emfType,
        [NativeTypeName("const WCHAR *")] ushort* description,
        GpMetafile** out_metafile
    );

    [DllImport("gdiplus", ExactSpelling = true)]
    [return: NativeTypeName("Gdiplus::GpStatus")]
    public static extern GpStatus GdipConvertToEmfPlusToStream(
        [NativeTypeName("const GpGraphics *")] GpGraphics* refGraphics,
        [NativeTypeName("Gdiplus::GpMetafile *")] GpMetafile* metafile,
        int* conversionFailureFlag,
        IStream stream,
        [NativeTypeName("Gdiplus::EmfType")] EmfType emfType,
        [NativeTypeName("const WCHAR *")] ushort* description,
        GpMetafile** out_metafile
    );
}
