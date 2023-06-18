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

public unsafe static class D2D1SvgPaintVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgPaint> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SvgPaint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SvgPaint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgPaint> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetElement(this ComPtr<ID2D1SvgPaint> thisVtbl, ID2D1SvgElement** element)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int Clone(this ComPtr<ID2D1SvgPaint> thisVtbl, ID2D1SvgAttribute** attribute)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attribute);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetPaintType(this ComPtr<ID2D1SvgPaint> thisVtbl, SvgPaintType paintType)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType, int>)@this->LpVtbl[6])(@this, paintType);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static SvgPaintType GetPaintType(this ComPtr<ID2D1SvgPaint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        SvgPaintType ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, SvgPaintType>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetColor(this ComPtr<ID2D1SvgPaint> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[8])(@this, color);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetColor(this ComPtr<ID2D1SvgPaint> thisVtbl, Silk.NET.DXGI.D3Dcolorvalue* color)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, Silk.NET.DXGI.D3Dcolorvalue*, void>)@this->LpVtbl[9])(@this, color);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetId(this ComPtr<ID2D1SvgPaint> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, int>)@this->LpVtbl[10])(@this, id);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetId(this ComPtr<ID2D1SvgPaint> thisVtbl, char* id, uint idCount)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, char*, uint, int>)@this->LpVtbl[11])(@this, id, idCount);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetIdLength(this ComPtr<ID2D1SvgPaint> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPaint*, uint>)@this->LpVtbl[12])(@this);
        return ret;
    }

}
