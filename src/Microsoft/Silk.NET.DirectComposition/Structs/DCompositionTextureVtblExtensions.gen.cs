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

public unsafe static class DCompositionTextureVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTexture> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTexture> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTexture> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTexture> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDCompositionTexture> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDCompositionTexture> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSourceRect(this ComPtr<IDCompositionTexture> thisVtbl, Silk.NET.Maths.Box2D<uint>* sourceRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[3])(@this, sourceRect);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceRect(this ComPtr<IDCompositionTexture> thisVtbl, ref Silk.NET.Maths.Box2D<uint> sourceRect)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Maths.Box2D<uint>* sourceRectPtr = &sourceRect)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Silk.NET.Maths.Box2D<uint>*, int>)@this->LpVtbl[3])(@this, sourceRectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetColorSpace(this ComPtr<IDCompositionTexture> thisVtbl, Silk.NET.DXGI.ColorSpaceType colorSpace)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Silk.NET.DXGI.ColorSpaceType, int>)@this->LpVtbl[4])(@this, colorSpace);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetAlphaMode(this ComPtr<IDCompositionTexture> thisVtbl, Silk.NET.DXGI.AlphaMode alphaMode)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, Silk.NET.DXGI.AlphaMode, int>)@this->LpVtbl[5])(@this, alphaMode);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ulong* fenceValue, Guid* iid, void** availableFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValue, iid, availableFence);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ulong* fenceValue, Guid* iid, ref void* availableFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** availableFencePtr = &availableFence)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValue, iid, availableFencePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ulong* fenceValue, ref Guid iid, void** availableFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValue, iidPtr, availableFence);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ulong* fenceValue, ref Guid iid, ref void* availableFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* iidPtr = &iid)
        {
            fixed (void** availableFencePtr = &availableFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValue, iidPtr, availableFencePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ref ulong fenceValue, Guid* iid, void** availableFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* fenceValuePtr = &fenceValue)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValuePtr, iid, availableFence);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ref ulong fenceValue, Guid* iid, ref void* availableFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* fenceValuePtr = &fenceValue)
        {
            fixed (void** availableFencePtr = &availableFence)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValuePtr, iid, availableFencePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ref ulong fenceValue, ref Guid iid, void** availableFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* fenceValuePtr = &fenceValue)
        {
            fixed (Guid* iidPtr = &iid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValuePtr, iidPtr, availableFence);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ref ulong fenceValue, ref Guid iid, ref void* availableFence)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (ulong* fenceValuePtr = &fenceValue)
        {
            fixed (Guid* iidPtr = &iid)
            {
                fixed (void** availableFencePtr = &availableFence)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionTexture*, ulong*, Guid*, void**, int>)@this->LpVtbl[6])(@this, fenceValuePtr, iidPtr, availableFencePtr);
                }
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDCompositionTexture> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTexture> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDCompositionTexture> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetSourceRect(this ComPtr<IDCompositionTexture> thisVtbl, Span<Silk.NET.Maths.Box2D<uint>> sourceRect)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSourceRect(ref sourceRect.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence<TI0>(this ComPtr<IDCompositionTexture> thisVtbl, ulong* fenceValue, out ComPtr<TI0> availableFence) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        availableFence = default;
        return @this->GetAvailableFence(fenceValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) availableFence.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ulong* fenceValue, Span<Guid> iid, void** availableFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAvailableFence(fenceValue, ref iid.GetPinnableReference(), availableFence);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, ulong* fenceValue, Span<Guid> iid, ref void* availableFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAvailableFence(fenceValue, ref iid.GetPinnableReference(), ref availableFence);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, Span<ulong> fenceValue, Guid* iid, void** availableFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAvailableFence(ref fenceValue.GetPinnableReference(), iid, availableFence);
    }

    /// <summary>To be documented.</summary>
    public static int GetAvailableFence<TI0>(this ComPtr<IDCompositionTexture> thisVtbl, ref ulong fenceValue, out ComPtr<TI0> availableFence) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        availableFence = default;
        return @this->GetAvailableFence(ref fenceValue, SilkMarshal.GuidPtrOf<TI0>(), (void**) availableFence.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, Span<ulong> fenceValue, Guid* iid, ref void* availableFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAvailableFence(ref fenceValue.GetPinnableReference(), iid, ref availableFence);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, Span<ulong> fenceValue, Span<Guid> iid, void** availableFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAvailableFence(ref fenceValue.GetPinnableReference(), ref iid.GetPinnableReference(), availableFence);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetAvailableFence(this ComPtr<IDCompositionTexture> thisVtbl, Span<ulong> fenceValue, Span<Guid> iid, ref void* availableFence)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetAvailableFence(ref fenceValue.GetPinnableReference(), ref iid.GetPinnableReference(), ref availableFence);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDCompositionTexture> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static unsafe ComPtr<TI0> GetAvailableFence<TI0>(this ComPtr<IDCompositionTexture> thisVtbl, ulong* fenceValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetAvailableFence(fenceValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetAvailableFence<TI0>(this ComPtr<IDCompositionTexture> thisVtbl, ref ulong fenceValue) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetAvailableFence(ref fenceValue, out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
