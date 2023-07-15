// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;
/// <include file='GpPoint.xml' path='doc/member[@name="GpPoint"]/*'/>
public unsafe partial struct GpPoint
{
    /// <include file='GpPoint.xml' path='doc/member[@name="GpPoint.X"]/*'/>
    public int X;
    /// <include file='GpPoint.xml' path='doc/member[@name="GpPoint.Y"]/*'/>
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