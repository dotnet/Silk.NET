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

public unsafe static class D2D1GdiInteropRenderTargetVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetDC(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, DCInitializeMode mode, nint* hdc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, DCInitializeMode, nint*, int>)@this->LpVtbl[3])(@this, mode, hdc);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int GetDC(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, DCInitializeMode mode, ref nint hdc)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (nint* hdcPtr = &hdc)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, DCInitializeMode, nint*, int>)@this->LpVtbl[3])(@this, mode, hdcPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int ReleaseDC(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Box2D<int>* update)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[4])(@this, update);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseDC(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Silk.NET.Maths.Box2D<int> update)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<int>* updatePtr = &update)
        {
            ret = ((delegate* unmanaged[Stdcall]<ID2D1GdiInteropRenderTarget*, Silk.NET.Maths.Box2D<int>*, int>)@this->LpVtbl[4])(@this, updatePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetDC(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, DCInitializeMode mode, Span<nint> hdc)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetDC(mode, ref hdc.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int ReleaseDC(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ReadOnlySpan<Silk.NET.Maths.Box2D<int>> update)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->ReleaseDC(in update.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<ID2D1GdiInteropRenderTarget> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
