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

namespace Silk.NET.DirectComposition;

public unsafe static class DCompositionRectangleClipVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionRectangleClip> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionRectangleClip> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionRectangleClip> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionRectangleClip> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionRectangleClip> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionRectangleClip> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetLeft(this ComPtr<IDCompositionRectangleClip> thisVtbl, float left)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[4])(@this, left);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTop(this ComPtr<IDCompositionRectangleClip> thisVtbl, float top)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[6])(@this, top);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetRight(this ComPtr<IDCompositionRectangleClip> thisVtbl, float right)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[8])(@this, right);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBottom(this ComPtr<IDCompositionRectangleClip> thisVtbl, float bottom)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[10])(@this, bottom);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTopLeftRadiusX(this ComPtr<IDCompositionRectangleClip> thisVtbl, float radius)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[12])(@this, radius);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTopLeftRadiusY(this ComPtr<IDCompositionRectangleClip> thisVtbl, float radius)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[14])(@this, radius);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTopRightRadiusX(this ComPtr<IDCompositionRectangleClip> thisVtbl, float radius)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[16])(@this, radius);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetTopRightRadiusY(this ComPtr<IDCompositionRectangleClip> thisVtbl, float radius)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[18])(@this, radius);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBottomLeftRadiusX(this ComPtr<IDCompositionRectangleClip> thisVtbl, float radius)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[20])(@this, radius);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBottomLeftRadiusY(this ComPtr<IDCompositionRectangleClip> thisVtbl, float radius)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[22])(@this, radius);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBottomRightRadiusX(this ComPtr<IDCompositionRectangleClip> thisVtbl, float radius)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[24])(@this, radius);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetBottomRightRadiusY(this ComPtr<IDCompositionRectangleClip> thisVtbl, float radius)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionRectangleClip*, float, int>)@this->LpVtbl[26])(@this, radius);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionRectangleClip> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionRectangleClip> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionRectangleClip> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionRectangleClip> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
