// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct GpPointF
{
    [NativeTypeName("Gdiplus::REAL")]
    public float X;

    [NativeTypeName("Gdiplus::REAL")]
    public float Y;

    public GpPointF()
    {
        X = Y = 0.0f;
    }

    public GpPointF([NativeTypeName("const PointF &")] GpPointF* point)
    {
        X = point->X;
        Y = point->Y;
    }

    public GpPointF([NativeTypeName("const SizeF &")] GpSizeF* size)
    {
        X = size->Width;
        Y = size->Height;
    }

    public GpPointF(
        [NativeTypeName("Gdiplus::REAL")] float x,
        [NativeTypeName("Gdiplus::REAL")] float y
    )
    {
        X = x;
        Y = y;
    }

    public BOOL Equals([NativeTypeName("const PointF &")] GpPointF* point)
    {
        return ((X == point->X) && (Y == point->Y)) ? 1 : 0;
    }
}
