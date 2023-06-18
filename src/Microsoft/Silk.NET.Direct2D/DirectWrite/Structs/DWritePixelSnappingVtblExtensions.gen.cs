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

namespace Silk.NET.DirectWrite;

public unsafe static class DWritePixelSnappingVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWritePixelSnapping> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWritePixelSnapping> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWritePixelSnapping> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int IsPixelSnappingDisabled(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, int* isDisabled)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, int*, int>)@this->LpVtbl[3])(@this, clientDrawingContext, isDisabled);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetCurrentTransform(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, Matrix* transform)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, Matrix*, int>)@this->LpVtbl[4])(@this, clientDrawingContext, transform);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetPixelsPerDip(this ComPtr<IDWritePixelSnapping> thisVtbl, void* clientDrawingContext, float* pixelsPerDip)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWritePixelSnapping*, void*, float*, int>)@this->LpVtbl[5])(@this, clientDrawingContext, pixelsPerDip);
        return ret;
    }

}
