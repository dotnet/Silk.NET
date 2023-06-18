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

public unsafe static class D2D1SvgGlyphStyleVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFactory(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Factory** factory)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetFill(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush* brush)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, int>)@this->LpVtbl[4])(@this, brush);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetFill(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, void>)@this->LpVtbl[5])(@this, brush);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush* brush, float strokeWidth, [Flow(Silk.NET.Core.Native.FlowDirection.In)] float* dashes, uint dashesCount, float dashOffset)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush*, float, float*, uint, float, int>)@this->LpVtbl[6])(@this, brush, strokeWidth, dashes, dashesCount, dashOffset);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetStrokeDashesCount(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, uint>)@this->LpVtbl[7])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe void GetStroke(this ComPtr<ID2D1SvgGlyphStyle> thisVtbl, ID2D1Brush** brush, float* strokeWidth, float* dashes, uint dashesCount, float* dashOffset)
    {
        var @this = thisVtbl.Handle;
        ((delegate* unmanaged[Stdcall]<ID2D1SvgGlyphStyle*, ID2D1Brush**, float*, float*, uint, float*, void>)@this->LpVtbl[8])(@this, brush, strokeWidth, dashes, dashesCount, dashOffset);
    }

}
