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

namespace Silk.NET.Core.Win32Extras;

public unsafe static class ActivationFilterVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IActivationFilter> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IActivationFilter> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IActivationFilter> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IActivationFilter> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IActivationFilter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IActivationFilter> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HandleActivation(this ComPtr<IActivationFilter> thisVtbl, uint dwActivationType, Guid* rclsid, Guid* pReplacementClsId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint, Guid*, Guid*, int>)@this->LpVtbl[3])(@this, dwActivationType, rclsid, pReplacementClsId);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HandleActivation(this ComPtr<IActivationFilter> thisVtbl, uint dwActivationType, Guid* rclsid, ref Guid pReplacementClsId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* pReplacementClsIdPtr = &pReplacementClsId)
        {
            ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint, Guid*, Guid*, int>)@this->LpVtbl[3])(@this, dwActivationType, rclsid, pReplacementClsIdPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HandleActivation(this ComPtr<IActivationFilter> thisVtbl, uint dwActivationType, ref Guid rclsid, Guid* pReplacementClsId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rclsidPtr = &rclsid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint, Guid*, Guid*, int>)@this->LpVtbl[3])(@this, dwActivationType, rclsidPtr, pReplacementClsId);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int HandleActivation(this ComPtr<IActivationFilter> thisVtbl, uint dwActivationType, ref Guid rclsid, ref Guid pReplacementClsId)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* rclsidPtr = &rclsid)
        {
            fixed (Guid* pReplacementClsIdPtr = &pReplacementClsId)
            {
                ret = ((delegate* unmanaged[Cdecl]<IActivationFilter*, uint, Guid*, Guid*, int>)@this->LpVtbl[3])(@this, dwActivationType, rclsidPtr, pReplacementClsIdPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IActivationFilter> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IActivationFilter> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IActivationFilter> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HandleActivation(this ComPtr<IActivationFilter> thisVtbl, uint dwActivationType, Guid* rclsid, Span<Guid> pReplacementClsId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HandleActivation(dwActivationType, rclsid, ref pReplacementClsId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int HandleActivation(this ComPtr<IActivationFilter> thisVtbl, uint dwActivationType, Span<Guid> rclsid, Guid* pReplacementClsId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HandleActivation(dwActivationType, ref rclsid.GetPinnableReference(), pReplacementClsId);
    }

    /// <summary>To be documented.</summary>
    public static int HandleActivation(this ComPtr<IActivationFilter> thisVtbl, uint dwActivationType, Span<Guid> rclsid, Span<Guid> pReplacementClsId)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->HandleActivation(dwActivationType, ref rclsid.GetPinnableReference(), ref pReplacementClsId.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IActivationFilter> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
