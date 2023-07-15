// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;
/// <include file='GpRect.xml' path='doc/member[@name="GpRect"]/*'/>
public unsafe partial struct GpRect
{
    /// <include file='GpRect.xml' path='doc/member[@name="GpRect.X"]/*'/>
    public int X;
    /// <include file='GpRect.xml' path='doc/member[@name="GpRect.Y"]/*'/>
    public int Y;
    /// <include file='GpRect.xml' path='doc/member[@name="GpRect.Width"]/*'/>
    public int Width;
    /// <include file='GpRect.xml' path='doc/member[@name="GpRect.Height"]/*'/>
    public int Height;
    public GpRect()
    {
        X = Y = Width = Height = 0;
    }

    public GpRect(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public GpRect([NativeTypeName("const Point &")] GpPoint* location, [NativeTypeName("const Size &")] Size* size)
    {
        X = location->X;
        Y = location->Y;
        Width = size->Width;
        Height = size->Height;
    }

    [return: NativeTypeName("Gdiplus::Rect *")]
    public GpRect* Clone()
    {
        return cxx_new<GpRect>(sizeof(GpRect));
        = new GpRect(X, Y, Width, Height)}

    public void GetLocation([NativeTypeName("Gdiplus::Point *")] GpPoint* point)
    {
        point->X = X;
        point->Y = Y;
    }

    public void GetSize([NativeTypeName("Gdiplus::Size *")] Size* size)
    {
        size->Width = Width;
        size->Height = Height;
    }

    public void GetBounds([NativeTypeName("Gdiplus::Rect *")] GpRect* rect)
    {
        rect->X = X;
        rect->Y = Y;
        rect->Width = Width;
        rect->Height = Height;
    }

    public int GetLeft()
    {
        return X;
    }

    public int GetTop()
    {
        return Y;
    }

    public int GetRight()
    {
        return X + Width;
    }

    public int GetBottom()
    {
        return Y + Height;
    }

    public BOOL IsEmptyArea()
    {
        return ((Width <= 0) || (Height <= 0)) ? 1 : 0;
    }

    public BOOL Equals([NativeTypeName("const Rect &")] GpRect* rect)
    {
        return (X == rect->X && Y == rect->Y && Width == rect->Width && Height == rect->Height) ? 1 : 0;
    }

    public BOOL Contains(int x, int y)
    {
        return (x >= X && x < X + Width && y >= Y && y < Y + Height) ? 1 : 0;
    }

    public BOOL Contains([NativeTypeName("const Point &")] GpPoint* pt)
    {
        return Contains(pt->X, pt->Y);
    }

    public BOOL Contains([NativeTypeName("Gdiplus::Rect &")] GpRect* rect)
    {
        return ((X <= rect->X) && (rect->GetRight() <= GetRight()) && (Y <= rect->Y) && (rect->GetBottom() <= GetBottom())) ? 1 : 0;
    }

    public void Inflate(int dx, int dy)
    {
        X -= dx;
        Y -= dy;
        Width += 2 * dx;
        Height += 2 * dy;
    }

    public void Inflate([NativeTypeName("const Point &")] GpPoint* point)
    {
        Inflate(point->X, point->Y);
    }

    public BOOL Intersect([NativeTypeName("const Rect &")] GpRect* rect)
    {
        return Intersect(this, this, rect);
    }

    public static BOOL Intersect([NativeTypeName("Gdiplus::Rect &")] GpRect* c, [NativeTypeName("const Rect &")] GpRect* a, [NativeTypeName("const Rect &")] GpRect* b)
    {
        int right = (((a->GetRight()) < (b->GetRight())) ? (a->GetRight()) : (b->GetRight()));
        int bottom = (((a->GetBottom()) < (b->GetBottom())) ? (a->GetBottom()) : (b->GetBottom()));
        int left = (((a->GetLeft()) > (b->GetLeft())) ? (a->GetLeft()) : (b->GetLeft()));
        int top = (((a->GetTop()) > (b->GetTop())) ? (a->GetTop()) : (b->GetTop()));
        c->X = left;
        c->Y = top;
        c->Width = right - left;
        c->Height = bottom - top;
        return (c->IsEmptyArea() == 0) ? 1 : 0;
    }

    public BOOL IntersectsWith([NativeTypeName("const Rect &")] GpRect* rect)
    {
        return (GetLeft() < rect->GetRight() && GetTop() < rect->GetBottom() && GetRight() > rect->GetLeft() && GetBottom() > rect->GetTop()) ? 1 : 0;
    }

    public static BOOL Union([NativeTypeName("Gdiplus::Rect &")] GpRect* c, [NativeTypeName("const Rect &")] GpRect* a, [NativeTypeName("const Rect &")] GpRect* b)
    {
        int right = (((a->GetRight()) > (b->GetRight())) ? (a->GetRight()) : (b->GetRight()));
        int bottom = (((a->GetBottom()) > (b->GetBottom())) ? (a->GetBottom()) : (b->GetBottom()));
        int left = (((a->GetLeft()) < (b->GetLeft())) ? (a->GetLeft()) : (b->GetLeft()));
        int top = (((a->GetTop()) < (b->GetTop())) ? (a->GetTop()) : (b->GetTop()));
        c->X = left;
        c->Y = top;
        c->Width = right - left;
        c->Height = bottom - top;
        return (c->IsEmptyArea() == 0) ? 1 : 0;
    }

    public void Offset([NativeTypeName("const Point &")] GpPoint* point)
    {
        Offset(point->X, point->Y);
    }

    public void Offset(int dx, int dy)
    {
        X += dx;
        Y += dy;
    }
}