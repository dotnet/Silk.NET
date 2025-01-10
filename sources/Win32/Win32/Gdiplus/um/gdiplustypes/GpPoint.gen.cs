// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Gdiplus;

public unsafe partial struct GpPoint
{
    public int X;
    public int Y;

    public GpPoint()
    {
        X = Y = 0;
    }

    public GpPoint([NativeTypeName("const Point &")] GpPoint* point)
    {
        X = point->X;
        Y = point->Y;
    }

    public GpPoint([NativeTypeName("const Size &")] Size* size)
    {
        X = size->Width;
        Y = size->Height;
    }

    public GpPoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public BOOL Equals([NativeTypeName("const Point &")] GpPoint* point)
    {
        return ((X == point->X) && (Y == point->Y)) ? 1 : 0;
    }
}
