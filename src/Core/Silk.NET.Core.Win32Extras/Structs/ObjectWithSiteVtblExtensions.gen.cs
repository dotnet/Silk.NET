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

public unsafe static class ObjectWithSiteVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IObjectWithSite> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IObjectWithSite> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IObjectWithSite> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IObjectWithSite> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IObjectWithSite> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IObjectWithSite> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int SetSite(this ComPtr<IObjectWithSite> thisVtbl, Silk.NET.Core.Native.IUnknown* pUnkSite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkSite);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int SetSite(this ComPtr<IObjectWithSite> thisVtbl, ref Silk.NET.Core.Native.IUnknown pUnkSite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Silk.NET.Core.Native.IUnknown* pUnkSitePtr = &pUnkSite)
        {
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Silk.NET.Core.Native.IUnknown*, int>)@this->LpVtbl[3])(@this, pUnkSitePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSite(this ComPtr<IObjectWithSite> thisVtbl, Guid* riid, void** ppvSite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvSite);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSite(this ComPtr<IObjectWithSite> thisVtbl, Guid* riid, ref void* ppvSite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvSitePtr = &ppvSite)
        {
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riid, ppvSitePtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSite(this ComPtr<IObjectWithSite> thisVtbl, ref Guid riid, void** ppvSite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvSite);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSite(this ComPtr<IObjectWithSite> thisVtbl, ref Guid riid, ref void* ppvSite)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvSitePtr = &ppvSite)
            {
                ret = ((delegate* unmanaged[Cdecl]<IObjectWithSite*, Guid*, void**, int>)@this->LpVtbl[4])(@this, riidPtr, ppvSitePtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IObjectWithSite> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IObjectWithSite> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IObjectWithSite> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int SetSite<TI0>(this ComPtr<IObjectWithSite> thisVtbl, ComPtr<TI0> pUnkSite) where TI0 : unmanaged, IComVtbl<Silk.NET.Core.Native.IUnknown>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->SetSite((Silk.NET.Core.Native.IUnknown*) pUnkSite.Handle);
    }

    /// <summary>To be documented.</summary>
    public static int SetSite(this ComPtr<IObjectWithSite> thisVtbl, Span<Silk.NET.Core.Native.IUnknown> pUnkSite)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->SetSite(ref pUnkSite.GetPinnableReference());
    }

    /// <summary>To be documented.</summary>
    public static int GetSite<TI0>(this ComPtr<IObjectWithSite> thisVtbl, out ComPtr<TI0> ppvSite) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvSite = default;
        return @this->GetSite(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvSite.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSite(this ComPtr<IObjectWithSite> thisVtbl, Span<Guid> riid, void** ppvSite)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSite(ref riid.GetPinnableReference(), ppvSite);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetSite(this ComPtr<IObjectWithSite> thisVtbl, Span<Guid> riid, ref void* ppvSite)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->GetSite(ref riid.GetPinnableReference(), ref ppvSite);
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IObjectWithSite> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> GetSite<TI0>(this ComPtr<IObjectWithSite> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->GetSite(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}
