// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct2D;

public unsafe static class D2D1StrokeStyleVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1StrokeStyle> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1StrokeStyle> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static CapStyle GetStartCap(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CapStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, CapStyle>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CapStyle GetEndCap(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CapStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, CapStyle>)@this->LpVtbl[5])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static CapStyle GetDashCap(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        CapStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, CapStyle>)@this->LpVtbl[6])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetMiterLimit(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, float>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static LineJoin GetLineJoin(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        LineJoin ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, LineJoin>)@this->LpVtbl[8])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static float GetDashOffset(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        float ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, float>)@this->LpVtbl[9])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static DashStyle GetDashStyle(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        DashStyle ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, DashStyle>)@this->LpVtbl[10])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetDashesCount(this ComPtr<ID2D1StrokeStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, uint>)@this->LpVtbl[11])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetDashes(this ComPtr<ID2D1StrokeStyle> thisVtbl, float* dashes, uint dashesCount)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1StrokeStyle*, float*, uint, void>)@this->LpVtbl[12])(@this, dashes, dashesCount);
    }

}
